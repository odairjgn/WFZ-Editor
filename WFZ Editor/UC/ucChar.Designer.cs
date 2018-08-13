using System.Windows.Forms;

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
            this.picFull = new System.Windows.Forms.PictureBox();
            this.lbHex = new System.Windows.Forms.Label();
            this.btOpc = new System.Windows.Forms.Button();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pic8c = new System.Windows.Forms.PictureBox();
            this.btOpc8c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8c)).BeginInit();
            this.SuspendLayout();
            // 
            // lbChar
            // 
            this.lbChar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChar.Location = new System.Drawing.Point(38, -1);
            this.lbChar.Name = "lbChar";
            this.lbChar.Size = new System.Drawing.Size(85, 26);
            this.lbChar.TabIndex = 0;
            this.lbChar.Text = "...";
            this.lbChar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFull
            // 
            this.picFull.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picFull.BackgroundImage = global::WFZ_Editor.Properties.Resources.transp;
            this.picFull.Location = new System.Drawing.Point(3, 28);
            this.picFull.Name = "picFull";
            this.picFull.Size = new System.Drawing.Size(74, 106);
            this.picFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFull.TabIndex = 3;
            this.picFull.TabStop = false;
            // 
            // lbHex
            // 
            this.lbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHex.Location = new System.Drawing.Point(27, 137);
            this.lbHex.Name = "lbHex";
            this.lbHex.Size = new System.Drawing.Size(105, 18);
            this.lbHex.TabIndex = 4;
            this.lbHex.Text = "0x0000";
            this.lbHex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btOpc
            // 
            this.btOpc.Location = new System.Drawing.Point(3, 2);
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
            // pic8c
            // 
            this.pic8c.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic8c.BackgroundImage = global::WFZ_Editor.Properties.Resources.transp;
            this.pic8c.Location = new System.Drawing.Point(83, 28);
            this.pic8c.Name = "pic8c";
            this.pic8c.Size = new System.Drawing.Size(74, 106);
            this.pic8c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic8c.TabIndex = 6;
            this.pic8c.TabStop = false;
            // 
            // btOpc8c
            // 
            this.btOpc8c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOpc8c.Location = new System.Drawing.Point(129, 2);
            this.btOpc8c.Name = "btOpc8c";
            this.btOpc8c.Size = new System.Drawing.Size(29, 23);
            this.btOpc8c.TabIndex = 7;
            this.btOpc8c.Text = "...";
            this.btOpc8c.UseVisualStyleBackColor = true;
            this.btOpc8c.Click += new System.EventHandler(this.btOpc8c_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 9);
            this.label1.TabIndex = 8;
            this.label1.Text = "FULL";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 9);
            this.label2.TabIndex = 9;
            this.label2.Text = "8C";
            // 
            // ucChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btOpc8c);
            this.Controls.Add(this.pic8c);
            this.Controls.Add(this.btOpc);
            this.Controls.Add(this.lbHex);
            this.Controls.Add(this.picFull);
            this.Controls.Add(this.lbChar);
            this.Name = "ucChar";
            this.Size = new System.Drawing.Size(161, 155);
            ((System.ComponentModel.ISupportInitialize)(this.picFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8c)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbChar;
        private PictureBox picFull;
        private System.Windows.Forms.Label lbHex;
        private System.Windows.Forms.Button btOpc;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private PictureBox pic8c;
        private System.Windows.Forms.Button btOpc8c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
