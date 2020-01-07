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

namespace Hastahane.FormUI.Pages.Patient
{
    public partial class PatientList : UserControl
    {
        readonly PatientDAL patientDataAccesLayer;
        string selectedPatientTC;
        public PatientList()
        {
            patientDataAccesLayer = new PatientDAL();
            InitializeComponent();
            dgvList.DataSource = patientDataAccesLayer.FindAll();
        }
      
        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPatientTC = dgvList.CurrentRow.Cells["TCNumber"].Value.ToString();
        }

        private void txtParametersChanged(object sender, EventArgs e)
        {
            dgvList.DataSource= patientDataAccesLayer.FindAll(x => x.Name.StartsWith(txtName.Text) && x.Surname.StartsWith(txtSurname.Text) && x.TCNumber.StartsWith(txtTCNumber.Text));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedPatientTC))
            {
                MainForm mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Patient.PatientAdd(patientDataAccesLayer.Find(x => x.TCNumber == selectedPatientTC)));
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı","Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedPatientTC))
            {

                var stat=patientDataAccesLayer.Delete(patientDataAccesLayer.Find(x => x.TCNumber == selectedPatientTC));
                if (stat==1)
                {
                    MessageBox.Show("Silme işlemi başarılı bir şekilde gerçekleştirildi.","Succes");
                }
                else
                {
                    MessageBox.Show("Veritabanı Hatası","Failed");
                }

            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı", "Failed");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

        }
    }
}
