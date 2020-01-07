using Hastahane.Core;
using Hastahane.Data.EntityFramework.DataAccesLayer.Concrete;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane.FormUI.Forms
{
    public partial class Login : Form
    {
        int health = 3;
        public Login()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Eğer Login OK ise ana formu yeniden görünür yap

            Core.Login loginControl = new Core.Login();
            if (loginControl.LoginValidation(txtLoginUsername.Text, txtLoginPassword.Text))
            {
                if (loginControl.LoginControl(txtLoginUsername.Text, txtLoginPassword.Text))
                {
                    Program.ShowMainForm(loginControl.LoginCompleted(txtLoginUsername.Text.ToUpper()));
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifreniz hatalı yeniden deneyiniz!", "Failed");
                    health--;
                }
            }
            else
            {
                health--;
                MessageBox.Show("Giriş değerlerinde hata yaptınız." +
                    "\n 1 - Kullanıcı adınızı doğru girdiğinizi doğrulayın." +
                    "\n 2 - Şifrenizi doğru girdiğinizi doğrulayın." +
                    "\n 3 - Şifreniz 8 karakterden küçük olamaz.", "Kontrol Hatası", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (health == 0)
            {
                Application.Exit();
            }

        }


    }
}
