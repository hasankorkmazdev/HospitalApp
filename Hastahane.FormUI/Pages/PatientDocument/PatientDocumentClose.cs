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
using Hastahane.Data.EntityFramework.Models;
using Hastahane.FormUI.Forms;

namespace Hastahane.FormUI.Pages.PatientDocument
{
    public partial class PatientDocumentClose : UserControl
    {
        PatientDocumentDAL patientDocumentDAL = new PatientDocumentDAL();
        public PatientDocumentClose()
        {
            InitializeComponent();
            dgvList.Columns.Add("DocumentNumber", "Döküman Numarası");
            dgvList.Columns.Add("TCNumber", "TC Kimlik");
            dgvList.Columns.Add("NameSurname", "İsim Soyisim");
            dgvList.Columns.Add("CreateDate", "Dosya Tarihi");
            dgvList.Columns.Add("CloseDate", "Kapama Tarihi");
            foreach (var item in patientDocumentDAL.FindAll(x => x.PatientDocumentID.StartsWith(txtDocumentID.Text)))
            {
                dgvList.Rows.Add(item.PatientDocumentID, item.TCNumber,item.Patient.Name+" "+item.Patient.Surname ,item.CreateDocumentDate, item.CloseDocumentDate);
            }
    
        }
        string selectedDocumentID;

        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in patientDocumentDAL.FindAll(x => x.PatientDocumentID.StartsWith(txtDocumentID.Text)))
            {
                dgvList.Rows.Add(item.PatientDocumentID, item.TCNumber, item.Patient.Name + " " + item.Patient.Surname, item.CreateDocumentDate, item.CloseDocumentDate);
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDocumentID= dgvList.CurrentRow.Cells["DocumentNumber"].Value.ToString();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(selectedDocumentID))
            {
                MainForm mainForm;
                mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Pages.PatientDocument.PatientDocumentDetails(selectedDocumentID));
            }
        }
    }
}
