using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToNSaveManager.Windows
{
    public partial class TrackerWindow : Form
    {
        internal static TrackerWindow? Instance;
        public TrackerWindow()
        {
            InitializeComponent();

            this.trackerWebView.CoreWebView2InitializationCompleted += this.WebView2InitializationCompleted;

            this.trackerWebView.EnsureCoreWebView2Async(null);
        }

        public static void Open(Form parent)
        {
            if (Instance == null || Instance.IsDisposed) Instance = new TrackerWindow();

            if (Instance.Visible)
            {
                Instance.BringToFront();
                return;
            }

            Instance.StartPosition = FormStartPosition.Manual;
            Instance.Location = new Point(
                parent.Location.X + (parent.Width - Instance.Width) / 2,
                Math.Max(parent.Location.Y + (parent.Height - Instance.Height) / 2, 0)
            );
            Instance.Show(); // Don't parent
        }

        private void WebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                this.trackerWebView.CoreWebView2.Navigate("https://tontrack.me/");
                this.trackerWebView.CoreWebView2.NavigationCompleted += this.webView2_NavigationCompleted;
            }
        }

        private void webView2_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                this.trackerWebView.ExecuteScriptAsync("WSToggle()");
            }
        }
    }
}
