using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane.FormUI.Pages.Staff
{
    public partial class StaffAdd : UserControl
    {
        Data.EntityFramework.Models.Staff updateStaffLast;
        Data.EntityFramework.Models.Staff newStaff;

        readonly Data.EntityFramework.DataAccesLayer.Concrete.StaffDAL staffDAL = new Data.EntityFramework.DataAccesLayer.Concrete.StaffDAL();
        readonly Data.EntityFramework.DataAccesLayer.Concrete.RoleDAL roleDAL = new Data.EntityFramework.DataAccesLayer.Concrete.RoleDAL();
        readonly Data.EntityFramework.DataAccesLayer.Concrete.PoliclinicDAL policlinicDAL = new Data.EntityFramework.DataAccesLayer.Concrete.PoliclinicDAL();


        public StaffAdd()
        {
            InitializeComponent();
            btnUpdate.Visible = false ;
            cmbPoliclinic.DataSource = policlinicDAL.FindAll();
            cmbRole.DataSource = roleDAL.FindAll();
            cmbBloodTypes.DataSource = Enum.GetValues(typeof(Data.EntityFramework.Models.BloodTypes));

        }
        public StaffAdd(Data.EntityFramework.Models.Staff staff)
        {
            InitializeComponent();
            this.updateStaffLast = staff;
            rdBekar.Checked = true;
            rdErkek.Checked = true;
            btnUpdate.Visible = true;
            cmbPoliclinic.DataSource = policlinicDAL.FindAll();
            cmbRole.DataSource = roleDAL.FindAll();
            cmbBloodTypes.DataSource = Enum.GetValues(typeof(Data.EntityFramework.Models.BloodTypes));
            if (updateStaffLast != null)
            {
                txtName.Text = updateStaffLast.Name;
                txtSurname.Text = updateStaffLast.Surname;
                txtTel1.Text = updateStaffLast.Tel1;
                txtTel2.Text = updateStaffLast.Tel2;
                pickerBornDate.Value = updateStaffLast.BornDate;
                pickerEntryDate.Value = updateStaffLast.EntryDate;
                numericSalary.Value = updateStaffLast.Salary;
                rcTxtAdress.Text = updateStaffLast.Adress;
                txtUsername.Text = updateStaffLast.Username.ToUpper();
                txtPassword.Text = updateStaffLast.Password;
                cmbBloodTypes.SelectedItem = updateStaffLast.BloodType;
                if (updateStaffLast.CivilStatus==Data.EntityFramework.Models.CivilStatus.Evli)
                {
                    rdEvli.Checked = true;
                }
                if (updateStaffLast.Gender==Data.EntityFramework.Models.Gender.Kadın)
                {
                    rdKadin.Checked = true;
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            newStaff = new Data.EntityFramework.Models.Staff();
            if (staffDAL.FindAll(x=>x.Username==txtUsername.Text).Any())
            {
                MessageBox.Show("Kullanıcı Adı Zaten Kullanılıyor.\nBaşka bir kullanıcı adı seçin.","Veri Çakışması");
                return;
            }
            else
            {
                newStaff.StaffCode = Guid.NewGuid().ToString();
                newStaff.Name = txtName.Text;
                newStaff.Surname = txtSurname.Text;
                newStaff.Tel1 = txtTel1.Text;
                newStaff.Tel2 = txtTel2.Text;
                newStaff.Adress = rcTxtAdress.Text;
                newStaff.BornDate = pickerBornDate.Value;
                newStaff.EntryDate = pickerEntryDate.Value;
                newStaff.Salary = numericSalary.Value;
                if (rdBekar.Checked == true)
                {
                    newStaff.CivilStatus = Data.EntityFramework.Models.CivilStatus.Bekar;
                }
                else
                {
                    newStaff.CivilStatus = Data.EntityFramework.Models.CivilStatus.Evli;
                }
                if (rdErkek.Checked == true)
                {
                    newStaff.Gender = Data.EntityFramework.Models.Gender.Erkek;
                }
                else
                {
                    newStaff.Gender = Data.EntityFramework.Models.Gender.Kadın;
                }
                newStaff.Role = (Hastahane.Data.EntityFramework.Models.Role)cmbRole.SelectedItem;
                newStaff.BloodType = (Data.EntityFramework.Models.BloodTypes)Enum.Parse(typeof(Data.EntityFramework.Models.BloodTypes), cmbBloodTypes.SelectedItem.ToString());
                newStaff.Role = (Hastahane.Data.EntityFramework.Models.Role)cmbRole.SelectedItem;
                newStaff.Policlinic = (Data.EntityFramework.Models.Policlinic)cmbPoliclinic.SelectedItem;
                newStaff.Username = txtUsername.Text;
                newStaff.Password = txtPassword.Text;
                var stat=staffDAL.Add(newStaff);
                if (stat==1)
                {
                    MessageBox.Show(newStaff.Name +" isimli personel oluşturuldu.","Succes");
                }
                else
                {
                    MessageBox.Show("İşlem Hatası","Failed");
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            rcTxtAdress.Text = "";
            rdBekar.Checked = true;
            rdEvli.Checked = false;
            rdErkek.Checked = true;
            rdKadin.Checked = false;
            numericSalary.Value = 0;
            pickerBornDate.Value = DateTime.Now;
            pickerEntryDate.Value = DateTime.Now;
            cmbRole.SelectedIndex = 0;
            cmbPoliclinic.SelectedIndex = 0;
            cmbBloodTypes.SelectedIndex = 0;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (staffDAL.FindAll(x => x.Username == txtUsername.Text).Any())
            {
                MessageBox.Show("Kullanıcı Adı Zaten Kullanılıyor.\nBaşka bir kullanıcı adı seçin.", "Veri Çakışması");
                return;
            }
            else
            {
                updateStaffLast.Username = txtUsername.Text.ToUpper();
                updateStaffLast.Password = txtPassword.Text;
                updateStaffLast.Username = txtUsername.Text;
                updateStaffLast.Name = txtName.Text;
                updateStaffLast.Surname = txtSurname.Text;
                updateStaffLast.Tel1 = txtTel1.Text;
                updateStaffLast.Tel2 = txtTel2.Text;
                updateStaffLast.Adress = rcTxtAdress.Text;
                updateStaffLast.BornDate = pickerBornDate.Value;
                updateStaffLast.EntryDate = pickerEntryDate.Value;
                updateStaffLast.Salary = numericSalary.Value;
                if (rdBekar.Checked == true)
                {
                    updateStaffLast.CivilStatus = Data.EntityFramework.Models.CivilStatus.Bekar;
                }
                else
                {
                    updateStaffLast.CivilStatus = Data.EntityFramework.Models.CivilStatus.Evli;
                }
                if (rdErkek.Checked == true)
                {
                    updateStaffLast.Gender = Data.EntityFramework.Models.Gender.Erkek;
                }
                else
                {
                    updateStaffLast.Gender = Data.EntityFramework.Models.Gender.Kadın;
                }
                updateStaffLast.Role = (Hastahane.Data.EntityFramework.Models.Role)cmbRole.SelectedItem;
                updateStaffLast.BloodType = (Data.EntityFramework.Models.BloodTypes)Enum.Parse(typeof(Data.EntityFramework.Models.BloodTypes), cmbBloodTypes.SelectedItem.ToString());
                updateStaffLast.Role = (Hastahane.Data.EntityFramework.Models.Role)cmbRole.SelectedItem;
                updateStaffLast.Policlinic = (Data.EntityFramework.Models.Policlinic)cmbPoliclinic.SelectedItem;

                int stat;
                stat=staffDAL.Update(updateStaffLast);
                if (stat==1)
                {
                    MessageBox.Show("Güncelleme Başarılı");

                }

            }
        }
    }
}
