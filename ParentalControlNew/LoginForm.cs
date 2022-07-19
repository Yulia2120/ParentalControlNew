using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using System.Windows.Forms;

namespace ParentalControlNew
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void kryptonBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool IsValid()
        {
             if(txtBoxUser.Text.TrimStart() == String.Empty)
                {
                    MessageBox.Show("Enter valid user name please!", "Error");
                    return false;
                }
             else if(txtBoxPass.Text.TrimStart() == String.Empty)
                {
                    MessageBox.Show("Enter valid password please!", "Error");
                    return false;
                }
             if(txtBoxUser.Text.ToLower() == "admin" && txtBoxPass.Text == "1111")
                {
                  Form1 s = new Form1();
                  s.ShowDialog();
                  this.Close();
                }
            else
            {
                MessageBox.Show("Enter valid user name or password please!", "Error");
            }
             return true;
        }
        private void kryptonBtnLogin_Click(object sender, EventArgs e)
        {
            IsValid();
        }
    }
}
