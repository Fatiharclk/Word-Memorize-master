namespace WordMemorization
{
    partial class FormVideo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideo));
            this.wpm1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.wpm1)).BeginInit();
            this.SuspendLayout();
            // 
            // wpm1
            // 
            this.wpm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wpm1.Enabled = true;
            this.wpm1.Location = new System.Drawing.Point(0, 0);
            this.wpm1.Name = "wpm1";
            this.wpm1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wpm1.OcxState")));
            this.wpm1.Size = new System.Drawing.Size(786, 467);
            this.wpm1.TabIndex = 0;
            // 
            // FormVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 467);
            this.Controls.Add(this.wpm1);
            this.Name = "FormVideo";
            this.Text = "FormVideo";
            this.Load += new System.EventHandler(this.FormVideo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wpm1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wpm1;
    }
}