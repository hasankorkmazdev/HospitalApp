using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastahane.Data.EntityFramework.DataAccesLayer.Concrete;

namespace Hastahane.FormUI.Pages.Role
{
    public partial class RoleAdd : UserControl
    {
        public RoleAdd()
        {
            InitializeComponent();
            btnUpdate.Visible = false;

        }
        Data.EntityFramework.Models.Role modifyRole;
        RoleDAL roleDAL = new RoleDAL();

        public RoleAdd(Data.EntityFramework.Models.Role modifyRole)
        {
            InitializeComponent();
            this.modifyRole = modifyRole;
            btnSave.Visible = false;
            rdActive.Checked = true;
            btnUpdate.Visible = true;
            txtName.Text = modifyRole.RoleName;
            rcTxtDescription.Text = modifyRole.RoleDescription;
            if (modifyRole.isActive == false)
            {
                rdPasive.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.EntityFramework.Models.Role rl = new Data.EntityFramework.Models.Role();
            rl.RoleName = txtName.Text;
            rl.RoleDescription = rcTxtDescription.Text;
            if (rdActive.Checked == true)
            {
                rl.isActive = true;
            }
            else
            {
                rl.isActive = false;
            }
            if (roleDAL.Add(rl) == 1)
            {
                MessageBox.Show(rl.RoleName + " Kaydedildi", "Succes");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız", "Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            modifyRole.RoleName = txtName.Text;
            modifyRole.RoleDescription = rcTxtDescription.Text;
            if (rdActive.Checked == true)
            {
                modifyRole.isActive = true;
            }
            else
            {
                modifyRole.isActive = false;
            }
            if (roleDAL.Update(modifyRole) == 1)
            {
                MessageBox.Show(modifyRole.RoleName + " Kaydedildi", "Succes");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız", "Failed");
            }
        }
    }
}
