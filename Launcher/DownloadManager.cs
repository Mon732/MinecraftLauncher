using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public static class DownloadManager
    {
        static Queue downloadQueue = new Queue();
        static bool downloading = false;
        static ProgressBar progress;
        static Action<object> currentCallback;
        static object currentCallbackArg;
        static WebClient downloadFile;

        struct Download
        {
            public string downloadUrl;
            public string filename;
            public Action<object> callback;
            public object callbackArg;
        }

        public static void setProgressBar(ProgressBar progressBar)
        {
            progress = progressBar;
        }

        public static void queueDownload(string downloadUrl, string filename, Action<object> callback = null, object callbackArg = null)
        {
            Download download;
            download.downloadUrl = downloadUrl;
            download.filename = filename;
            download.callback = callback;
            download.callbackArg = callbackArg;

            downloadQueue.Enqueue(download);
        }

        public static void processDownload()
        {
            if (!downloading)
            {
                try
                {
                    Download download = (Download)downloadQueue.Dequeue();

                    currentCallback = download.callback;
                    currentCallbackArg = download.callbackArg;

                    downloadFile = new WebClient();

                    downloadFile.DownloadProgressChanged += webClient_DownloadProgressChanged;
                    downloadFile.DownloadFileCompleted += downloadFile_DownloadFileCompleted;
                    downloadFile.DownloadFileAsync(new Uri(download.downloadUrl), download.filename);
                    downloading = true;
                }
                catch (InvalidOperationException) //Empty Queue, breaks cycle
                {
                    return;
                }
            }
        }

        public static void cancelDownload()
        {
            downloadFile.CancelAsync();
        }

        static void webClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progress.Value = e.ProgressPercentage;
        }

        static void downloadFile_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            downloading = false;
            
            if (e.Cancelled)
            {
                return;
            }

            if (currentCallback != null)
            {
                currentCallback(currentCallbackArg);
            }

            processDownload();
        }
    }
}
