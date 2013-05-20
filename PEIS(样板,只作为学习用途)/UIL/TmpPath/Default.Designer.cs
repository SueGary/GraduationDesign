namespace SUJIALI.PEIS.UIL.TmpPath
{
    partial class Default
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTip = new System.Windows.Forms.Label();
            this.PageBar = new SUJIALI.PEIS.UIL.UserControls.PageBar();
            this.PicTitleLine = new System.Windows.Forms.PictureBox();
            this.PnlMainArea = new System.Windows.Forms.Panel();
            this.PnlDgvBack = new System.Windows.Forms.Panel();
            this.DgvGrid = new System.Windows.Forms.DataGridView();
            this.ColReservationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhysicalExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNameOfRubyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNationa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAction = new SUJIALI.PEIS.UIL.DataGridViewActionButtonColumn();
            this.PnlTopTitle = new System.Windows.Forms.Panel();
            this.PicTitle = new System.Windows.Forms.PictureBox();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.PnlFooter = new System.Windows.Forms.Panel();
            this.BtnCreate = new SUJIALI.PEIS.UIL.UserControls.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).BeginInit();
            this.PnlMainArea.SuspendLayout();
            this.PnlDgvBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).BeginInit();
            this.PnlTopTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.PnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTip
            // 
            this.LblTip.Location = new System.Drawing.Point(85, 50);
            this.LblTip.Name = "LblTip";
            this.LblTip.Size = new System.Drawing.Size(350, 22);
            this.LblTip.TabIndex = 9;
            this.LblTip.Text = "提示：单击页面下方的“添加”按钮，添加新的个人信息。";
            this.LblTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageBar
            // 
            this.PageBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageBar.BackColor = System.Drawing.Color.White;
            this.PageBar.CurPage = 1;
            this.PageBar.DataControl = null;
            this.PageBar.DataSource = null;
            this.PageBar.Location = new System.Drawing.Point(438, 50);
            this.PageBar.MinimumSize = new System.Drawing.Size(350, 22);
            this.PageBar.Name = "PageBar";
            this.PageBar.PageSize = 15;
            this.PageBar.Size = new System.Drawing.Size(350, 22);
            this.PageBar.TabIndex = 8;
            this.PageBar.PageChanged += new System.EventHandler(this.PageBar_PageChanged);
            this.PageBar.Load += new System.EventHandler(this.PageBar_Load);
            // 
            // PicTitleLine
            // 
            this.PicTitleLine.Image = global::SUJIALI.PEIS.Properties.Resources.TitleLine;
            this.PicTitleLine.Location = new System.Drawing.Point(85, 40);
            this.PicTitleLine.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitleLine.Name = "PicTitleLine";
            this.PicTitleLine.Size = new System.Drawing.Size(350, 5);
            this.PicTitleLine.TabIndex = 7;
            this.PicTitleLine.TabStop = false;
            // 
            // PnlMainArea
            // 
            this.PnlMainArea.Controls.Add(this.PnlDgvBack);
            this.PnlMainArea.Controls.Add(this.PnlTopTitle);
            this.PnlMainArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMainArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PnlMainArea.Location = new System.Drawing.Point(0, 0);
            this.PnlMainArea.Name = "PnlMainArea";
            this.PnlMainArea.Padding = new System.Windows.Forms.Padding(20);
            this.PnlMainArea.Size = new System.Drawing.Size(830, 550);
            this.PnlMainArea.TabIndex = 4;
            // 
            // PnlDgvBack
            // 
            this.PnlDgvBack.Controls.Add(this.DgvGrid);
            this.PnlDgvBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDgvBack.Location = new System.Drawing.Point(20, 100);
            this.PnlDgvBack.Name = "PnlDgvBack";
            this.PnlDgvBack.Size = new System.Drawing.Size(790, 430);
            this.PnlDgvBack.TabIndex = 7;
            // 
            // DgvGrid
            // 
            this.DgvGrid.AllowUserToAddRows = false;
            this.DgvGrid.AllowUserToDeleteRows = false;
            this.DgvGrid.AllowUserToOrderColumns = true;
            this.DgvGrid.AllowUserToResizeRows = false;
            this.DgvGrid.BackgroundColor = System.Drawing.Color.White;
            this.DgvGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvGrid.ColumnHeadersHeight = 30;
            this.DgvGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColReservationId,
            this.ColPhysicalExamination,
            this.ColName,
            this.ColNameOfRubyCode,
            this.ColSex,
            this.ColDateOfBirth,
            this.ColIDCard,
            this.ColNationa,
            this.ColAction});
            this.DgvGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvGrid.GridColor = System.Drawing.Color.Silver;
            this.DgvGrid.Location = new System.Drawing.Point(0, 0);
            this.DgvGrid.MultiSelect = false;
            this.DgvGrid.Name = "DgvGrid";
            this.DgvGrid.ReadOnly = true;
            this.DgvGrid.RowHeadersVisible = false;
            this.DgvGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DgvGrid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.DgvGrid.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvGrid.RowTemplate.Height = 30;
            this.DgvGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvGrid.Size = new System.Drawing.Size(790, 430);
            this.DgvGrid.TabIndex = 0;
            this.DgvGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvGrid_CellMouseClick);
            // 
            // ColReservationId
            // 
            this.ColReservationId.DataPropertyName = "ReservationId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColReservationId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColReservationId.HeaderText = "预约号";
            this.ColReservationId.Name = "ColReservationId";
            this.ColReservationId.ReadOnly = true;
            this.ColReservationId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColPhysicalExamination
            // 
            this.ColPhysicalExamination.DataPropertyName = "PhysicalExamination";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColPhysicalExamination.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColPhysicalExamination.HeaderText = "体检号";
            this.ColPhysicalExamination.Name = "ColPhysicalExamination";
            this.ColPhysicalExamination.ReadOnly = true;
            this.ColPhysicalExamination.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColName
            // 
            this.ColName.DataPropertyName = "Name";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColName.HeaderText = "姓名";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            this.ColName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColName.Width = 80;
            // 
            // ColNameOfRubyCode
            // 
            this.ColNameOfRubyCode.DataPropertyName = "NameOfRubyCode";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNameOfRubyCode.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColNameOfRubyCode.HeaderText = "姓名拼音码";
            this.ColNameOfRubyCode.Name = "ColNameOfRubyCode";
            this.ColNameOfRubyCode.ReadOnly = true;
            this.ColNameOfRubyCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNameOfRubyCode.Width = 80;
            // 
            // ColSex
            // 
            this.ColSex.DataPropertyName = "Sex";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSex.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColSex.HeaderText = "性别";
            this.ColSex.Name = "ColSex";
            this.ColSex.ReadOnly = true;
            this.ColSex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSex.Width = 50;
            // 
            // ColDateOfBirth
            // 
            this.ColDateOfBirth.DataPropertyName = "DateOfBirth";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColDateOfBirth.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColDateOfBirth.HeaderText = "出生日期";
            this.ColDateOfBirth.Name = "ColDateOfBirth";
            this.ColDateOfBirth.ReadOnly = true;
            this.ColDateOfBirth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColIDCard
            // 
            this.ColIDCard.DataPropertyName = "IDCard";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColIDCard.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColIDCard.HeaderText = "身份证";
            this.ColIDCard.Name = "ColIDCard";
            this.ColIDCard.ReadOnly = true;
            this.ColIDCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColNationa
            // 
            this.ColNationa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNationa.DataPropertyName = "Nationa";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ColNationa.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColNationa.HeaderText = "民族";
            this.ColNationa.MinimumWidth = 60;
            this.ColNationa.Name = "ColNationa";
            this.ColNationa.ReadOnly = true;
            this.ColNationa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAction
            // 
            this.ColAction.DataPropertyName = "SerialId";
            this.ColAction.HeaderText = "操作";
            this.ColAction.Name = "ColAction";
            this.ColAction.ReadOnly = true;
            this.ColAction.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColAction.Width = 120;
            // 
            // PnlTopTitle
            // 
            this.PnlTopTitle.Controls.Add(this.PicTitleLine);
            this.PnlTopTitle.Controls.Add(this.PicTitle);
            this.PnlTopTitle.Controls.Add(this.PicLogo);
            this.PnlTopTitle.Controls.Add(this.LblTip);
            this.PnlTopTitle.Controls.Add(this.PageBar);
            this.PnlTopTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopTitle.Location = new System.Drawing.Point(20, 20);
            this.PnlTopTitle.Name = "PnlTopTitle";
            this.PnlTopTitle.Size = new System.Drawing.Size(790, 80);
            this.PnlTopTitle.TabIndex = 6;
            // 
            // PicTitle
            // 
            this.PicTitle.Image = global::SUJIALI.PEIS.Properties.Resources.TitleTmpPathList;
            this.PicTitle.Location = new System.Drawing.Point(85, 0);
            this.PicTitle.Margin = new System.Windows.Forms.Padding(0);
            this.PicTitle.Name = "PicTitle";
            this.PicTitle.Size = new System.Drawing.Size(350, 40);
            this.PicTitle.TabIndex = 6;
            this.PicTitle.TabStop = false;
            // 
            // PicLogo
            // 
            this.PicLogo.Image = global::SUJIALI.PEIS.Properties.Resources.LogoTmpPath;
            this.PicLogo.Location = new System.Drawing.Point(0, 0);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(20, 20, 10, 20);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(75, 75);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 5;
            this.PicLogo.TabStop = false;
            // 
            // PnlFooter
            // 
            this.PnlFooter.BackgroundImage = global::SUJIALI.PEIS.Properties.Resources.FooterBG;
            this.PnlFooter.Controls.Add(this.BtnCreate);
            this.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFooter.Location = new System.Drawing.Point(0, 550);
            this.PnlFooter.Name = "PnlFooter";
            this.PnlFooter.Size = new System.Drawing.Size(830, 50);
            this.PnlFooter.TabIndex = 3;
            // 
            // BtnCreate
            // 
            this.BtnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(163)))), ((int)(((byte)(193)))));
            this.BtnCreate.Location = new System.Drawing.Point(730, 12);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Padding = new System.Windows.Forms.Padding(1);
            this.BtnCreate.Size = new System.Drawing.Size(82, 26);
            this.BtnCreate.TabIndex = 0;
            this.BtnCreate.Text = "添加";
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PnlMainArea);
            this.Controls.Add(this.PnlFooter);
            this.Name = "Default";
            this.Size = new System.Drawing.Size(830, 600);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitleLine)).EndInit();
            this.PnlMainArea.ResumeLayout(false);
            this.PnlDgvBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvGrid)).EndInit();
            this.PnlTopTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.PnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicTitleLine;
        private System.Windows.Forms.Panel PnlMainArea;
        private System.Windows.Forms.Panel PnlDgvBack;
        private System.Windows.Forms.Panel PnlTopTitle;
        private System.Windows.Forms.PictureBox PicTitle;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.Panel PnlFooter;
        private SUJIALI.PEIS.UIL.UserControls.Button BtnCreate;
        private SUJIALI.PEIS.UIL.UserControls.PageBar PageBar;
        private System.Windows.Forms.Label LblTip;
        private System.Windows.Forms.DataGridView DgvGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColReservationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhysicalExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNameOfRubyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNationa;
        private DataGridViewActionButtonColumn ColAction;
    }
}
