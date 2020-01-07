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

namespace Hastahane.FormUI.Pages.Patient
{
    public partial class PatientAdd : UserControl
    {
       readonly PatientDAL patientDAL;
        readonly PatientDocumentDAL documentDataAccesLayer;
        Data.EntityFramework.Models.PatientDocument newDocument;
        Data.EntityFramework.Models.Patient updatePatient;
        Data.EntityFramework.Models.Patient patient;
        public PatientAdd()
        {
            documentDataAccesLayer = new PatientDocumentDAL();
            patientDAL = new PatientDAL();
            InitializeComponent();
            cmbBloodTypes.DataSource = Enum.GetValues(typeof(Data.EntityFramework.Models.BloodTypes));
            btnUpdate.Visible = false;
        }
        public PatientAdd(Data.EntityFramework.Models.Patient updatePatient)
        {
            patientDAL = new PatientDAL();
            InitializeComponent();

            rdBekar.Checked = true;
            rdErkek.Checked = true;
            btnSave.Visible = false;
            cmbBloodTypes.DataSource = Enum.GetValues(typeof(Data.EntityFramework.Models.BloodTypes));

            this.updatePatient = updatePatient;
            txtName.Text = updatePatient.Name;
            txtSurname.Text = updatePatient.Surname;
            txtTC.Text = updatePatient.TCNumber;
            txtTel1.Text = updatePatient.Tel1;
            txtTel2.Text = updatePatient.Tel2;
            rcTxtAdress.Text = updatePatient.Adress;
            pickerBornDate.Value = updatePatient.BornDate;
            if (updatePatient.CivilStatus == Data.EntityFramework.Models.CivilStatus.Evli)
            {
                rdEvli.Checked = true;
            }
            if (updatePatient.Gender == Data.EntityFramework.Models.Gender.Kadın)
            {
                rdKadin.Checked = true;
            }
            cmbBloodTypes.SelectedItem = updatePatient.BloodType;
            btnUpdate.Visible = true;
            patientDAL = new PatientDAL();
        }
        private void PatientAdd_Load(object sender, EventArgs e)
        {
            cmbBloodTypes.DataSource = Enum.GetValues(typeof(Data.EntityFramework.Models.BloodTypes));
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtTel1.Text = "";
            txtTel2.Text = "";
            rcTxtAdress.Text = "";
            pickerBornDate.Value = DateTime.Now;
            rdBekar.Checked = true;
            rdEvli.Checked = false;
            rdErkek.Checked = true;
            rdKadin.Checked = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (documentDataAccesLayer.Find(x => x.PatientDocumentID == txtDocumentNumber.Text) != null)
            {
                MessageBox.Show("Bu numarada bi döküman numarası var.\n" +
                    "Yeni bir döküman numarası ekleyin", "Failed");
                return;
            }
            if (patientDAL.Find(x=>x.TCNumber==txtTC.Text)!=null)
            {
                MessageBox.Show("Bu hasta daha önce veritabanına kaydedilmiştir.\n" +
                    "Yeni bir dosya açmak istiyorsanız dosya işlemlerinden yeni bir dosya açın","Failed" );
                return;
            }


            patient = new Data.EntityFramework.Models.Patient();
            newDocument = new Data.EntityFramework.Models.PatientDocument();


            patient.Name = txtName.Text;
            patient.Surname = txtSurname.Text;
            patient.TCNumber = txtTC.Text;
            patient.Tel1 = txtTel1.Text;
            patient.Tel2 = txtTel2.Text;
            patient.Adress = rcTxtAdress.Text;
            patient.BornDate = pickerBornDate.Value;
            if (rdErkek.Checked == true)
            {
                patient.Gender = Data.EntityFramework.Models.Gender.Erkek;
            }
            else
            {
                patient.Gender = Data.EntityFramework.Models.Gender.Kadın;

            }
            if (rdEvli.Checked == true)
            {
                patient.CivilStatus = Data.EntityFramework.Models.CivilStatus.Evli;
            }
            else
            {
                patient.CivilStatus = Data.EntityFramework.Models.CivilStatus.Bekar;
            }
            patient.BloodType = (Data.EntityFramework.Models.BloodTypes)Enum.Parse(typeof(Data.EntityFramework.Models.BloodTypes), cmbBloodTypes.SelectedItem.ToString());
            var stat = patientDAL.Add(patient);
            if (stat == 1)
            {

                newDocument.PatientDocumentID = txtDocumentNumber.Text;
                newDocument.CreateDocumentDate = DateTime.Now;
                newDocument.Patient = patient;
                newDocument.TCNumber = patient.TCNumber;

                var stat2 = documentDataAccesLayer.Add(newDocument);
                if (stat2 == 1)
                {
                    MessageBox.Show("1-) " + patient.Name + " başarılı bir şekilde kaydedildi\n" +
                        "2-) Hasta dosyası oluşturuldu.", "Succes");
                }
                else
                {
                    MessageBox.Show("Hasta dosyası oluşturulamadı", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Hasta işlemi başarısız.", "Failed");
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePatient.Name = txtName.Text;
            updatePatient.Surname = txtSurname.Text;
            updatePatient.TCNumber = txtTC.Text;
            updatePatient.Tel1 = txtTel1.Text;
            updatePatient.Tel2 = txtTel2.Text;
            updatePatient.Adress = rcTxtAdress.Text;
            updatePatient.BornDate = pickerBornDate.Value;
            if (rdErkek.Checked == true)
            {
                updatePatient.Gender = Data.EntityFramework.Models.Gender.Erkek;
            }
            else
            {
                updatePatient.Gender = Data.EntityFramework.Models.Gender.Kadın;

            }
            if (rdEvli.Checked == true)
            {
                updatePatient.CivilStatus = Data.EntityFramework.Models.CivilStatus.Evli;
            }
            else
            {
                updatePatient.CivilStatus = Data.EntityFramework.Models.CivilStatus.Bekar;
            }
            updatePatient.BloodType = (Data.EntityFramework.Models.BloodTypes)Enum.Parse(typeof(Data.EntityFramework.Models.BloodTypes), cmbBloodTypes.SelectedItem.ToString());
            var stat = patientDAL.Update(updatePatient);
            if (stat == 1)
            {
                MessageBox.Show("Güncelleme işlemi başarılı", "Succes");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi hatası", "Failed");
            }
        }
    }
}
