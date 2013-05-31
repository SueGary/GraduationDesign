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
            this.tjdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tj_dbDataSet = new PEIS_SPZZ.tj_dbDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tJYHBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tJ_YHBTableAdapter = new PEIS_SPZZ.tj_dbDataSetTableAdapters.TJ_YHBTableAdapter();
            this.yHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHXMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tJKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSBMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yHQXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qXBMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tJYHBBindingSource)).BeginInit();
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
            // tjdbDataSetBindingSource
            // 
            this.tjdbDataSetBindingSource.DataSource = this.tj_dbDataSet;
            this.tjdbDataSetBindingSource.Position = 0;
            // 
            // tj_dbDataSet
            // 
            this.tj_dbDataSet.DataSetName = "tj_dbDataSet";
            this.tj_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(-4, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户字典";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(121, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "插入";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(492, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "查找";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(312, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "保存";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(402, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "刷新";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tJYHBBindingSource
            // 
            this.tJYHBBindingSource.DataMember = "TJ_YHB";
            this.tJYHBBindingSource.DataSource = this.tj_dbDataSet;
            // 
            // tJ_YHBTableAdapter
            // 
            this.tJ_YHBTableAdapter.ClearBeforeFill = true;
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
            // userDic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "userDic";
            this.Text = "userDic";
            this.Load += new System.EventHandler(this.userDic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tJYHBBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
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