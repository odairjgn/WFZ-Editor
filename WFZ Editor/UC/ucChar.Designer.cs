namespace WFZ_Editor.UC
{
    partial class ucChar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbChar = new System.Windows.Forms.Label();
            this.pictureBox1 = new PicPreview();
            this.lbHex = new System.Windows.Forms.Label();
            this.btOpc = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.AutoSize = true;
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(0, 4);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(24, 20);
            this.lbChar.TabIndex = 0;
            this.lbChar.Text = "...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::WFZ_Editor.Properties.Resources.transp;
            this.pictureBox1.Location = new System.Drawing.Point(4, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbHex
            // 
            this.lbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHex.Location = new System.Drawing.Point(4, 137);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(92, 18);
            this.lbHex.TabIndex = 4;
            this.lbHex.Text = "0x0000";
            this.lbHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOpc
            // 
            this.btOpc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpc.Location = new System.Drawing.Point(67, 2);
            this.btOpc.Name = "btOpc";
            this.btOpc.Size = new System.Drawing.Size(29, 23);
            this.btOpc.TabIndex = 5;
            this.btOpc.Text = "...";
            this.btOpc.UseVisualStyleBackColor = true;
            this.btOpc.Click += new System.EventHandler(this.btOpc_Click);
            // 
            // ofdImage
            // 
            this.ofdImage.Filter = "Images|*.png; *.jpg; *.jpeg; *.bmp; *.gif";
            // 
            // ucChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btOpc);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbChar);
            this.Name = "ucChar";
            this.Size = new System.Drawing.Size(99, 155);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChar;
        private PicPreview pictureBox1;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.Button btOpc;
        private System.Windows.Forms.OpenFileDialog ofdImage;
    }
}
