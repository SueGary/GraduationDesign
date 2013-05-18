namespace PEIS_SPZZ.UIL.Reporter
{
    partial class reporter
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tj_dbDataSet = new PEIS_SPZZ.tj_dbDataSet();
            this.tjdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GRMZYDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRBJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRBJTableAdapter = new PEIS_SPZZ.tj_dbDataSetTableAdapters.GRBJTableAdapter();
            this.gRMZYDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gRMZYDTableAdapter = new PEIS_SPZZ.tj_dbDataSetTableAdapters.GRMZYDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRMZYDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRBJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRMZYDBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gRMZYDBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PEIS_SPZZ.UIL.Reporter.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(584, 400);
            this.reportViewer1.TabIndex = 0;
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
            // GRMZYDBindingSource
            // 
            this.GRMZYDBindingSource.DataMember = "GRMZYD";
            this.GRMZYDBindingSource.DataSource = this.tj_dbDataSet;
            // 
            // gRBJBindingSource
            // 
            this.gRBJBindingSource.DataMember = "GRBJ";
            this.gRBJBindingSource.DataSource = this.tjdbDataSetBindingSource;
            // 
            // gRBJTableAdapter
            // 
            this.gRBJTableAdapter.ClearBeforeFill = true;
            // 
            // gRMZYDBindingSource1
            // 
            this.gRMZYDBindingSource1.DataMember = "GRMZYD";
            this.gRMZYDBindingSource1.DataSource = this.tjdbDataSetBindingSource;
            // 
            // gRMZYDTableAdapter
            // 
            this.gRMZYDTableAdapter.ClearBeforeFill = true;
            // 
            // reporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 400);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporter";
            this.Text = "reporter";
            this.Load += new System.EventHandler(this.reporter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tj_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tjdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRMZYDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRBJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRMZYDBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GRMZYDBindingSource;
        private tj_dbDataSet tj_dbDataSet;
        private System.Windows.Forms.BindingSource tjdbDataSetBindingSource;
        private System.Windows.Forms.BindingSource gRBJBindingSource;
        private tj_dbDataSetTableAdapters.GRBJTableAdapter gRBJTableAdapter;
        private System.Windows.Forms.BindingSource gRMZYDBindingSource1;
        private tj_dbDataSetTableAdapters.GRMZYDTableAdapter gRMZYDTableAdapter;
    }
}