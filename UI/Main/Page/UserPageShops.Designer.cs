namespace hygge_imaotai.UI.Main.Page
{
    partial class UserPageShops
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PageShop = new Sunny.UI.UIPagination();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.BtnQuery = new Sunny.UI.UISymbolButton();
            this.TbConditionValue = new Sunny.UI.UITextBox();
            this.CmbConditionKey = new Sunny.UI.UIComboBox();
            this.DgvShopList = new Sunny.UI.UIDataGridView();
            this.BtnRefresh = new Sunny.UI.UISymbolButton();
            this.dgv_column_shop_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_fulladdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_lat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_lng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_tenantname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShopList)).BeginInit();
            this.SuspendLayout();
            // 
            // PageShop
            // 
            this.PageShop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PageShop.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PageShop.Location = new System.Drawing.Point(4, 528);
            this.PageShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageShop.MinimumSize = new System.Drawing.Size(1, 1);
            this.PageShop.Name = "PageShop";
            this.PageShop.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.PageShop.ShowText = false;
            this.PageShop.Size = new System.Drawing.Size(810, 37);
            this.PageShop.TabIndex = 3;
            this.PageShop.Text = "uiPagination1";
            this.PageShop.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.PageShop.PageChanged += new Sunny.UI.UIPagination.OnPageChangeEventHandler(this.PageShop_PageChanged);
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTitlePanel1.Controls.Add(this.BtnQuery);
            this.uiTitlePanel1.Controls.Add(this.TbConditionValue);
            this.uiTitlePanel1.Controls.Add(this.CmbConditionKey);
            this.uiTitlePanel1.Controls.Add(this.DgvShopList);
            this.uiTitlePanel1.Controls.Add(this.BtnRefresh);
            this.uiTitlePanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(4, 5);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(810, 513);
            this.uiTitlePanel1.TabIndex = 2;
            this.uiTitlePanel1.Text = "imaotai-门店列表";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.Image = global::hygge_imaotai.Properties.Resources.magnifyingIcon;
            this.BtnQuery.Location = new System.Drawing.Point(701, 43);
            this.BtnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(100, 35);
            this.BtnQuery.TabIndex = 9;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // TbConditionValue
            // 
            this.TbConditionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbConditionValue.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.TbConditionValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbConditionValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbConditionValue.Location = new System.Drawing.Point(544, 44);
            this.TbConditionValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbConditionValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.TbConditionValue.Name = "TbConditionValue";
            this.TbConditionValue.Padding = new System.Windows.Forms.Padding(5);
            this.TbConditionValue.ShowText = false;
            this.TbConditionValue.Size = new System.Drawing.Size(150, 29);
            this.TbConditionValue.TabIndex = 8;
            this.TbConditionValue.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.TbConditionValue.Watermark = "";
            // 
            // CmbConditionKey
            // 
            this.CmbConditionKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbConditionKey.DataSource = null;
            this.CmbConditionKey.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.CmbConditionKey.FillColor = System.Drawing.Color.White;
            this.CmbConditionKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbConditionKey.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.CmbConditionKey.Items.AddRange(new object[] {
            "全部",
            "商品ID",
            "省份",
            "城市",
            "地区",
            "公司名称"});
            this.CmbConditionKey.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.CmbConditionKey.Location = new System.Drawing.Point(420, 46);
            this.CmbConditionKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbConditionKey.MinimumSize = new System.Drawing.Size(63, 0);
            this.CmbConditionKey.Name = "CmbConditionKey";
            this.CmbConditionKey.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CmbConditionKey.Size = new System.Drawing.Size(115, 29);
            this.CmbConditionKey.TabIndex = 7;
            this.CmbConditionKey.Text = "全部";
            this.CmbConditionKey.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CmbConditionKey.Watermark = "";
            // 
            // DgvShopList
            // 
            this.DgvShopList.AllowUserToAddRows = false;
            this.DgvShopList.AllowUserToDeleteRows = false;
            this.DgvShopList.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvShopList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.DgvShopList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvShopList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvShopList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvShopList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.DgvShopList.ColumnHeadersHeight = 32;
            this.DgvShopList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvShopList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_column_shop_id,
            this.dgv_column_province,
            this.dgv_column_city,
            this.dgv_column_district,
            this.dgv_column_fulladdress,
            this.dgv_column_lat,
            this.dgv_column_lng,
            this.dgv_column_name,
            this.dgv_column_tenantname,
            this.dgv_column_createTime});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvShopList.DefaultCellStyle = dataGridViewCellStyle18;
            this.DgvShopList.EnableHeadersVisualStyles = false;
            this.DgvShopList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvShopList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.DgvShopList.Location = new System.Drawing.Point(3, 84);
            this.DgvShopList.Name = "DgvShopList";
            this.DgvShopList.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvShopList.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.DgvShopList.RowHeadersWidth = 51;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvShopList.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.DgvShopList.RowTemplate.Height = 27;
            this.DgvShopList.SelectedIndex = -1;
            this.DgvShopList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvShopList.Size = new System.Drawing.Size(804, 426);
            this.DgvShopList.TabIndex = 6;
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
            this.BtnRefresh.Text = "刷新i茅台门店列表";
            this.BtnRefresh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // dgv_column_shop_id
            // 
            this.dgv_column_shop_id.DataPropertyName = "id";
            this.dgv_column_shop_id.HeaderText = "门店ID";
            this.dgv_column_shop_id.MinimumWidth = 6;
            this.dgv_column_shop_id.Name = "dgv_column_shop_id";
            this.dgv_column_shop_id.ReadOnly = true;
            this.dgv_column_shop_id.Width = 170;
            // 
            // dgv_column_province
            // 
            this.dgv_column_province.DataPropertyName = "provinceName";
            this.dgv_column_province.HeaderText = "省份";
            this.dgv_column_province.MinimumWidth = 6;
            this.dgv_column_province.Name = "dgv_column_province";
            this.dgv_column_province.ReadOnly = true;
            this.dgv_column_province.Width = 215;
            // 
            // dgv_column_city
            // 
            this.dgv_column_city.DataPropertyName = "cityName";
            this.dgv_column_city.HeaderText = "城市";
            this.dgv_column_city.MinimumWidth = 6;
            this.dgv_column_city.Name = "dgv_column_city";
            this.dgv_column_city.ReadOnly = true;
            this.dgv_column_city.Width = 160;
            // 
            // dgv_column_district
            // 
            this.dgv_column_district.DataPropertyName = "districtName";
            this.dgv_column_district.HeaderText = "地区";
            this.dgv_column_district.MinimumWidth = 6;
            this.dgv_column_district.Name = "dgv_column_district";
            this.dgv_column_district.ReadOnly = true;
            this.dgv_column_district.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_column_district.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgv_column_district.Width = 125;
            // 
            // dgv_column_fulladdress
            // 
            this.dgv_column_fulladdress.DataPropertyName = "fullAddress";
            this.dgv_column_fulladdress.HeaderText = "完整地址";
            this.dgv_column_fulladdress.MinimumWidth = 6;
            this.dgv_column_fulladdress.Name = "dgv_column_fulladdress";
            this.dgv_column_fulladdress.ReadOnly = true;
            this.dgv_column_fulladdress.Width = 125;
            // 
            // dgv_column_lat
            // 
            this.dgv_column_lat.DataPropertyName = "lat";
            this.dgv_column_lat.HeaderText = "维度";
            this.dgv_column_lat.MinimumWidth = 6;
            this.dgv_column_lat.Name = "dgv_column_lat";
            this.dgv_column_lat.ReadOnly = true;
            this.dgv_column_lat.Width = 125;
            // 
            // dgv_column_lng
            // 
            this.dgv_column_lng.DataPropertyName = "lng";
            this.dgv_column_lng.HeaderText = "经度";
            this.dgv_column_lng.MinimumWidth = 6;
            this.dgv_column_lng.Name = "dgv_column_lng";
            this.dgv_column_lng.ReadOnly = true;
            this.dgv_column_lng.Width = 125;
            // 
            // dgv_column_name
            // 
            this.dgv_column_name.DataPropertyName = "name";
            this.dgv_column_name.HeaderText = "名称";
            this.dgv_column_name.MinimumWidth = 6;
            this.dgv_column_name.Name = "dgv_column_name";
            this.dgv_column_name.ReadOnly = true;
            this.dgv_column_name.Width = 125;
            // 
            // dgv_column_tenantname
            // 
            this.dgv_column_tenantname.DataPropertyName = "tenantName";
            this.dgv_column_tenantname.HeaderText = "公司名称";
            this.dgv_column_tenantname.MinimumWidth = 6;
            this.dgv_column_tenantname.Name = "dgv_column_tenantname";
            this.dgv_column_tenantname.ReadOnly = true;
            this.dgv_column_tenantname.Width = 125;
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
            // UserPageShops
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.PageShop);
            this.Controls.Add(this.uiTitlePanel1);
            this.Name = "UserPageShops";
            this.Size = new System.Drawing.Size(818, 570);
            this.uiTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvShopList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPagination PageShop;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIDataGridView DgvShopList;
        private Sunny.UI.UISymbolButton BtnRefresh;
        private Sunny.UI.UISymbolButton BtnQuery;
        private Sunny.UI.UITextBox TbConditionValue;
        private Sunny.UI.UIComboBox CmbConditionKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_shop_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_province;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_city;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_district;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_fulladdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_lat;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_lng;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_tenantname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_createTime;
    }
}
