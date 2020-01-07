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

namespace Hastahane.FormUI.Pages.Procces
{
    public partial class ProccesAdd : UserControl
    {
        public ProccesAdd()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }
        Data.EntityFramework.Models.Procces updateProcces;
        ProccesDAL pdal = new ProccesDAL();

        public ProccesAdd(Data.EntityFramework.Models.Procces procces)
        {
            InitializeComponent();
            this.updateProcces = procces;
            btnUpdate.Visible = true;
            rdActive.Checked = true;
            txtName.Text = procces.ProccesName;
            rcTxtDescription.Text = procces.ProccesDescription;
            btnSave.Visible = false;
            if (procces.isActive!=true)
            {
                rdPasive.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.EntityFramework.Models.Procces procces = new Data.EntityFramework.Models.Procces();
            procces.ProccesName = txtName.Text;
            procces.ProccesDescription = rcTxtDescription.Text;
            if (rdActive.Checked==true)
            {
                procces.isActive = true;
            }
            else
            {
                procces.isActive = false;

            }
            var stat=pdal.Add(procces);
            if (stat==1)
            {
                MessageBox.Show("İşlem Kaydedildi","Succes");
            }
            else
            {
                MessageBox.Show("İşlem Başarısız","Failed");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProcces.ProccesName = txtName.Text;
            updateProcces.ProccesDescription = rcTxtDescription.Text;
            if (rdActive.Checked == true)
            {
                updateProcces.isActive = true;
            }
            else
            {
                updateProcces.isActive = false;

            }
            if (pdal.Update(updateProcces)==1)
            {
                MessageBox.Show("Güncelleme İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }
    }
}
