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
            this.animatedLabel1 = new WFZ_Editor.UC.AnimatedLabel();
            this.SuspendLayout();
            // 
            // animatedLabel1
            // 
            this.animatedLabel1.Alignment = System.Drawing.StringAlignment.Center;
            this.animatedLabel1.AnimateStyle = WFZ_Editor.UC.AnimateStyle.DownToUp;
            this.animatedLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animatedLabel1.Interval = 50;
            this.animatedLabel1.LineAlignment = System.Drawing.StringAlignment.Center;
            this.animatedLabel1.Location = new System.Drawing.Point(121, 14);
            this.animatedLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.animatedLabel1.Name = "animatedLabel1";
            this.animatedLabel1.Size = new System.Drawing.Size(106, 24);
            this.animatedLabel1.Speed = 4F;
            this.animatedLabel1.TabIndex = 0;
            this.animatedLabel1.Texto = "Vamos dançar tudo nú, tudo nú! dddddddddddddddddddddddasdadsasdasd";
            // 
            // TestF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 118);
            this.Controls.Add(this.animatedLabel1);
            this.Name = "TestF";
            this.Text = "TestF";
            this.Load += new System.EventHandler(this.TestF_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC.AnimatedLabel animatedLabel1;
    }
}