namespace ToNSaveManager.Windows
{
    partial class TrackerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackerWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)trackerWebView).BeginInit();
            SuspendLayout();
            // 
            // trackerWebView
            // 
            trackerWebView.AllowExternalDrop = true;
            trackerWebView.CreationProperties = null;
            trackerWebView.DefaultBackgroundColor = Color.White;
            trackerWebView.Dock = DockStyle.Fill;
            trackerWebView.Location = new Point(0, 0);
            trackerWebView.Name = "trackerWebView";
            trackerWebView.Size = new Size(904, 761);
            trackerWebView.TabIndex = 0;
            trackerWebView.ZoomFactor = 0.5D;
            // 
            // TrackerWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 761);
            Controls.Add(trackerWebView);
            Name = "TrackerWindow";
            Text = "TrackerWindow";
            ((System.ComponentModel.ISupportInitialize)trackerWebView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 trackerWebView;
    }
}