namespace GameMover3000.Controls
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.directoryView2 = new GameMover3000.Controls.DirectoryView();
            this.directoryView1 = new GameMover3000.Controls.DirectoryView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.directoryView2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.directoryView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(671, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // directoryView2
            // 
            this.directoryView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryView2.Location = new System.Drawing.Point(337, 4);
            this.directoryView2.Margin = new System.Windows.Forms.Padding(2, 4, 4, 0);
            this.directoryView2.Name = "directoryView2";
            this.directoryView2.Size = new System.Drawing.Size(330, 548);
            this.directoryView2.TabIndex = 1;
            // 
            // directoryView1
            // 
            this.directoryView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryView1.Location = new System.Drawing.Point(4, 4);
            this.directoryView1.Margin = new System.Windows.Forms.Padding(4, 4, 2, 0);
            this.directoryView1.Name = "directoryView1";
            this.directoryView1.Size = new System.Drawing.Size(329, 548);
            this.directoryView1.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 552);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "GameMover 3000";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DirectoryView directoryView2;
        private DirectoryView directoryView1;
    }
}