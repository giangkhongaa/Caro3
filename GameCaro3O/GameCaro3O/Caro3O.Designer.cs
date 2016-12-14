namespace GameCaro3O
{
    partial class Caro3O
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiChơiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NgườiĐiTrướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MáyĐiTrướcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.plBanCo = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loạiChơiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(306, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnNew
            // 
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(132, 22);
            this.btnNew.Text = "New Game";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 22);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // loạiChơiToolStripMenuItem
            // 
            this.loạiChơiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NgườiĐiTrướcToolStripMenuItem,
            this.MáyĐiTrướcToolStripMenuItem});
            this.loạiChơiToolStripMenuItem.Name = "loạiChơiToolStripMenuItem";
            this.loạiChơiToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.loạiChơiToolStripMenuItem.Text = "Loại Chơi";
            // 
            // NgườiĐiTrướcToolStripMenuItem
            // 
            this.NgườiĐiTrướcToolStripMenuItem.Name = "NgườiĐiTrướcToolStripMenuItem";
            this.NgườiĐiTrướcToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.NgườiĐiTrướcToolStripMenuItem.Text = "Người Đi Trước";
            this.NgườiĐiTrướcToolStripMenuItem.Click += new System.EventHandler(this.NgườiĐiTrướcToolStripMenuItem_Click);
            // 
            // MáyĐiTrướcToolStripMenuItem
            // 
            this.MáyĐiTrướcToolStripMenuItem.Name = "MáyĐiTrướcToolStripMenuItem";
            this.MáyĐiTrướcToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.MáyĐiTrướcToolStripMenuItem.Text = "Máy Đi Trước";
            this.MáyĐiTrướcToolStripMenuItem.Click += new System.EventHandler(this.MáyĐiTrướcToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.plBanCo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(306, 307);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // plBanCo
            // 
            this.plBanCo.BackColor = System.Drawing.Color.White;
            this.plBanCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBanCo.Location = new System.Drawing.Point(3, 3);
            this.plBanCo.Name = "plBanCo";
            this.plBanCo.Size = new System.Drawing.Size(301, 301);
            this.plBanCo.TabIndex = 1;
            this.plBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.plBanCo_Paint_1);
            this.plBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plBanCo_MouseClick);
            // 
            // Caro3O
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 331);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Caro3O";
            this.Text = "Caro 9 ô";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnNew;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem loạiChơiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NgườiĐiTrướcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MáyĐiTrướcToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel plBanCo;
    }
}

