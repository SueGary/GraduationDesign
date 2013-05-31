namespace PEIS_SPZZ.UIL.userDic
{
    partial class userDic
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHXMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tJKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSBMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHQXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qXBMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tJYHBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tj_dbDataSet = new PEIS_SPZZ.tj_dbDataSet();
            this.tjdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.insbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.delbtn = new System.Windows.Forms.Button();
            this.seabtn = new System.Windows.Forms.Button();
            this.savbtn = new System.Windows.Forms.Button();
            this.refbtn = new System.Windows.Forms.Button();
            this.tJ_YHBTableAdapter = new PEIS_SPZZ.tj_dbDataSetTableAdapters.TJ_YHBTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJYHBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yHIDDataGridViewTextBoxColumn,
            this.yHXMDataGridViewTextBoxColumn,
            this.yHMDataGridViewTextBoxColumn,
            this.mMDataGridViewTextBoxColumn,
            this.tJKSDataGridViewTextBoxColumn,
            this.kSBMDataGridViewTextBoxColumn,
            this.yHQXDataGridViewTextBoxColumn,
            this.qXBMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tJYHBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(596, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // yHIDDataGridViewTextBoxColumn
            // 
            this.yHIDDataGridViewTextBoxColumn.DataPropertyName = "YHID";
            this.yHIDDataGridViewTextBoxColumn.HeaderText = "YHID";
            this.yHIDDataGridViewTextBoxColumn.Name = "yHIDDataGridViewTextBoxColumn";
            this.yHIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yHXMDataGridViewTextBoxColumn
            // 
            this.yHXMDataGridViewTextBoxColumn.DataPropertyName = "YHXM";
            this.yHXMDataGridViewTextBoxColumn.HeaderText = "YHXM";
            this.yHXMDataGridViewTextBoxColumn.Name = "yHXMDataGridViewTextBoxColumn";
            this.yHXMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yHMDataGridViewTextBoxColumn
            // 
            this.yHMDataGridViewTextBoxColumn.DataPropertyName = "YHM";
            this.yHMDataGridViewTextBoxColumn.HeaderText = "YHM";
            this.yHMDataGridViewTextBoxColumn.Name = "yHMDataGridViewTextBoxColumn";
            this.yHMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mMDataGridViewTextBoxColumn
            // 
            this.mMDataGridViewTextBoxColumn.DataPropertyName = "MM";
            this.mMDataGridViewTextBoxColumn.HeaderText = "MM";
            this.mMDataGridViewTextBoxColumn.Name = "mMDataGridViewTextBoxColumn";
            this.mMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tJKSDataGridViewTextBoxColumn
            // 
            this.tJKSDataGridViewTextBoxColumn.DataPropertyName = "TJKS";
            this.tJKSDataGridViewTextBoxColumn.HeaderText = "TJKS";
            this.tJKSDataGridViewTextBoxColumn.Name = "tJKSDataGridViewTextBoxColumn";
            this.tJKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kSBMDataGridViewTextBoxColumn
            // 
            this.kSBMDataGridViewTextBoxColumn.DataPropertyName = "KSBM";
            this.kSBMDataGridViewTextBoxColumn.HeaderText = "KSBM";
            this.kSBMDataGridViewTextBoxColumn.Name = "kSBMDataGridViewTextBoxColumn";
            this.kSBMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yHQXDataGridViewTextBoxColumn
            // 
            this.yHQXDataGridViewTextBoxColumn.DataPropertyName = "YHQX";
            this.yHQXDataGridViewTextBoxColumn.HeaderText = "YHQX";
            this.yHQXDataGridViewTextBoxColumn.Name = "yHQXDataGridViewTextBoxColumn";
            this.yHQXDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qXBMDataGridViewTextBoxColumn
            // 
            this.qXBMDataGridViewTextBoxColumn.DataPropertyName = "QXBM";
            this.qXBMDataGridViewTextBoxColumn.HeaderText = "QXBM";
            this.qXBMDataGridViewTextBoxColumn.Name = "qXBMDataGridViewTextBoxColumn";
            this.qXBMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tJYHBBindingSource
            // 
            this.tJYHBBindingSource.DataMember = "TJ_YHB";
            this.tJYHBBindingSource.DataSource = this.tj_dbDataSet;
            // 
            // tj_dbDataSet
            // 
            this.tj_dbDataSet.DataSetName = "tj_dbDataSet";
            this.tj_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tjdbDataSetBindingSource
            // 
            this.tjdbDataSetBindingSource.DataSource = this.tj_dbDataSet;
            this.tjdbDataSetBindingSource.Position = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.insbtn);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.delbtn);
            this.groupBox1.Controls.Add(this.seabtn);
            this.groupBox1.Controls.Add(this.savbtn);
            this.groupBox1.Controls.Add(this.refbtn);
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // insbtn
            // 
            this.insbtn.Location = new System.Drawing.Point(121, 17);
            this.insbtn.Name = "insbtn";
            this.insbtn.Size = new System.Drawing.Size(75, 23);
            this.insbtn.TabIndex = 1;
            this.insbtn.Text = "插入";
            this.insbtn.UseVisualStyleBackColor = true;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(29, 17);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "添加";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // delbtn
            // 
            this.delbtn.Location = new System.Drawing.Point(218, 17);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(75, 23);
            this.delbtn.TabIndex = 2;
            this.delbtn.Text = "删除";
            this.delbtn.UseVisualStyleBackColor = true;
            // 
            // seabtn
            // 
            this.seabtn.Location = new System.Drawing.Point(492, 17);
            this.seabtn.Name = "seabtn";
            this.seabtn.Size = new System.Drawing.Size(75, 23);
            this.seabtn.TabIndex = 5;
            this.seabtn.Text = "查找";
            this.seabtn.UseVisualStyleBackColor = true;
            // 
            // savbtn
            // 
            this.savbtn.Location = new System.Drawing.Point(312, 17);
            this.savbtn.Name = "savbtn";
            this.savbtn.Size = new System.Drawing.Size(75, 23);
            this.savbtn.TabIndex = 3;
            this.savbtn.Text = "保存";
            this.savbtn.UseVisualStyleBackColor = true;
            // 
            // refbtn
            // 
            this.refbtn.Location = new System.Drawing.Point(402, 17);
            this.refbtn.Name = "refbtn";
            this.refbtn.Size = new System.Drawing.Size(75, 23);
            this.refbtn.TabIndex = 4;
            this.refbtn.Text = "刷新";
            this.refbtn.UseVisualStyleBackColor = true;
            // 
            // tJ_YHBTableAdapter
            // 
            this.tJ_YHBTableAdapter.ClearBeforeFill = true;
            // 
            // userDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userDic";
            this.Text = "用户字典";
            this.Load += new System.EventHandler(this.userDic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tJYHBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.Button savbtn;
        private System.Windows.Forms.Button refbtn;
        private System.Windows.Forms.Button seabtn;
        private System.Windows.Forms.BindingSource tjdbDataSetBindingSource;
        private tj_dbDataSet tj_dbDataSet;
        private System.Windows.Forms.BindingSource tJYHBBindingSource;
        private tj_dbDataSetTableAdapters.TJ_YHBTableAdapter tJ_YHBTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn yHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yHXMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yHMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tJKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSBMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yHQXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qXBMDataGridViewTextBoxColumn;
    }
}