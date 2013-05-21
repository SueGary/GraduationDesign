using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PEIS_SPZZ.UIL.Main;

namespace PEIS_SPZZ.UIL.login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            hosMain hosmain = new hosMain();
            hosmain.Owner = this;
            hosmain.ShowDialog();
            //Application.Run(new PEIS_SPZZ.UIL.Main.hosMain());
           // PEIS_SPZZ.UIL.Main.hosMain hosmain = new Main.hosMain();
          //  hosmain.ShowDialog();
          //  hosmain.Owner = this;
        }
    }
}
