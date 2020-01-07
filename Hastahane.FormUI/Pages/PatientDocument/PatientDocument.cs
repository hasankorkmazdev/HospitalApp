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

namespace Hastahane.FormUI.Pages.PatientDocument
{
    public partial class PatientDocument : UserControl
    {
        readonly PatientDocumentDAL patientDocumentDataAccesLayer;
        Data.EntityFramework.Models.PatientDocument newPatientDocumentRecord;

        public PatientDocument()
        {
            InitializeComponent();
            patientDocumentDataAccesLayer = new PatientDocumentDAL();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            newPatientDocumentRecord = new Data.EntityFramework.Models.PatientDocument
            {
                PatientDocumentID = txtDocumentID.Text,
                CreateDocumentDate = DateTime.Now,
                TCNumber = txtTC.Text,
                
            };
            var stat = patientDocumentDataAccesLayer.Add(newPatientDocumentRecord);
            if (stat == 1)
            {
                MessageBox.Show(newPatientDocumentRecord.PatientDocumentID + " Nolu döküman oluşturuldu", "Succes");
            }
            else
            {
                MessageBox.Show("Döküman Oluşturulamadı", "Failed");
            }

        }
    }
}
