using System.Windows.Forms;

namespace WFZ_Editor.Forms.Editors
{
    partial class ProjectForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("@wfz");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Lists");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Backgrounds");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Graduations");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Time Hands");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("DataWidget");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Fonts");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Resources", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tvProject = new System.Windows.Forms.TreeView();
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imgListProj = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pgPropriedades = new System.Windows.Forms.PropertyGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbHi = new System.Windows.Forms.TabPage();
            this.picPreview1 = new System.Windows.Forms.PictureBox();
            this.tbLo = new System.Windows.Forms.TabPage();
            this.picPreview2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuContext.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbHi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).BeginInit();
            this.tbLo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pgPropriedades, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 475);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tvProject);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 469);
            this.panel1.TabIndex = 1;
            // 
            // tvProject
            // 
            this.tvProject.ContextMenuStrip = this.menuContext;
            this.tvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvProject.ImageIndex = 0;
            this.tvProject.ImageList = this.imgListProj;
            this.tvProject.Location = new System.Drawing.Point(0, 25);
            this.tvProject.Name = "tvProject";
            treeNode1.Name = "@wfz";
            treeNode1.Tag = "PROJECT";
            treeNode1.Text = "@wfz";
            treeNode2.ImageKey = "object.png";
            treeNode2.Name = "lists";
            treeNode2.Text = "Lists";
            treeNode3.ImageKey = "background.png";
            treeNode3.Name = "background";
            treeNode3.Text = "Backgrounds";
            treeNode4.ImageKey = "rule.png";
            treeNode4.Name = "graduation";
            treeNode4.Text = "Graduations";
            treeNode5.ImageKey = "clock.png";
            treeNode5.Name = "timehand";
            treeNode5.Text = "Time Hands";
            treeNode6.ImageKey = "widget.png";
            treeNode6.Name = "datawidget";
            treeNode6.Text = "DataWidget";
            treeNode7.ImageKey = "font.png";
            treeNode7.Name = "font";
            treeNode7.Text = "Fonts";
            treeNode8.Name = "resources";
            treeNode8.Tag = "RESOURCES";
            treeNode8.Text = "Resources";
            this.tvProject.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode8});
            this.tvProject.SelectedImageIndex = 0;
            this.tvProject.Size = new System.Drawing.Size(276, 444);
            this.tvProject.TabIndex = 1;
            this.tvProject.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProject_AfterSelect);
            // 
            // menuContext
            // 
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAdd,
            this.toolStripSeparator1});
            this.menuContext.Name = "menuContext";
            this.menuContext.Size = new System.Drawing.Size(97, 32);
            // 
            // tsmAdd
            // 
            this.tsmAdd.Name = "tsmAdd";
            this.tsmAdd.Size = new System.Drawing.Size(96, 22);
            this.tsmAdd.Text = "Add";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(93, 6);
            // 
            // imgListProj
            // 
            this.imgListProj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListProj.ImageStream")));
            this.imgListProj.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListProj.Images.SetKeyName(0, "object.png");
            this.imgListProj.Images.SetKeyName(1, "rule.png");
            this.imgListProj.Images.SetKeyName(2, "background.png");
            this.imgListProj.Images.SetKeyName(3, "clock.png");
            this.imgListProj.Images.SetKeyName(4, "font.png");
            this.imgListProj.Images.SetKeyName(5, "widget.png");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(276, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pgPropriedades
            // 
            this.pgPropriedades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgPropriedades.Location = new System.Drawing.Point(576, 3);
            this.pgPropriedades.Name = "pgPropriedades";
            this.pgPropriedades.Size = new System.Drawing.Size(278, 469);
            this.pgPropriedades.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(285, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 469);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(7, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 147);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbHi);
            this.tabControl1.Controls.Add(this.tbLo);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(279, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tbHi
            // 
            this.tbHi.Controls.Add(this.picPreview1);
            this.tbHi.Location = new System.Drawing.Point(4, 22);
            this.tbHi.Name = "tbHi";
            this.tbHi.Padding = new System.Windows.Forms.Padding(3);
            this.tbHi.Size = new System.Drawing.Size(271, 277);
            this.tbHi.TabIndex = 0;
            this.tbHi.Text = "Hi-Fi";
            this.tbHi.UseVisualStyleBackColor = true;
            // 
            // picPreview1
            // 
            this.picPreview1.BackgroundImage = global::WFZ_Editor.Properties.Resources.transp;
            this.picPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview1.Location = new System.Drawing.Point(3, 3);
            this.picPreview1.Name = "picPreview1";
            this.picPreview1.Size = new System.Drawing.Size(265, 271);
            this.picPreview1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview1.TabIndex = 0;
            this.picPreview1.TabStop = false;
            // 
            // tbLo
            // 
            this.tbLo.Controls.Add(this.picPreview2);
            this.tbLo.Location = new System.Drawing.Point(4, 22);
            this.tbLo.Name = "tbLo";
            this.tbLo.Padding = new System.Windows.Forms.Padding(3);
            this.tbLo.Size = new System.Drawing.Size(271, 277);
            this.tbLo.TabIndex = 1;
            this.tbLo.Text = "Lo-Fi";
            this.tbLo.UseVisualStyleBackColor = true;
            // 
            // picPreview2
            // 
            this.picPreview2.BackgroundImage = global::WFZ_Editor.Properties.Resources.transp;
            this.picPreview2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPreview2.Location = new System.Drawing.Point(3, 3);
            this.picPreview2.Name = "picPreview2";
            this.picPreview2.Size = new System.Drawing.Size(265, 271);
            this.picPreview2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview2.TabIndex = 0;
            this.picPreview2.TabStop = false;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 475);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectForm";
            this.Text = "Project";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuContext.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbHi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview1)).EndInit();
            this.tbLo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tvProject;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PropertyGrid pgPropriedades;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbHi;
        private System.Windows.Forms.TabPage tbLo;
        private System.Windows.Forms.ImageList imgListProj;
        private System.Windows.Forms.ContextMenuStrip menuContext;
        private System.Windows.Forms.ToolStripMenuItem tsmAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private PictureBox picPreview1;
        private PictureBox picPreview2;
    }
}