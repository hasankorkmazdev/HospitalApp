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

namespace Hastahane.FormUI.Pages.Procces
{
    public partial class ProccesList : UserControl
    {
        ProccesDAL proccesDAL = new ProccesDAL();
        int selectedProccesID=0;
        public ProccesList()
        {
            InitializeComponent();
            dgvList.DataSource = proccesDAL.FindAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = proccesDAL.FindAll(x => x.ProccesName.StartsWith(txtName.Text));
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedProccesID=(int)dgvList.CurrentRow.Cells["ProccesID"].Value;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedProccesID!=0)
            {
                MainForm mainForm;
                mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Pages.Procces.ProccesAdd(proccesDAL.Find(x => x.ProccesID == selectedProccesID)));
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProccesID!=0)
            {
                int stat;
                stat=proccesDAL.Delete(proccesDAL.Find(x => x.ProccesID == selectedProccesID));
                if (stat==1)
                {
                    MessageBox.Show("Silme İşlemi Başarılı","Succes");
                }
            }
            else
            {
                MessageBox.Show("Seçim Yapılmadı");
            }
        }
    }
}
