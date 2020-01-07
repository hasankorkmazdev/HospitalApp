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
    public partial class PatientDocumentDetails : UserControl
    {
        public PatientDocumentDetails()
        {
            InitializeComponent();
        }
        TransactionDAL data = new TransactionDAL();
        PatientDocumentDAL patientDocumentDAL = new PatientDocumentDAL();
        string patientDocumentNumber;
        public PatientDocumentDetails(string patientDocumentNumber)
        {
            TransactionDAL transactionDAL = new TransactionDAL();
            this.patientDocumentNumber = patientDocumentNumber;
            decimal toplam=0;
            InitializeComponent();
            dgvList.Columns.Add("DocumentID", "Döküman Numarası");
            dgvList.Columns.Add("NameSurname", "İsim Soyisim");
            dgvList.Columns.Add("Procces", "İşlem Adı");
            dgvList.Columns.Add("Piece", "Miktar");
            dgvList.Columns.Add("UnitPrice", "Birim Fiyat");
            dgvList.Columns.Add("ProccesDate", "İşlem Tarih");
            dgvList.Columns.Add("Doctor", "Doktor");
            foreach (var item in transactionDAL.FindAll(x => x.PatientDocumentID == patientDocumentNumber))
            {
                dgvList.Rows.Add(
                    item.PatientDocumentID,
                    item.PatientDocument.Patient.Name + item.PatientDocument.Patient.Surname,
                    item.Procces.ProccesName,
                    item.Piece,
                    item.Price,
                    item.ProccesDate,
                    item.Staff.Name + " " + item.Staff.Surname
                    );
                toplam += item.Piece * item.Price;
            }

            label1.Text = "Toplam Tutar :"+toplam+" TL";
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Core.PDFCreator pDFCreator = new Core.PDFCreator();
            pDFCreator.WritePDF(patientDocumentNumber, Application.StartupPath + "\\" + patientDocumentNumber);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Data.EntityFramework.Models.PatientDocument pd = patientDocumentDAL.Find(x => x.PatientDocumentID == this.patientDocumentNumber);
            pd.CloseDocumentDate = DateTime.Now;
            patientDocumentDAL.Update(pd);
        }
    }
}
