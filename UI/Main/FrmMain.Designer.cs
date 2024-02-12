namespace hygge_imaotai
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.TcmMenus = new Sunny.UI.UITabControlMenu();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UpContent = new Sunny.UI.UIPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.TcmMenus.SuspendLayout();
            this.SuspendLayout();
            // 
            // TcmMenus
            // 
            this.TcmMenus.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TcmMenus.Controls.Add(this.tabPage1);
            this.TcmMenus.Controls.Add(this.tabPage2);
            this.TcmMenus.Controls.Add(this.tabPage3);
            this.TcmMenus.Controls.Add(this.tabPage4);
            this.TcmMenus.Dock = System.Windows.Forms.DockStyle.Left;
            this.TcmMenus.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.TcmMenus.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TcmMenus.Location = new System.Drawing.Point(0, 35);
            this.TcmMenus.Multiline = true;
            this.TcmMenus.Name = "TcmMenus";
            this.TcmMenus.SelectedIndex = 0;
            this.TcmMenus.Size = new System.Drawing.Size(202, 576);
            this.TcmMenus.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TcmMenus.TabIndex = 4;
            this.TcmMenus.SelectedIndexChanged += new System.EventHandler(this.TcmMenus_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(201, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1, 576);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "首页";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(201, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1, 576);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "用户管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UpContent
            // 
            this.UpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpContent.Location = new System.Drawing.Point(202, 35);
            this.UpContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpContent.MinimumSize = new System.Drawing.Size(1, 1);
            this.UpContent.Name = "UpContent";
            this.UpContent.Size = new System.Drawing.Size(824, 576);
            this.UpContent.TabIndex = 5;
            this.UpContent.Text = "uiPanel1";
            this.UpContent.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(201, 0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1, 576);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "预约项目";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(201, 0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1, 576);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "门店列表";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1026, 611);
            this.Controls.Add(this.UpContent);
            this.Controls.Add(this.TcmMenus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.ShowTitleIcon = true;
            this.Text = "i茅台预约小助手";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.TcmMenus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITabControlMenu TcmMenus;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Sunny.UI.UIPanel UpContent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

