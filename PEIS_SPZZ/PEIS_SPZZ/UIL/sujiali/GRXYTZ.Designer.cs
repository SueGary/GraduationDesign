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
            this.pageBar1 = new PEIS_SPZZ.UIL.sujiali.PageBar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.action = new PEIS_SPZZ.UIL.UserControls.DataGridViewActionButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.action});
            this.dataGridView1.Location = new System.Drawing.Point(12, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(350, 251);
            this.dataGridView1.TabIndex = 1;
            // 
            // action
            // 
            this.action.HeaderText = "操作";
            this.action.Name = "action";
            // 
            // GRXYTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 303);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pageBar1);
            this.Name = "GRXYTZ";
            this.Text = "GRXYTZ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PageBar pageBar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UserControls.DataGridViewActionButtonColumn action;

      



        // private global::PageBar.PageBar pageBar1;
    }
}