namespace hygge_imaotai.UI.Main.Page
{
    partial class UserPageCommodities
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.DgvCommodityList = new Sunny.UI.UIDataGridView();
            this.BtnRefresh = new Sunny.UI.UISymbolButton();
            this.PageCommodity = new Sunny.UI.UIPagination();
            this.dgv_column_commodity_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgv_column_createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommodityList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTitlePanel1.Controls.Add(this.DgvCommodityList);
            this.uiTitlePanel1.Controls.Add(this.BtnRefresh);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 5);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(810, 513);
            this.uiTitlePanel1.TabIndex = 0;
            this.uiTitlePanel1.Text = "imaotai-商品列表";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvCommodityList
            // 
            this.DgvCommodityList.AllowUserToAddRows = false;
            this.DgvCommodityList.AllowUserToDeleteRows = false;
            this.DgvCommodityList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvCommodityList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvCommodityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCommodityList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvCommodityList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCommodityList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvCommodityList.ColumnHeadersHeight = 32;
            this.DgvCommodityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvCommodityList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_column_commodity_code,
            this.dgv_column_title,
            this.dgv_column_content,
            this.dgv_column_picture,
            this.dgv_column_createTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvCommodityList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvCommodityList.EnableHeadersVisualStyles = false;
            this.DgvCommodityList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvCommodityList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.DgvCommodityList.Location = new System.Drawing.Point(3, 84);
            this.DgvCommodityList.Name = "DgvCommodityList";
            this.DgvCommodityList.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvCommodityList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvCommodityList.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvCommodityList.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvCommodityList.RowTemplate.Height = 60;
            this.DgvCommodityList.SelectedIndex = -1;
            this.DgvCommodityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCommodityList.Size = new System.Drawing.Size(804, 426);
            this.DgvCommodityList.TabIndex = 6;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRefresh.Image = global::hygge_imaotai.Properties.Resources.refresh;
            this.BtnRefresh.Location = new System.Drawing.Point(3, 43);
            this.BtnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(264, 35);
            this.BtnRefresh.TabIndex = 2;
            this.BtnRefresh.Text = "刷新i茅台预约商品列表";
            this.BtnRefresh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // PageCommodity
            // 
            this.PageCommodity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageCommodity.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageCommodity.Location = new System.Drawing.Point(4, 528);
            this.PageCommodity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageCommodity.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageCommodity.Name = "PageCommodity";
            this.PageCommodity.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.PageCommodity.ShowText = false;
            this.PageCommodity.Size = new System.Drawing.Size(810, 37);
            this.PageCommodity.TabIndex = 1;
            this.PageCommodity.Text = "uiPagination1";
            this.PageCommodity.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageCommodity.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.PageCommodity_PageChanged);
            // 
            // dgv_column_commodity_code
            // 
            this.dgv_column_commodity_code.DataPropertyName = "itemCode";
            this.dgv_column_commodity_code.HeaderText = "预约商品code";
            this.dgv_column_commodity_code.MinimumWidth = 6;
            this.dgv_column_commodity_code.Name = "dgv_column_commodity_code";
            this.dgv_column_commodity_code.ReadOnly = true;
            this.dgv_column_commodity_code.Width = 170;
            // 
            // dgv_column_title
            // 
            this.dgv_column_title.DataPropertyName = "title";
            this.dgv_column_title.HeaderText = "标题";
            this.dgv_column_title.MinimumWidth = 6;
            this.dgv_column_title.Name = "dgv_column_title";
            this.dgv_column_title.ReadOnly = true;
            this.dgv_column_title.Width = 215;
            // 
            // dgv_column_content
            // 
            this.dgv_column_content.DataPropertyName = "content";
            this.dgv_column_content.HeaderText = "内容";
            this.dgv_column_content.MinimumWidth = 6;
            this.dgv_column_content.Name = "dgv_column_content";
            this.dgv_column_content.ReadOnly = true;
            this.dgv_column_content.Width = 160;
            // 
            // dgv_column_picture
            // 
            this.dgv_column_picture.DataPropertyName = "image";
            this.dgv_column_picture.HeaderText = "图片";
            this.dgv_column_picture.MinimumWidth = 6;
            this.dgv_column_picture.Name = "dgv_column_picture";
            this.dgv_column_picture.ReadOnly = true;
            this.dgv_column_picture.Width = 125;
            // 
            // dgv_column_createTime
            // 
            this.dgv_column_createTime.DataPropertyName = "createTime";
            this.dgv_column_createTime.HeaderText = "创建时间";
            this.dgv_column_createTime.MinimumWidth = 6;
            this.dgv_column_createTime.Name = "dgv_column_createTime";
            this.dgv_column_createTime.ReadOnly = true;
            this.dgv_column_createTime.Width = 200;
            // 
            // UserPageCommodities
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PageCommodity);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "UserPageCommodities";
            this.Size = new System.Drawing.Size(818, 570);
            this.uiTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCommodityList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIPagination PageCommodity;
        private Sunny.UI.UIDataGridView DgvCommodityList;
        private Sunny.UI.UISymbolButton BtnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_commodity_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_title;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_content;
        private System.Windows.Forms.DataGridViewImageColumn dgv_column_picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_createTime;
    }
}
