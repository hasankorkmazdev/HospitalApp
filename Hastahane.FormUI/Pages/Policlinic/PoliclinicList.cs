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

namespace Hastahane.FormUI.Pages.Policlinic
{
    public partial class PoliclinicList : UserControl
    {
        PoliclinicDAL policlinicDataAccesLayer;
        int selectedPoliclinicID=0;

        public PoliclinicList()
        {
            InitializeComponent();
            policlinicDataAccesLayer = new PoliclinicDAL();
            dgvList.DataSource = policlinicDataAccesLayer.FindAll();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dgvList.DataSource = policlinicDataAccesLayer.FindAll(x => x.PoliclinicName.StartsWith(txtName.Text));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedPoliclinicID != 0)
            {
                var stat = policlinicDataAccesLayer.Delete(policlinicDataAccesLayer.Find(x => x.PoliclinicID == selectedPoliclinicID));
                if (stat==1)
                {
                    MessageBox.Show("Silme işlemi başarıyla tamamlandı","Succes");
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız","Failed");
                }
            }
            else
            {
                MessageBox.Show("Liseden Seçim Yapılmadı","Failed");
            }
            selectedPoliclinicID = 0;
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedPoliclinicID =(int) dgvList.CurrentRow.Cells["PoliclinicID"].Value;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedPoliclinicID!=0)
            {
                MainForm mainForm = (MainForm)Program.MainPageReturn();
                mainForm.bodyPanel.Controls.Clear();
                mainForm.bodyPanel.Controls.Add(new Policlinic.PoliclinicAdd(policlinicDataAccesLayer.Find(x => x.PoliclinicID == selectedPoliclinicID)));

            }
            else
            {
                MessageBox.Show("Listeden seçim yapılmadı","Failed");
            }
        }
    }
}
