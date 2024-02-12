namespace hygge_imaotai.UI.Main.Page
{
    partial class UserPageAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiPagination1 = new Sunny.UI.UIPagination();
            this.uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            this.DgvTaskList = new Sunny.UI.UIDataGridView();
            this.dgv_column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_school = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_ip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_course_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_column_cookie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnQuery = new Sunny.UI.UISymbolButton();
            this.TbConditionValue = new Sunny.UI.UITextBox();
            this.CmbConditionKey = new Sunny.UI.UIComboBox();
            this.BtnRefresh = new Sunny.UI.UISymbolButton();
            this.BtnSort = new Sunny.UI.UISymbolButton();
            this.uiTitlePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).BeginInit();
            this.SuspendLayout();
            // 
            // uiPagination1
            // 
            this.uiPagination1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPagination1.Location = new System.Drawing.Point(4, 535);
            this.uiPagination1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPagination1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPagination1.Name = "uiPagination1";
            this.uiPagination1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPagination1.ShowText = false;
            this.uiPagination1.Size = new System.Drawing.Size(814, 35);
            this.uiPagination1.TabIndex = 7;
            this.uiPagination1.Text = "uiPagination1";
            this.uiPagination1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTitlePanel1
            // 
            this.uiTitlePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiTitlePanel1.Controls.Add(this.DgvTaskList);
            this.uiTitlePanel1.Controls.Add(this.BtnQuery);
            this.uiTitlePanel1.Controls.Add(this.TbConditionValue);
            this.uiTitlePanel1.Controls.Add(this.CmbConditionKey);
            this.uiTitlePanel1.Controls.Add(this.BtnRefresh);
            this.uiTitlePanel1.Controls.Add(this.BtnSort);
            this.uiTitlePanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTitlePanel1.Location = new System.Drawing.Point(0, 5);
            this.uiTitlePanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTitlePanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTitlePanel1.Name = "uiTitlePanel1";
            this.uiTitlePanel1.ShowText = false;
            this.uiTitlePanel1.Size = new System.Drawing.Size(814, 474);
            this.uiTitlePanel1.TabIndex = 8;
            this.uiTitlePanel1.Text = "预约账户列表";
            this.uiTitlePanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DgvTaskList
            // 
            this.DgvTaskList.AllowUserToAddRows = false;
            this.DgvTaskList.AllowUserToDeleteRows = false;
            this.DgvTaskList.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvTaskList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvTaskList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvTaskList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.DgvTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvTaskList.ColumnHeadersHeight = 32;
            this.DgvTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_column_id,
            this.dgv_column_source,
            this.dgv_column_platform,
            this.dgv_column_school,
            this.dgv_column_account,
            this.dgv_column_password,
            this.dgv_column_course,
            this.dgv_column_status,
            this.dgv_column_progress,
            this.dgv_column_detail,
            this.dgv_column_remark,
            this.dgv_column_ip,
            this.dgv_column_time,
            this.dgv_column_token,
            this.dgv_column_course_id,
            this.dgv_column_cookie});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvTaskList.DefaultCellStyle = dataGridViewCellStyle8;
            this.DgvTaskList.EnableHeadersVisualStyles = false;
            this.DgvTaskList.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DgvTaskList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.DgvTaskList.Location = new System.Drawing.Point(6, 80);
            this.DgvTaskList.Name = "DgvTaskList";
            this.DgvTaskList.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvTaskList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DgvTaskList.RowHeadersWidth = 51;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DgvTaskList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DgvTaskList.RowTemplate.Height = 27;
            this.DgvTaskList.ScrollBarStyleInherited = false;
            this.DgvTaskList.SelectedIndex = -1;
            this.DgvTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvTaskList.Size = new System.Drawing.Size(808, 442);
            this.DgvTaskList.TabIndex = 5;
            // 
            // dgv_column_id
            // 
            this.dgv_column_id.DataPropertyName = "Id";
            this.dgv_column_id.HeaderText = "ID";
            this.dgv_column_id.MinimumWidth = 6;
            this.dgv_column_id.Name = "dgv_column_id";
            this.dgv_column_id.ReadOnly = true;
            this.dgv_column_id.Width = 50;
            // 
            // dgv_column_source
            // 
            this.dgv_column_source.DataPropertyName = "Source";
            this.dgv_column_source.HeaderText = "来源";
            this.dgv_column_source.MinimumWidth = 6;
            this.dgv_column_source.Name = "dgv_column_source";
            this.dgv_column_source.ReadOnly = true;
            this.dgv_column_source.Width = 125;
            // 
            // dgv_column_platform
            // 
            this.dgv_column_platform.DataPropertyName = "Platform";
            this.dgv_column_platform.HeaderText = "平台";
            this.dgv_column_platform.MinimumWidth = 6;
            this.dgv_column_platform.Name = "dgv_column_platform";
            this.dgv_column_platform.ReadOnly = true;
            this.dgv_column_platform.Width = 160;
            // 
            // dgv_column_school
            // 
            this.dgv_column_school.DataPropertyName = "School";
            this.dgv_column_school.HeaderText = "学校";
            this.dgv_column_school.MinimumWidth = 6;
            this.dgv_column_school.Name = "dgv_column_school";
            this.dgv_column_school.ReadOnly = true;
            this.dgv_column_school.Width = 125;
            // 
            // dgv_column_account
            // 
            this.dgv_column_account.DataPropertyName = "Account";
            this.dgv_column_account.HeaderText = "账号";
            this.dgv_column_account.MinimumWidth = 6;
            this.dgv_column_account.Name = "dgv_column_account";
            this.dgv_column_account.ReadOnly = true;
            this.dgv_column_account.Width = 125;
            // 
            // dgv_column_password
            // 
            this.dgv_column_password.DataPropertyName = "Password";
            this.dgv_column_password.HeaderText = "密码";
            this.dgv_column_password.MinimumWidth = 6;
            this.dgv_column_password.Name = "dgv_column_password";
            this.dgv_column_password.ReadOnly = true;
            this.dgv_column_password.Width = 125;
            // 
            // dgv_column_course
            // 
            this.dgv_column_course.DataPropertyName = "Course";
            this.dgv_column_course.HeaderText = "课程名称";
            this.dgv_column_course.MinimumWidth = 6;
            this.dgv_column_course.Name = "dgv_column_course";
            this.dgv_column_course.ReadOnly = true;
            this.dgv_column_course.Width = 125;
            // 
            // dgv_column_status
            // 
            this.dgv_column_status.DataPropertyName = "Status";
            this.dgv_column_status.HeaderText = "状态";
            this.dgv_column_status.MinimumWidth = 6;
            this.dgv_column_status.Name = "dgv_column_status";
            this.dgv_column_status.ReadOnly = true;
            this.dgv_column_status.Width = 70;
            // 
            // dgv_column_progress
            // 
            this.dgv_column_progress.DataPropertyName = "Progress";
            this.dgv_column_progress.HeaderText = "进度";
            this.dgv_column_progress.MinimumWidth = 6;
            this.dgv_column_progress.Name = "dgv_column_progress";
            this.dgv_column_progress.ReadOnly = true;
            this.dgv_column_progress.Width = 55;
            // 
            // dgv_column_detail
            // 
            this.dgv_column_detail.DataPropertyName = "Detail";
            this.dgv_column_detail.HeaderText = "详细";
            this.dgv_column_detail.MinimumWidth = 6;
            this.dgv_column_detail.Name = "dgv_column_detail";
            this.dgv_column_detail.ReadOnly = true;
            this.dgv_column_detail.Width = 140;
            // 
            // dgv_column_remark
            // 
            this.dgv_column_remark.DataPropertyName = "Remark";
            this.dgv_column_remark.HeaderText = "备注";
            this.dgv_column_remark.MinimumWidth = 6;
            this.dgv_column_remark.Name = "dgv_column_remark";
            this.dgv_column_remark.ReadOnly = true;
            this.dgv_column_remark.Width = 350;
            // 
            // dgv_column_ip
            // 
            this.dgv_column_ip.DataPropertyName = "IP";
            this.dgv_column_ip.HeaderText = "IP";
            this.dgv_column_ip.MinimumWidth = 6;
            this.dgv_column_ip.Name = "dgv_column_ip";
            this.dgv_column_ip.ReadOnly = true;
            this.dgv_column_ip.Width = 350;
            // 
            // dgv_column_time
            // 
            this.dgv_column_time.DataPropertyName = "CreateTime";
            this.dgv_column_time.HeaderText = "时间";
            this.dgv_column_time.MinimumWidth = 6;
            this.dgv_column_time.Name = "dgv_column_time";
            this.dgv_column_time.ReadOnly = true;
            this.dgv_column_time.Width = 200;
            // 
            // dgv_column_token
            // 
            this.dgv_column_token.DataPropertyName = "Token";
            this.dgv_column_token.HeaderText = "token";
            this.dgv_column_token.MinimumWidth = 6;
            this.dgv_column_token.Name = "dgv_column_token";
            this.dgv_column_token.ReadOnly = true;
            this.dgv_column_token.Width = 300;
            // 
            // dgv_column_course_id
            // 
            this.dgv_column_course_id.DataPropertyName = "CourseId";
            this.dgv_column_course_id.HeaderText = "课程ID";
            this.dgv_column_course_id.MinimumWidth = 6;
            this.dgv_column_course_id.Name = "dgv_column_course_id";
            this.dgv_column_course_id.ReadOnly = true;
            this.dgv_column_course_id.Width = 125;
            // 
            // dgv_column_cookie
            // 
            this.dgv_column_cookie.DataPropertyName = "Cookie";
            this.dgv_column_cookie.HeaderText = "Cookie";
            this.dgv_column_cookie.MinimumWidth = 6;
            this.dgv_column_cookie.Name = "dgv_column_cookie";
            this.dgv_column_cookie.ReadOnly = true;
            this.dgv_column_cookie.Width = 125;
            // 
            // BtnQuery
            // 
            this.BtnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnQuery.Location = new System.Drawing.Point(711, 41);
            this.BtnQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnQuery.Name = "BtnQuery";
            this.BtnQuery.Size = new System.Drawing.Size(100, 35);
            this.BtnQuery.TabIndex = 4;
            this.BtnQuery.Text = "查询";
            this.BtnQuery.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // TbConditionValue
            // 
            this.TbConditionValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbConditionValue.ButtonSymbolOffset = new System.Drawing.Point(0, 0);
            this.TbConditionValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbConditionValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TbConditionValue.Location = new System.Drawing.Point(553, 45);
            this.TbConditionValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TbConditionValue.MinimumSize = new System.Drawing.Size(1, 16);
            this.TbConditionValue.Name = "TbConditionValue";
            this.TbConditionValue.Padding = new System.Windows.Forms.Padding(5);
            this.TbConditionValue.ShowText = false;
            this.TbConditionValue.Size = new System.Drawing.Size(150, 29);
            this.TbConditionValue.TabIndex = 3;
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
            this.CmbConditionKey.Items.AddRange(new object[] {
            "全部",
            "id",
            "来源",
            "平台",
            "学校",
            "账号",
            "密码",
            "课程名称",
            "状态",
            "进度",
            "详细",
            "备注",
            "ip",
            "时间",
            "token",
            "课程id",
            "cookies"});
            this.CmbConditionKey.Location = new System.Drawing.Point(430, 45);
            this.CmbConditionKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CmbConditionKey.MinimumSize = new System.Drawing.Size(63, 0);
            this.CmbConditionKey.Name = "CmbConditionKey";
            this.CmbConditionKey.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.CmbConditionKey.Size = new System.Drawing.Size(115, 29);
            this.CmbConditionKey.TabIndex = 2;
            this.CmbConditionKey.Text = "全部";
            this.CmbConditionKey.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.CmbConditionKey.Watermark = "";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnRefresh.Location = new System.Drawing.Point(113, 39);
            this.BtnRefresh.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(104, 35);
            this.BtnRefresh.TabIndex = 1;
            this.BtnRefresh.Text = "刷新";
            this.BtnRefresh.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // BtnSort
            // 
            this.BtnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnSort.Location = new System.Drawing.Point(3, 39);
            this.BtnSort.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(104, 35);
            this.BtnSort.TabIndex = 0;
            this.BtnSort.Text = "升序";
            this.BtnSort.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // UserPageAccounts
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uiTitlePanel1);
            this.Controls.Add(this.uiPagination1);
            this.Name = "UserPageAccounts";
            this.Size = new System.Drawing.Size(818, 570);
            this.uiTitlePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTaskList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPagination uiPagination1;
        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UIDataGridView DgvTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_source;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_school;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_account;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_course;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_ip;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_token;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_course_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_column_cookie;
        private Sunny.UI.UISymbolButton BtnQuery;
        private Sunny.UI.UITextBox TbConditionValue;
        private Sunny.UI.UIComboBox CmbConditionKey;
        private Sunny.UI.UISymbolButton BtnRefresh;
        private Sunny.UI.UISymbolButton BtnSort;
    }
}
