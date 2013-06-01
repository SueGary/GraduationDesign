namespace PEIS_SPZZ.UIL.sujiali
{
    partial class Default
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
            this.grxytzdgv = new System.Windows.Forms.DataGridView();
            this.ssy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actioncol = new PEIS_SPZZ.UIL.UserControls.DataGridViewActionButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewActionButtonColumn1 = new PEIS_SPZZ.UIL.UserControls.DataGridViewActionButtonColumn();
            this.grxytzpb = new PEIS_SPZZ.UIL.sujiali.PageBar();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grxytzdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grxytzdgv
            // 
            this.grxytzdgv.BackgroundColor = System.Drawing.Color.White;
            this.grxytzdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grxytzdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ssy,
            this.szy,
            this.tz,
            this.xl,
            this.rq,
            this.actioncol});
            this.grxytzdgv.Location = new System.Drawing.Point(91, 91);
            this.grxytzdgv.Name = "grxytzdgv";
            this.grxytzdgv.RowTemplate.Height = 23;
            this.grxytzdgv.Size = new System.Drawing.Size(651, 372);
            this.grxytzdgv.TabIndex = 2;
            this.grxytzdgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grxytzdgv_CellMouseClick);
            // 
            // ssy
            // 
            this.ssy.DataPropertyName = "Ssy";
            this.ssy.HeaderText = "收缩压";
            this.ssy.Name = "ssy";
            // 
            // szy
            // 
            this.szy.DataPropertyName = "Szy";
            this.szy.HeaderText = "舒张压";
            this.szy.Name = "szy";
            // 
            // tz
            // 
            this.tz.DataPropertyName = "Tz";
            this.tz.HeaderText = "体重";
            this.tz.Name = "tz";
            // 
            // xl
            // 
            this.xl.DataPropertyName = "Xl";
            this.xl.HeaderText = "心率";
            this.xl.Name = "xl";
            // 
            // rq
            // 
            this.rq.DataPropertyName = "Rqsj";
            this.rq.HeaderText = "日期";
            this.rq.Name = "rq";
            // 
            // actioncol
            // 
            this.actioncol.DataPropertyName = "Id";
            this.actioncol.HeaderText = "操作";
            this.actioncol.Name = "actioncol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(401, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "提示：单击页面下方的“添加”按钮，添加新的个人身体状况信息。";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewActionButtonColumn1
            // 
            this.dataGridViewActionButtonColumn1.DataPropertyName = "Id";
            this.dataGridViewActionButtonColumn1.HeaderText = "操作";
            this.dataGridViewActionButtonColumn1.Name = "dataGridViewActionButtonColumn1";
            // 
            // grxytzpb
            // 
            this.grxytzpb.BackColor = System.Drawing.Color.White;
            this.grxytzpb.CurPage = 1;
            this.grxytzpb.DataControl = null;
            this.grxytzpb.DataSource = null;
            this.grxytzpb.Location = new System.Drawing.Point(385, 63);
            this.grxytzpb.MinimumSize = new System.Drawing.Size(350, 22);
            this.grxytzpb.Name = "grxytzpb";
            this.grxytzpb.PageSize = 15;
            this.grxytzpb.Size = new System.Drawing.Size(350, 22);
            this.grxytzpb.TabIndex = 1;
            this.grxytzpb.PageChanged += new System.EventHandler(this.grxytzpb_PageChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox4.Image = global::PEIS_SPZZ.Properties.Resources.background;
            this.pictureBox4.Location = new System.Drawing.Point(0, 466);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(827, 48);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PEIS_SPZZ.Properties.Resources.SJL_line;
            this.pictureBox3.Location = new System.Drawing.Point(102, 50);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(350, 2);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PEIS_SPZZ.Properties.Resources.grstzk_info;
            this.pictureBox2.Location = new System.Drawing.Point(102, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::PEIS_SPZZ.Properties.Resources.LogoMain;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(667, 479);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "添加";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // Default
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 514);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.grxytzdgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grxytzpb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Default";
            this.Text = "Default";
            ((System.ComponentModel.ISupportInitialize)(this.grxytzdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private PageBar grxytzpb;
        private System.Windows.Forms.DataGridView grxytzdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssy;
        private System.Windows.Forms.DataGridViewTextBoxColumn szy;
        private System.Windows.Forms.DataGridViewTextBoxColumn tz;
        private System.Windows.Forms.DataGridViewTextBoxColumn xl;
        private System.Windows.Forms.DataGridViewTextBoxColumn rq;
        private UserControls.DataGridViewActionButtonColumn actioncol;
        private System.Windows.Forms.Label label1;
        private UserControls.DataGridViewActionButtonColumn dataGridViewActionButtonColumn1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button addbtn;
    }
}