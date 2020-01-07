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

namespace Hastahane.FormUI.Pages.Transaction
{
    public partial class TransactionAdd : UserControl
    {
        readonly TransactionDAL transactionDataAccesLayer;
        readonly ProccesDAL proccesDataAccesLayer;
        readonly StaffDAL staffDataAccesLayer;
        readonly PatientDocumentDAL patientDocumentDAL;

        Data.EntityFramework.Models.Transaction newTransaction;
        public TransactionAdd()
        {
            transactionDataAccesLayer = new TransactionDAL();
            proccesDataAccesLayer = new ProccesDAL();
            staffDataAccesLayer = new StaffDAL();
            patientDocumentDAL = new PatientDocumentDAL();

            InitializeComponent();
            cmbStaff.DataSource = staffDataAccesLayer.FindAll();
            cmbProcces.DataSource = proccesDataAccesLayer.FindAll();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (patientDocumentDAL.Find(x=>x.PatientDocumentID==txtDocumentID.Text)==null)
            {
                MessageBox.Show("Dosya Bulunamadı");
                return;
            }
            newTransaction = new Data.EntityFramework.Models.Transaction
            {
                PatientDocumentID = txtDocumentID.Text,
                Piece = (int)numericPiece.Value,
                Price = numPrice.Value,
                Procces = (Data.EntityFramework.Models.Procces)cmbProcces.SelectedItem,
                Staff = (Data.EntityFramework.Models.Staff)cmbStaff.SelectedItem,
                ProccesDate = DateTime.Now,
                //Todo : Düzenlenecek
                QueueNumber = 1
            };
            var stat=transactionDataAccesLayer.Add(newTransaction);
            if (stat==1)
            {
                MessageBox.Show("İşlem Tamamlandı","Succes");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız","Failed");
            }

        }
    }
}
