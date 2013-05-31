namespace PEIS_SPZZ.UIL.sujiali
{
    partial class GRXYTZ
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
            this.xytzdgv = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new PEIS_SPZZ.UIL.sujiali.DataGridViewActionButtonColumn();
            this.dataGridViewActionButtonColumn1 = new PEIS_SPZZ.UIL.sujiali.DataGridViewActionButtonColumn();
            this.pageBar1 = new PEIS_SPZZ.UIL.sujiali.PageBar();
            ((System.ComponentModel.ISupportInitialize)(this.xytzdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // xytzdgv
            // 
            this.xytzdgv.BackgroundColor = System.Drawing.Color.White;
            this.xytzdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xytzdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column2});
            this.xytzdgv.Location = new System.Drawing.Point(59, 58);
            this.xytzdgv.Name = "xytzdgv";
            this.xytzdgv.RowTemplate.Height = 23;
            this.xytzdgv.Size = new System.Drawing.Size(643, 290);
            this.xytzdgv.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // dataGridViewActionButtonColumn1
            // 
            this.dataGridViewActionButtonColumn1.HeaderText = "Column2";
            this.dataGridViewActionButtonColumn1.Name = "dataGridViewActionButtonColumn1";
            // 
            // pageBar1
            // 
            this.pageBar1.BackColor = System.Drawing.Color.White;
            this.pageBar1.CurPage = 1;
            this.pageBar1.DataControl = null;
            this.pageBar1.DataSource = null;
            this.pageBar1.Location = new System.Drawing.Point(12, 12);
            this.pageBar1.MinimumSize = new System.Drawing.Size(350, 22);
            this.pageBar1.Name = "pageBar1";
            this.pageBar1.PageSize = 15;
            this.pageBar1.Size = new System.Drawing.Size(350, 22);
            this.pageBar1.TabIndex = 0;
            this.pageBar1.Load += new System.EventHandler(this.pageBar1_Load_1);
            // 
            // GRXYTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 408);
            this.Controls.Add(this.xytzdgv);
            this.Controls.Add(this.pageBar1);
            this.Name = "GRXYTZ";
            this.Text = "GRXYTZ";
            ((System.ComponentModel.ISupportInitialize)(this.xytzdgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PageBar pageBar1;
        private System.Windows.Forms.DataGridView xytzdgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DataGridViewActionButtonColumn Column2;
        private DataGridViewActionButtonColumn dataGridViewActionButtonColumn1;


        // private global::PageBar.PageBar pageBar1;
    }
}