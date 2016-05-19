namespace GameMover2000
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_loc1Folder = new System.Windows.Forms.Label();
            this.lbl_loc1 = new System.Windows.Forms.Label();
            this.btn_refreshLoc1 = new System.Windows.Forms.Button();
            this.tb_pathLoc1 = new System.Windows.Forms.TextBox();
            this.lb_loc1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_toRight = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_toLeft = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_loc2Folder = new System.Windows.Forms.Label();
            this.lb_loc2 = new System.Windows.Forms.ListBox();
            this.btn_refreshLoc2 = new System.Windows.Forms.Button();
            this.lbl_loc2 = new System.Windows.Forms.Label();
            this.tb_pathLoc2 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_progress = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(892, 495);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_loc1Folder);
            this.panel1.Controls.Add(this.lbl_loc1);
            this.panel1.Controls.Add(this.btn_refreshLoc1);
            this.panel1.Controls.Add(this.tb_pathLoc1);
            this.panel1.Controls.Add(this.lb_loc1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 459);
            this.panel1.TabIndex = 1;
            // 
            // lbl_loc1Folder
            // 
            this.lbl_loc1Folder.AutoSize = true;
            this.lbl_loc1Folder.Location = new System.Drawing.Point(0, 62);
            this.lbl_loc1Folder.Name = "lbl_loc1Folder";
            this.lbl_loc1Folder.Size = new System.Drawing.Size(72, 13);
            this.lbl_loc1Folder.TabIndex = 4;
            this.lbl_loc1Folder.Text = "\\ - 20 GB free";
            // 
            // lbl_loc1
            // 
            this.lbl_loc1.AutoSize = true;
            this.lbl_loc1.Location = new System.Drawing.Point(0, 0);
            this.lbl_loc1.Name = "lbl_loc1";
            this.lbl_loc1.Size = new System.Drawing.Size(60, 13);
            this.lbl_loc1.TabIndex = 3;
            this.lbl_loc1.Text = "Location 1:";
            // 
            // btn_refreshLoc1
            // 
            this.btn_refreshLoc1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshLoc1.Location = new System.Drawing.Point(362, 42);
            this.btn_refreshLoc1.Name = "btn_refreshLoc1";
            this.btn_refreshLoc1.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshLoc1.TabIndex = 2;
            this.btn_refreshLoc1.Text = "Refresh";
            this.btn_refreshLoc1.UseVisualStyleBackColor = true;
            this.btn_refreshLoc1.Click += new System.EventHandler(this.btn_refreshLoc1_Click);
            // 
            // tb_pathLoc1
            // 
            this.tb_pathLoc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathLoc1.Location = new System.Drawing.Point(3, 16);
            this.tb_pathLoc1.Name = "tb_pathLoc1";
            this.tb_pathLoc1.Size = new System.Drawing.Size(434, 20);
            this.tb_pathLoc1.TabIndex = 1;
            this.tb_pathLoc1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pathLoc1_KeyDown);
            // 
            // lb_loc1
            // 
            this.lb_loc1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_loc1.FormattingEnabled = true;
            this.lb_loc1.HorizontalScrollbar = true;
            this.lb_loc1.Location = new System.Drawing.Point(3, 78);
            this.lb_loc1.Name = "lb_loc1";
            this.lb_loc1.Size = new System.Drawing.Size(434, 381);
            this.lb_loc1.TabIndex = 0;
            this.lb_loc1.DoubleClick += new System.EventHandler(this.lb_loc1_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_toRight);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 24);
            this.panel2.TabIndex = 2;
            // 
            // btn_toRight
            // 
            this.btn_toRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_toRight.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_toRight.Location = new System.Drawing.Point(179, 0);
            this.btn_toRight.Name = "btn_toRight";
            this.btn_toRight.Size = new System.Drawing.Size(89, 23);
            this.btn_toRight.TabIndex = 0;
            this.btn_toRight.Text = "Create SymLink";
            this.btn_toRight.UseVisualStyleBackColor = true;
            this.btn_toRight.Click += new System.EventHandler(this.btn_toRight_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_toLeft);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(449, 468);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(440, 24);
            this.panel3.TabIndex = 3;
            // 
            // btn_toLeft
            // 
            this.btn_toLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_toLeft.Location = new System.Drawing.Point(179, 0);
            this.btn_toLeft.Name = "btn_toLeft";
            this.btn_toLeft.Size = new System.Drawing.Size(98, 23);
            this.btn_toLeft.TabIndex = 0;
            this.btn_toLeft.Text = "Remove SymLink";
            this.btn_toLeft.UseVisualStyleBackColor = true;
            this.btn_toLeft.Click += new System.EventHandler(this.btn_toLeft_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_loc2Folder);
            this.panel4.Controls.Add(this.lb_loc2);
            this.panel4.Controls.Add(this.btn_refreshLoc2);
            this.panel4.Controls.Add(this.lbl_loc2);
            this.panel4.Controls.Add(this.tb_pathLoc2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(449, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 459);
            this.panel4.TabIndex = 4;
            // 
            // lbl_loc2Folder
            // 
            this.lbl_loc2Folder.AutoSize = true;
            this.lbl_loc2Folder.Location = new System.Drawing.Point(-2, 62);
            this.lbl_loc2Folder.Name = "lbl_loc2Folder";
            this.lbl_loc2Folder.Size = new System.Drawing.Size(72, 13);
            this.lbl_loc2Folder.TabIndex = 5;
            this.lbl_loc2Folder.Text = "\\ - 20 GB free";
            // 
            // lb_loc2
            // 
            this.lb_loc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_loc2.FormattingEnabled = true;
            this.lb_loc2.HorizontalScrollbar = true;
            this.lb_loc2.Location = new System.Drawing.Point(3, 78);
            this.lb_loc2.Name = "lb_loc2";
            this.lb_loc2.Size = new System.Drawing.Size(434, 381);
            this.lb_loc2.TabIndex = 3;
            this.lb_loc2.DoubleClick += new System.EventHandler(this.lb_loc2_DoubleClick);
            // 
            // btn_refreshLoc2
            // 
            this.btn_refreshLoc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_refreshLoc2.Location = new System.Drawing.Point(362, 42);
            this.btn_refreshLoc2.Name = "btn_refreshLoc2";
            this.btn_refreshLoc2.Size = new System.Drawing.Size(75, 23);
            this.btn_refreshLoc2.TabIndex = 2;
            this.btn_refreshLoc2.Text = "Refresh";
            this.btn_refreshLoc2.UseVisualStyleBackColor = true;
            this.btn_refreshLoc2.Click += new System.EventHandler(this.btn_refreshLoc2_Click);
            // 
            // lbl_loc2
            // 
            this.lbl_loc2.AutoSize = true;
            this.lbl_loc2.Location = new System.Drawing.Point(-3, 0);
            this.lbl_loc2.Name = "lbl_loc2";
            this.lbl_loc2.Size = new System.Drawing.Size(60, 13);
            this.lbl_loc2.TabIndex = 1;
            this.lbl_loc2.Text = "Location 2:";
            // 
            // tb_pathLoc2
            // 
            this.tb_pathLoc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pathLoc2.Location = new System.Drawing.Point(3, 16);
            this.tb_pathLoc2.Name = "tb_pathLoc2";
            this.tb_pathLoc2.Size = new System.Drawing.Size(434, 20);
            this.tb_pathLoc2.TabIndex = 0;
            this.tb_pathLoc2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pathLoc2_KeyDown);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_progress);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(449, 468);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 24);
            this.panel5.TabIndex = 5;
            // 
            // lbl_progress
            // 
            this.lbl_progress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_progress.AutoSize = true;
            this.lbl_progress.Location = new System.Drawing.Point(-2, 11);
            this.lbl_progress.Name = "lbl_progress";
            this.lbl_progress.Size = new System.Drawing.Size(21, 13);
            this.lbl_progress.TabIndex = 0;
            this.lbl_progress.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 495);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(375, 250);
            this.Name = "Form1";
            this.Text = "GameMover 2000";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_toRight;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_loc1;
        private System.Windows.Forms.Button btn_refreshLoc1;
        private System.Windows.Forms.ListBox lb_loc1;
        private System.Windows.Forms.Button btn_toLeft;
        private System.Windows.Forms.Label lbl_loc2;
        private System.Windows.Forms.TextBox tb_pathLoc2;
        private System.Windows.Forms.Label lbl_loc1Folder;
        private System.Windows.Forms.Label lbl_loc2Folder;
        private System.Windows.Forms.ListBox lb_loc2;
        private System.Windows.Forms.Button btn_refreshLoc2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_progress;
        protected System.Windows.Forms.TextBox tb_pathLoc1;
    }
}

