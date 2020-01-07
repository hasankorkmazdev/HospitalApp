using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hastahane.FormUI.Forms;

namespace Hastahane.FormUI.Pages.Staff
{
    public partial class StaffList : UserControl
    {
        Data.EntityFramework.DataAccesLayer.Concrete.StaffDAL stafdal;
        Data.EntityFramework.DataAccesLayer.Concrete.PoliclinicDAL policlinicDAL;
        Data.EntityFramework.DataAccesLayer.Concrete.RoleDAL roleDAL;
        string selectedStaffCode;
        public StaffList()
        {
            InitializeComponent();
            stafdal = new Data.EntityFramework.DataAccesLayer.Concrete.StaffDAL();
            roleDAL = new Data.EntityFramework.DataAccesLayer.Concrete.RoleDAL();
            policlinicDAL = new Data.EntityFramework.DataAccesLayer.Concrete.PoliclinicDAL();
            dgvList.DataSource = stafdal.FindAll();
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void txtNameSurnameTrigger(object sender, EventArgs e)
        {
            dgvList.DataSource = stafdal.FindAll(x => x.Name.StartsWith(txtName.Text) && x.Surname.StartsWith(txtSurname.Text));

            dgvList.Columns["StaffCode"].Visible = false;
            dgvList.Columns["PoliclinicID"].Visible = false;
            dgvList.Columns["Username"].Visible = false;
            dgvList.Columns["Password"].Visible = false;
            dgvList.Columns["RoleID"].Visible = false;
            dgvList.Columns["Username"].Visible = false;
            dgvList.Columns["Name"].HeaderText = "İsim";
            dgvList.Columns["Surname"].HeaderText = "Soyisim";
            dgvList.Columns["Salary"].HeaderText = "Maaş";
            dgvList.Columns["Borndate"].HeaderText = "DoğumTarihi";
            dgvList.Columns["EntryDate"].HeaderText = "GirişTarihi";
            dgvList.Columns["isActive"].HeaderText = "Aktif mi?";
            dgvList.Columns["BloodType"].HeaderText = "KanGrubu";
            dgvList.Columns["Gender"].HeaderText = "Cinsiyet";
            dgvList.Columns["CivilStatus"].HeaderText = "Medeni Hal";
            dgvList.Columns["Role"].HeaderText = "Ünvan";
            dgvList.Columns["Policlinic"].HeaderText = "Poliklinik";

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedStaffCode))
            {
                Data.EntityFramework.Models.Staff deleteStaf;
                deleteStaf = stafdal.Find(x => x.StaffCode == selectedStaffCode);
                if (deleteStaf != null)
                {
                    int stat;
                    stat = stafdal.Delete(deleteStaf);
                    if (stat == 1)
                    {
                        MessageBox.Show("Silme işlemi Başarılı");
                    }
                }
                else
                {
                    MessageBox.Show("Kullanıcı Bulunamadı");
                }

            }
            else
            {
                MessageBox.Show("Listeden Seçim Yapılmadı");
            }
            selectedStaffCode = null;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedStaffCode))
            {
                MainForm mainForm;
                mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Pages.Staff.StaffAdd(stafdal.Find(x => x.StaffCode == selectedStaffCode)));

            }
            else
            {
                MessageBox.Show("Listeden Seçim Yapılmadı");
            }
            selectedStaffCode = null;

        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedStaffCode = dgvList.CurrentRow.Cells["StaffCode"].Value.ToString();

        }
    }
}
