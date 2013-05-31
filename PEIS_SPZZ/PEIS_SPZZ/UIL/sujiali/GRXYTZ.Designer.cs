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
            this.SuspendLayout();
            // 
            // pageBar1
            // 
            this.pageBar1.BackColor = System.Drawing.Color.White;
            this.pageBar1.Location = new System.Drawing.Point(91, 35);
            this.pageBar1.MinimumSize = new System.Drawing.Size(350, 22);
            this.pageBar1.Name = "pageBar1";
            this.pageBar1.Size = new System.Drawing.Size(350, 22);
            this.pageBar1.TabIndex = 0;
            this.pageBar1.Load += new System.EventHandler(this.pageBar1_Load_1);
            // 
            // GRXYTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 408);
            this.Controls.Add(this.pageBar1);
            this.Name = "GRXYTZ";
            this.Text = "GRXYTZ";
            this.ResumeLayout(false);

        }

        #endregion

        private PageBar pageBar1;


        // private global::PageBar.PageBar pageBar1;
    }
}