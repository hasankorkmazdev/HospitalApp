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
using Hastahane.FormUI.Forms;

namespace Hastahane.FormUI.Pages.Role
{
    public partial class RoleList : UserControl
    {
        RoleDAL roledal;
        int selectedRoleID = 0;
        public RoleList()
        {
            InitializeComponent();
            roledal = new RoleDAL();
            dgvList.DataSource = roledal.FindAll();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvList.DataSource=roledal.FindAll(x => x.RoleName.StartsWith(txtName.Text));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoleID!=0)
            {
               var stat= roledal.Delete(roledal.Find(x => x.RoleID == selectedRoleID));
                if (stat==1)
                {
                    MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi","Succes");
                }
            }
            else
            {
                MessageBox.Show("Listeden Seçim Yapılmamış","Failed");
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRoleID = (int)(dgvList.CurrentRow.Cells["RoleID"].Value);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (selectedRoleID != 0)
            {
                MainForm mainForm;
                mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Pages.Role.RoleAdd(roledal.Find(x => x.RoleID == selectedRoleID)));
               
            }
            else
            {
                MessageBox.Show("Listeden Seçim Yapılmadı","Failed");
            }
               

        }
    }
}
