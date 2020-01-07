using Hastahane.Data.EntityFramework.DataAccesLayer.Concrete;
using Hastahane.Data.EntityFramework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastahane.FormUI.Forms
{
    public partial class MainForm : Form
    {
        bool isLogin = false;
        bool staffCollapsed = true;
        bool proccesCollapsed = true;
        bool roleCollapsed = true;
        bool policlinicCollapsed = true;
        bool patientCollapsed = true;
        public MainForm()
        {
            //Ana sayfa buradan çağrılırsa kullanıcı login olmamıştır.
            InitializeComponent();
            isLogin = true;
        }
        public MainForm(Data.EntityFramework.Models.Staff Staff)
        {
            //Ana sayfa buradan çağrılırsa kullanıcı login olmuştur.
            InitializeComponent();
            lblUserName.Text = Staff.Name + " " + Staff.Surname;
            lblRole.Text = Staff.Role.RoleName.ToString();
            pictureforStaff.Image = ApplicationData.HospitalRosurces.random_profile;
        }



        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr ptr, int wmsg, int wparam, int lparam);
        //Login olunup olunmadığı kontrol
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (isLogin == true)
            {
                LoadingSecreen ls = new LoadingSecreen();
                this.Hide();
                ls.Show();
            }
        }
        private void ExitButtons(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pnlTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Staff.StaffAdd());
        }
        private void btnPoliclinicAdd_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Policlinic.PoliclinicAdd());
        }
        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Role.RoleAdd());
        }
        private void btnProccesAdd_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Procces.ProccesAdd());
        }
        private void btnPatientAdd_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Patient.PatientAdd());
        }

        private void btnRoleDetail_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Role.RoleList());
        }
        private void btnProccesDetail_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Procces.ProccesList());
        }
        private void btnPoliclinicDetail_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Policlinic.PoliclinicList());
        }
        private void btnStaffDetail_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Staff.StaffList());
        }

        #region Menu Button Triggers
        private void dropDownTriggerForPocces_Tick(object sender, EventArgs e)
        {
            if (proccesCollapsed)
            {
                pnlProccesButtonGroup.Height += 10;
                if (pnlProccesButtonGroup.Size == pnlProccesButtonGroup.MaximumSize)
                {
                    dropDownTriggerForPocces.Stop();
                    proccesCollapsed = false;
                }

            }
            else
            {
                pnlProccesButtonGroup.Height -= 10;
                if (pnlProccesButtonGroup.Size == pnlProccesButtonGroup.MinimumSize)
                {
                    dropDownTriggerForPocces.Stop();
                    proccesCollapsed = true;
                }
            }
        }
        private void dropDownTriggerForStaff_Tick(object sender, EventArgs e)
        {
            if (staffCollapsed)
            {
                pnlStaffButtonGroup.Height += 10;
                if (pnlStaffButtonGroup.Size == pnlStaffButtonGroup.MaximumSize)
                {
                    dropDownTriggerForStaff.Stop();
                    staffCollapsed = false;
                }
            }
            else
            {
                pnlStaffButtonGroup.Height -= 10;
                if (pnlStaffButtonGroup.Size == pnlStaffButtonGroup.MinimumSize)
                {
                    dropDownTriggerForStaff.Stop();
                    staffCollapsed = true;
                }
            }
        }
        private void dropDownTriggerForRole_Tick(object sender, EventArgs e)
        {
            if (roleCollapsed)
            {
                pnlRoleButtonGroup.Height += 10;
                if (pnlRoleButtonGroup.Size == pnlRoleButtonGroup.MaximumSize)
                {
                    dropDownTriggerForRole.Stop();
                    roleCollapsed = false;
                }
            }
            else
            {
                pnlRoleButtonGroup.Height -= 10;
                if (pnlRoleButtonGroup.Size == pnlRoleButtonGroup.MinimumSize)
                {
                    dropDownTriggerForRole.Stop();
                    roleCollapsed = true;
                }
            }
        }
        private void dropDownTriggerForPoliclinic_Tick(object sender, EventArgs e)
        {
            if (policlinicCollapsed)
            {
                pnlPoliclinicButtonGroup.Height += 10;
                if (pnlPoliclinicButtonGroup.Size == pnlPoliclinicButtonGroup.MaximumSize)
                {
                    dropDownTriggerForPoliclinic.Stop();
                    policlinicCollapsed = false;
                }
            }
            else
            {
                pnlPoliclinicButtonGroup.Height -= 10;
                if (pnlPoliclinicButtonGroup.Size == pnlPoliclinicButtonGroup.MinimumSize)
                {
                    dropDownTriggerForPoliclinic.Stop();
                    policlinicCollapsed = true;
                }
            }
        }
        private void dropDownTriggerForPatient_Tick(object sender, EventArgs e)
        {
            if (patientCollapsed)
            {
                pnlPatientButtonGroup.Height += 10;
                if (pnlPatientButtonGroup.Size == pnlPatientButtonGroup.MaximumSize)
                {
                    dropDownTriggerForPatient.Stop();
                    patientCollapsed = false;
                }
            }
            else
            {
                pnlPatientButtonGroup.Height -= 10;
                if (pnlPatientButtonGroup.Size == pnlPatientButtonGroup.MinimumSize)
                {
                    dropDownTriggerForPatient.Stop();
                    patientCollapsed = true;
                }
            }
        }
        #endregion

        #region Menu Button Groups DropDowns
        private void btnProcces_Click(object sender, EventArgs e)
        {
            dropDownTriggerForPocces.Start();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            dropDownTriggerForStaff.Start();
        }
        private void btnRole_Click(object sender, EventArgs e)
        {
            dropDownTriggerForRole.Start();
        }
        private void btnPoliclinic_Click(object sender, EventArgs e)
        {
            dropDownTriggerForPoliclinic.Start();
        }
        private void btnPatient_Click(object sender, EventArgs e)
        {
            dropDownTriggerForPatient.Start();
        }




        #endregion

        private void btnPatientProcces_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.Transaction.TransactionAdd());
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.PatientDocument.PatientDocument());
        }

        private void btnDocumentClose_Click(object sender, EventArgs e)
        {
            bodyPanel.Controls.Clear();
            bodyPanel.Controls.Add(new Pages.PatientDocument.PatientDocumentClose());
        }
    }
}
