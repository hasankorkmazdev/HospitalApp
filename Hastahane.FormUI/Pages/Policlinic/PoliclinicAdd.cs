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

namespace Hastahane.FormUI.Pages.Policlinic
{
    public partial class PoliclinicAdd : UserControl
    {
        Data.EntityFramework.Models.Policlinic updatePoliclinic;
        PoliclinicDAL pdal = new PoliclinicDAL();

        public PoliclinicAdd()
        {
            InitializeComponent();
            btnUpdate.Visible = false;
        }
        public PoliclinicAdd(Data.EntityFramework.Models.Policlinic updatePoliclinic)
        {
            InitializeComponent();
            rdActive.Checked = true;
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            this.updatePoliclinic = updatePoliclinic;
            txtName.Text = updatePoliclinic.PoliclinicName;
            rcTxtDescription.Text = updatePoliclinic.PoliclinicDetails;
            if (updatePoliclinic.isActive==false)
            {
                rdPasive.Checked = true;
                rdActive.Checked = false;
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Data.EntityFramework.Models.Policlinic pl = new Data.EntityFramework.Models.Policlinic();
            PoliclinicDAL pdal = new PoliclinicDAL();

            pl.PoliclinicName = txtName.Text;
            pl.PoliclinicDetails = rcTxtDescription.Text;
            if (rdActive.Checked == true)
            {
                pl.isActive = true;

            }
            else
            {
                pl.isActive = false;
            }
            if (pdal.Add(pl) == 1)
            {
                MessageBox.Show(pl.PoliclinicName + " Kaydedildi", "Succes");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız", "Failed");
            }


        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            updatePoliclinic.PoliclinicName = txtName.Text;
            updatePoliclinic.PoliclinicDetails = rcTxtDescription.Text;
            if (rdActive.Checked == true)
            {
                updatePoliclinic.isActive = true;
            }
            else
            {
                updatePoliclinic.isActive = false;
            }
            var stat = pdal.Update(updatePoliclinic);
            if (stat==1)
            {
                MessageBox.Show(updatePoliclinic.PoliclinicName + " Güncellendi", "Succes");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız", "Failed");
            }
        }
    }
}
