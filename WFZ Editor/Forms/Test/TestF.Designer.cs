using System.Windows.Forms;

namespace WFZ_Editor.Forms.Test
{
    partial class TestF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestF));
            this.picPreview1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview1
            // 
            this.picPreview1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picPreview1.BackgroundImage")));
            this.picPreview1.Location = new System.Drawing.Point(94, 29);
            this.picPreview1.Name = "picPreview1";
            this.picPreview1.Size = new System.Drawing.Size(100, 50);
            this.picPreview1.TabIndex = 0;
            this.picPreview1.TabStop = false;
            // 
            // TestF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 118);
            this.Controls.Add(this.picPreview1);
            this.Name = "TestF";
            this.Text = "TestF";
            this.Load += new System.EventHandler(this.TestF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox picPreview1;
    }
}