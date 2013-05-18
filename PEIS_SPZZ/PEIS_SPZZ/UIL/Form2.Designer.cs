namespace PEIS_SPZZ.UIL
{
    partial class Form2
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
            this.ID = new System.Windows.Forms.TextBox();
            this.GRID = new System.Windows.Forms.TextBox();
            this.SJ = new System.Windows.Forms.TextBox();
            this.JHYD = new System.Windows.Forms.TextBox();
            this.lsqk = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(69, 13);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 21);
            this.ID.TabIndex = 0;
            // 
            // GRID
            // 
            this.GRID.Location = new System.Drawing.Point(69, 62);
            this.GRID.Name = "GRID";
            this.GRID.Size = new System.Drawing.Size(100, 21);
            this.GRID.TabIndex = 0;
            // 
            // SJ
            // 
            this.SJ.Location = new System.Drawing.Point(82, 140);
            this.SJ.Name = "SJ";
            this.SJ.Size = new System.Drawing.Size(100, 21);
            this.SJ.TabIndex = 0;
            // 
            // JHYD
            // 
            this.JHYD.Location = new System.Drawing.Point(69, 167);
            this.JHYD.Name = "JHYD";
            this.JHYD.Size = new System.Drawing.Size(100, 21);
            this.JHYD.TabIndex = 0;
            // 
            // lsqk
            // 
            this.lsqk.Location = new System.Drawing.Point(69, 216);
            this.lsqk.Name = "lsqk";
            this.lsqk.Size = new System.Drawing.Size(100, 21);
            this.lsqk.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "GRID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "SJ:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "LSQK:";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(82, 111);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 21);
            this.datetime.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.datetime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lsqk);
            this.Controls.Add(this.JHYD);
            this.Controls.Add(this.SJ);
            this.Controls.Add(this.GRID);
            this.Controls.Add(this.ID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox GRID;
        private System.Windows.Forms.TextBox SJ;
        private System.Windows.Forms.TextBox JHYD;
        private System.Windows.Forms.TextBox lsqk;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetime;
    }
}