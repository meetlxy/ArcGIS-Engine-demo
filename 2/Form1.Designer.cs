namespace GIS实验3_lxy07162801
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文档OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加数据AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空图层ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.距离量算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.距离量算ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.面积量算ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.量算清除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.缓冲区分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.axToolbarControl1 = new AxESRI.ArcGIS.Controls.AxToolbarControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.空间查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清除选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.距离量算ToolStripMenuItem,
            this.空间查询ToolStripMenuItem,
            this.清除选择ToolStripMenuItem,
            this.缓冲区分析ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文档OToolStripMenuItem,
            this.添加数据AToolStripMenuItem,
            this.添加图层ToolStripMenuItem,
            this.清空图层ToolStripMenuItem,
            this.保存文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文档OToolStripMenuItem
            // 
            this.打开文档OToolStripMenuItem.Name = "打开文档OToolStripMenuItem";
            this.打开文档OToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.打开文档OToolStripMenuItem.Text = "打开文档（&O)";
            this.打开文档OToolStripMenuItem.Click += new System.EventHandler(this.打开文档OToolStripMenuItem_Click);
            // 
            // 添加数据AToolStripMenuItem
            // 
            this.添加数据AToolStripMenuItem.Name = "添加数据AToolStripMenuItem";
            this.添加数据AToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.添加数据AToolStripMenuItem.Text = "添加数据（&A）";
            this.添加数据AToolStripMenuItem.Click += new System.EventHandler(this.添加数据AToolStripMenuItem_Click);
            // 
            // 添加图层ToolStripMenuItem
            // 
            this.添加图层ToolStripMenuItem.Name = "添加图层ToolStripMenuItem";
            this.添加图层ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.添加图层ToolStripMenuItem.Text = "添加图层";
            this.添加图层ToolStripMenuItem.Click += new System.EventHandler(this.添加图层ToolStripMenuItem_Click);
            // 
            // 清空图层ToolStripMenuItem
            // 
            this.清空图层ToolStripMenuItem.Name = "清空图层ToolStripMenuItem";
            this.清空图层ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.清空图层ToolStripMenuItem.Text = "清空图层";
            this.清空图层ToolStripMenuItem.Click += new System.EventHandler(this.清空图层ToolStripMenuItem_Click);
            // 
            // 保存文件ToolStripMenuItem
            // 
            this.保存文件ToolStripMenuItem.Name = "保存文件ToolStripMenuItem";
            this.保存文件ToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.保存文件ToolStripMenuItem.Text = "保存文件";
            this.保存文件ToolStripMenuItem.Click += new System.EventHandler(this.保存文件ToolStripMenuItem_Click);
            // 
            // 距离量算ToolStripMenuItem
            // 
            this.距离量算ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.距离量算ToolStripMenuItem1,
            this.面积量算ToolStripMenuItem,
            this.量算清除ToolStripMenuItem});
            this.距离量算ToolStripMenuItem.Name = "距离量算ToolStripMenuItem";
            this.距离量算ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.距离量算ToolStripMenuItem.Text = "量算工具";
            // 
            // 距离量算ToolStripMenuItem1
            // 
            this.距离量算ToolStripMenuItem1.Name = "距离量算ToolStripMenuItem1";
            this.距离量算ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.距离量算ToolStripMenuItem1.Text = "距离量算";
            this.距离量算ToolStripMenuItem1.Click += new System.EventHandler(this.距离量算ToolStripMenuItem1_Click);
            // 
            // 面积量算ToolStripMenuItem
            // 
            this.面积量算ToolStripMenuItem.Name = "面积量算ToolStripMenuItem";
            this.面积量算ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.面积量算ToolStripMenuItem.Text = "面积量算";
            this.面积量算ToolStripMenuItem.Click += new System.EventHandler(this.面积量算ToolStripMenuItem_Click);
            // 
            // 量算清除ToolStripMenuItem
            // 
            this.量算清除ToolStripMenuItem.Name = "量算清除ToolStripMenuItem";
            this.量算清除ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.量算清除ToolStripMenuItem.Text = "量算清除";
            this.量算清除ToolStripMenuItem.Click += new System.EventHandler(this.量算清除ToolStripMenuItem_Click);
            // 
            // 缓冲区分析ToolStripMenuItem
            // 
            this.缓冲区分析ToolStripMenuItem.Name = "缓冲区分析ToolStripMenuItem";
            this.缓冲区分析ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.缓冲区分析ToolStripMenuItem.Text = "连接数据库";
            this.缓冲区分析ToolStripMenuItem.Click += new System.EventHandler(this.缓冲区分析ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axLicenseControl1);
            this.splitContainer1.Panel2.Controls.Add(this.axMapControl1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 391);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 2;
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(268, 391);
            this.axTOCControl1.TabIndex = 1;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(486, 280);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 2;
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(528, 425);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.AxMapControl1_OnMouseDown);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.axToolbarControl1.Location = new System.Drawing.Point(0, 422);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(800, 28);
            this.axToolbarControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 131);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(268, 131);
            this.dataGridView1.TabIndex = 0;
            // 
            // 空间查询ToolStripMenuItem
            // 
            this.空间查询ToolStripMenuItem.Name = "空间查询ToolStripMenuItem";
            this.空间查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.空间查询ToolStripMenuItem.Text = "空间查询";
            this.空间查询ToolStripMenuItem.Click += new System.EventHandler(this.空间查询ToolStripMenuItem_Click);
            // 
            // 清除选择ToolStripMenuItem
            // 
            this.清除选择ToolStripMenuItem.Name = "清除选择ToolStripMenuItem";
            this.清除选择ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.清除选择ToolStripMenuItem.Text = "清除选择";
            this.清除选择ToolStripMenuItem.Click += new System.EventHandler(this.清除选择ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ArcEngine桌面应用";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文档OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加数据AToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.ToolStripMenuItem 添加图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空图层ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 距离量算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 距离量算ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 面积量算ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 量算清除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 缓冲区分析ToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 空间查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清除选择ToolStripMenuItem;
    }
}

