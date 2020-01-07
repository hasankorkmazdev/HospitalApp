using System;
using System.Windows.Forms;

namespace Hastahane.FormUI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.FormTitleLogo = new System.Windows.Forms.PictureBox();
            this.lblFormText = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPatientButtonGroup = new System.Windows.Forms.Panel();
            this.btnDocumentClose = new System.Windows.Forms.Button();
            this.btnPatientProcces = new System.Windows.Forms.Button();
            this.btnPatientDetail = new System.Windows.Forms.Button();
            this.btnPatientAdd = new System.Windows.Forms.Button();
            this.btnPatient = new System.Windows.Forms.Button();
            this.pnlStaffButtonGroup = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnStaffDetail = new System.Windows.Forms.Button();
            this.pnlProccesButtonGroup = new System.Windows.Forms.Panel();
            this.btnProccesDetail = new System.Windows.Forms.Button();
            this.btnProcces = new System.Windows.Forms.Button();
            this.btnProccesAdd = new System.Windows.Forms.Button();
            this.pnlRoleButtonGroup = new System.Windows.Forms.Panel();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.btnRoleDetail = new System.Windows.Forms.Button();
            this.pnlPoliclinicButtonGroup = new System.Windows.Forms.Panel();
            this.btnPoliclinicDetail = new System.Windows.Forms.Button();
            this.btnPoliclinicAdd = new System.Windows.Forms.Button();
            this.btnPoliclinic = new System.Windows.Forms.Button();
            this.pnlLeftMainLogoContainer = new System.Windows.Forms.Panel();
            this.pnlLeftTitle = new System.Windows.Forms.Label();
            this.MenuLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pictureforStaff = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.dropDownTriggerForStaff = new System.Windows.Forms.Timer(this.components);
            this.dropDownTriggerForPocces = new System.Windows.Forms.Timer(this.components);
            this.dropDownTriggerForRole = new System.Windows.Forms.Timer(this.components);
            this.dropDownTriggerForPoliclinic = new System.Windows.Forms.Timer(this.components);
            this.dropDownTriggerForPatient = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormTitleLogo)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlPatientButtonGroup.SuspendLayout();
            this.pnlStaffButtonGroup.SuspendLayout();
            this.pnlProccesButtonGroup.SuspendLayout();
            this.pnlRoleButtonGroup.SuspendLayout();
            this.pnlPoliclinicButtonGroup.SuspendLayout();
            this.pnlLeftMainLogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogo)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureforStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Controls.Add(this.FormTitleLogo);
            this.pnlTopBar.Controls.Add(this.lblFormText);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(1185, 41);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackgroundImage = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Delete_32px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1145, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.ExitButtons);
            // 
            // FormTitleLogo
            // 
            this.FormTitleLogo.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.tesla_logo_PNG19;
            this.FormTitleLogo.Location = new System.Drawing.Point(3, 3);
            this.FormTitleLogo.Name = "FormTitleLogo";
            this.FormTitleLogo.Size = new System.Drawing.Size(40, 35);
            this.FormTitleLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FormTitleLogo.TabIndex = 1;
            this.FormTitleLogo.TabStop = false;
            // 
            // lblFormText
            // 
            this.lblFormText.AutoSize = true;
            this.lblFormText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFormText.ForeColor = System.Drawing.Color.White;
            this.lblFormText.Location = new System.Drawing.Point(44, 10);
            this.lblFormText.Name = "lblFormText";
            this.lblFormText.Size = new System.Drawing.Size(91, 21);
            this.lblFormText.TabIndex = 0;
            this.lblFormText.Text = "Ana Sayfa";
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.pnlLeftMenu);
            this.pnlLeft.Controls.Add(this.pnlLeftMainLogoContainer);
            this.pnlLeft.Controls.Add(this.pnlBottom);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 41);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(227, 599);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.AutoScroll = true;
            this.pnlLeftMenu.Controls.Add(this.pnlPatientButtonGroup);
            this.pnlLeftMenu.Controls.Add(this.pnlStaffButtonGroup);
            this.pnlLeftMenu.Controls.Add(this.pnlProccesButtonGroup);
            this.pnlLeftMenu.Controls.Add(this.pnlRoleButtonGroup);
            this.pnlLeftMenu.Controls.Add(this.pnlPoliclinicButtonGroup);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 82);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(225, 396);
            this.pnlLeftMenu.TabIndex = 10;
            // 
            // pnlPatientButtonGroup
            // 
            this.pnlPatientButtonGroup.Controls.Add(this.btnDocumentClose);
            this.pnlPatientButtonGroup.Controls.Add(this.btnPatientProcces);
            this.pnlPatientButtonGroup.Controls.Add(this.btnPatientDetail);
            this.pnlPatientButtonGroup.Controls.Add(this.btnPatientAdd);
            this.pnlPatientButtonGroup.Controls.Add(this.btnPatient);
            this.pnlPatientButtonGroup.Location = new System.Drawing.Point(3, 3);
            this.pnlPatientButtonGroup.MaximumSize = new System.Drawing.Size(202, 210);
            this.pnlPatientButtonGroup.MinimumSize = new System.Drawing.Size(202, 42);
            this.pnlPatientButtonGroup.Name = "pnlPatientButtonGroup";
            this.pnlPatientButtonGroup.Size = new System.Drawing.Size(202, 42);
            this.pnlPatientButtonGroup.TabIndex = 29;
            // 
            // btnDocumentClose
            // 
            this.btnDocumentClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnDocumentClose.FlatAppearance.BorderSize = 0;
            this.btnDocumentClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDocumentClose.ForeColor = System.Drawing.Color.White;
            this.btnDocumentClose.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnDocumentClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentClose.Location = new System.Drawing.Point(32, 169);
            this.btnDocumentClose.Name = "btnDocumentClose";
            this.btnDocumentClose.Size = new System.Drawing.Size(165, 36);
            this.btnDocumentClose.TabIndex = 26;
            this.btnDocumentClose.Text = "Hasta Çıkış";
            this.btnDocumentClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDocumentClose.UseVisualStyleBackColor = false;
            this.btnDocumentClose.Click += new System.EventHandler(this.btnDocumentClose_Click);
            // 
            // btnPatientProcces
            // 
            this.btnPatientProcces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnPatientProcces.FlatAppearance.BorderSize = 0;
            this.btnPatientProcces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientProcces.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatientProcces.ForeColor = System.Drawing.Color.White;
            this.btnPatientProcces.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnPatientProcces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientProcces.Location = new System.Drawing.Point(32, 127);
            this.btnPatientProcces.Name = "btnPatientProcces";
            this.btnPatientProcces.Size = new System.Drawing.Size(165, 36);
            this.btnPatientProcces.TabIndex = 25;
            this.btnPatientProcces.Text = "Hasta İşlemleri";
            this.btnPatientProcces.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatientProcces.UseVisualStyleBackColor = false;
            this.btnPatientProcces.Click += new System.EventHandler(this.btnPatientProcces_Click);
            // 
            // btnPatientDetail
            // 
            this.btnPatientDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnPatientDetail.FlatAppearance.BorderSize = 0;
            this.btnPatientDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatientDetail.ForeColor = System.Drawing.Color.White;
            this.btnPatientDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnPatientDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientDetail.Location = new System.Drawing.Point(32, 85);
            this.btnPatientDetail.Name = "btnPatientDetail";
            this.btnPatientDetail.Size = new System.Drawing.Size(165, 36);
            this.btnPatientDetail.TabIndex = 16;
            this.btnPatientDetail.Text = "Yeni Dosya";
            this.btnPatientDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatientDetail.UseVisualStyleBackColor = false;
            this.btnPatientDetail.Click += new System.EventHandler(this.btnPatientDetail_Click);
            // 
            // btnPatientAdd
            // 
            this.btnPatientAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnPatientAdd.FlatAppearance.BorderSize = 0;
            this.btnPatientAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatientAdd.ForeColor = System.Drawing.Color.White;
            this.btnPatientAdd.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Add_32px;
            this.btnPatientAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientAdd.Location = new System.Drawing.Point(32, 43);
            this.btnPatientAdd.Name = "btnPatientAdd";
            this.btnPatientAdd.Size = new System.Drawing.Size(165, 36);
            this.btnPatientAdd.TabIndex = 17;
            this.btnPatientAdd.Text = "Yeni Hasta";
            this.btnPatientAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatientAdd.UseVisualStyleBackColor = false;
            this.btnPatientAdd.Click += new System.EventHandler(this.btnPatientAdd_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnPatient.FlatAppearance.BorderSize = 0;
            this.btnPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatient.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatient.ForeColor = System.Drawing.Color.White;
            this.btnPatient.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Expand_Arrow_36px;
            this.btnPatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatient.Location = new System.Drawing.Point(1, 3);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(1);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Size = new System.Drawing.Size(196, 36);
            this.btnPatient.TabIndex = 24;
            this.btnPatient.Text = "Hasta";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPatient.UseVisualStyleBackColor = false;
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // pnlStaffButtonGroup
            // 
            this.pnlStaffButtonGroup.Controls.Add(this.btnStaff);
            this.pnlStaffButtonGroup.Controls.Add(this.btnAddStaff);
            this.pnlStaffButtonGroup.Controls.Add(this.btnStaffDetail);
            this.pnlStaffButtonGroup.Location = new System.Drawing.Point(3, 51);
            this.pnlStaffButtonGroup.MaximumSize = new System.Drawing.Size(202, 124);
            this.pnlStaffButtonGroup.MinimumSize = new System.Drawing.Size(202, 42);
            this.pnlStaffButtonGroup.Name = "pnlStaffButtonGroup";
            this.pnlStaffButtonGroup.Size = new System.Drawing.Size(202, 42);
            this.pnlStaffButtonGroup.TabIndex = 25;
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Expand_Arrow_36px;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(1, 3);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(196, 36);
            this.btnStaff.TabIndex = 24;
            this.btnStaff.Text = "Personel";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddStaff.ForeColor = System.Drawing.Color.White;
            this.btnAddStaff.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Add_32px;
            this.btnAddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStaff.Location = new System.Drawing.Point(32, 45);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(165, 36);
            this.btnAddStaff.TabIndex = 15;
            this.btnAddStaff.Text = "Personel Ekle";
            this.btnAddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnStaffDetail
            // 
            this.btnStaffDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnStaffDetail.FlatAppearance.BorderSize = 0;
            this.btnStaffDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaffDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStaffDetail.ForeColor = System.Drawing.Color.White;
            this.btnStaffDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnStaffDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffDetail.Location = new System.Drawing.Point(32, 85);
            this.btnStaffDetail.Margin = new System.Windows.Forms.Padding(1);
            this.btnStaffDetail.Name = "btnStaffDetail";
            this.btnStaffDetail.Size = new System.Drawing.Size(165, 36);
            this.btnStaffDetail.TabIndex = 14;
            this.btnStaffDetail.Text = "Personel Detay";
            this.btnStaffDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffDetail.UseVisualStyleBackColor = false;
            this.btnStaffDetail.Click += new System.EventHandler(this.btnStaffDetail_Click);
            // 
            // pnlProccesButtonGroup
            // 
            this.pnlProccesButtonGroup.Controls.Add(this.btnProccesDetail);
            this.pnlProccesButtonGroup.Controls.Add(this.btnProcces);
            this.pnlProccesButtonGroup.Controls.Add(this.btnProccesAdd);
            this.pnlProccesButtonGroup.Location = new System.Drawing.Point(3, 99);
            this.pnlProccesButtonGroup.MaximumSize = new System.Drawing.Size(202, 124);
            this.pnlProccesButtonGroup.MinimumSize = new System.Drawing.Size(202, 42);
            this.pnlProccesButtonGroup.Name = "pnlProccesButtonGroup";
            this.pnlProccesButtonGroup.Size = new System.Drawing.Size(202, 42);
            this.pnlProccesButtonGroup.TabIndex = 26;
            // 
            // btnProccesDetail
            // 
            this.btnProccesDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnProccesDetail.FlatAppearance.BorderSize = 0;
            this.btnProccesDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccesDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProccesDetail.ForeColor = System.Drawing.Color.White;
            this.btnProccesDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnProccesDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProccesDetail.Location = new System.Drawing.Point(32, 85);
            this.btnProccesDetail.Name = "btnProccesDetail";
            this.btnProccesDetail.Size = new System.Drawing.Size(165, 36);
            this.btnProccesDetail.TabIndex = 21;
            this.btnProccesDetail.Text = "İşlem Detay";
            this.btnProccesDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProccesDetail.UseVisualStyleBackColor = false;
            this.btnProccesDetail.Click += new System.EventHandler(this.btnProccesDetail_Click);
            // 
            // btnProcces
            // 
            this.btnProcces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnProcces.FlatAppearance.BorderSize = 0;
            this.btnProcces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcces.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcces.ForeColor = System.Drawing.Color.White;
            this.btnProcces.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Expand_Arrow_36px;
            this.btnProcces.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcces.Location = new System.Drawing.Point(1, 3);
            this.btnProcces.Name = "btnProcces";
            this.btnProcces.Size = new System.Drawing.Size(196, 36);
            this.btnProcces.TabIndex = 24;
            this.btnProcces.Text = "İşlemler";
            this.btnProcces.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcces.UseVisualStyleBackColor = false;
            this.btnProcces.Click += new System.EventHandler(this.btnProcces_Click);
            // 
            // btnProccesAdd
            // 
            this.btnProccesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnProccesAdd.FlatAppearance.BorderSize = 0;
            this.btnProccesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProccesAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProccesAdd.ForeColor = System.Drawing.Color.White;
            this.btnProccesAdd.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Add_32px;
            this.btnProccesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProccesAdd.Location = new System.Drawing.Point(32, 43);
            this.btnProccesAdd.Name = "btnProccesAdd";
            this.btnProccesAdd.Size = new System.Drawing.Size(165, 36);
            this.btnProccesAdd.TabIndex = 20;
            this.btnProccesAdd.Text = "Yeni İşlem Ekle";
            this.btnProccesAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProccesAdd.UseVisualStyleBackColor = false;
            this.btnProccesAdd.Click += new System.EventHandler(this.btnProccesAdd_Click);
            // 
            // pnlRoleButtonGroup
            // 
            this.pnlRoleButtonGroup.Controls.Add(this.btnRole);
            this.pnlRoleButtonGroup.Controls.Add(this.btnRoleAdd);
            this.pnlRoleButtonGroup.Controls.Add(this.btnRoleDetail);
            this.pnlRoleButtonGroup.Location = new System.Drawing.Point(3, 147);
            this.pnlRoleButtonGroup.MaximumSize = new System.Drawing.Size(202, 124);
            this.pnlRoleButtonGroup.MinimumSize = new System.Drawing.Size(202, 42);
            this.pnlRoleButtonGroup.Name = "pnlRoleButtonGroup";
            this.pnlRoleButtonGroup.Size = new System.Drawing.Size(202, 42);
            this.pnlRoleButtonGroup.TabIndex = 27;
            // 
            // btnRole
            // 
            this.btnRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRole.ForeColor = System.Drawing.Color.White;
            this.btnRole.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Expand_Arrow_36px;
            this.btnRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.Location = new System.Drawing.Point(1, 3);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(196, 36);
            this.btnRole.TabIndex = 24;
            this.btnRole.Text = "Yetki";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRole.UseVisualStyleBackColor = false;
            this.btnRole.Click += new System.EventHandler(this.btnRole_Click);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnRoleAdd.FlatAppearance.BorderSize = 0;
            this.btnRoleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoleAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoleAdd.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Add_32px;
            this.btnRoleAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoleAdd.Location = new System.Drawing.Point(32, 43);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(165, 36);
            this.btnRoleAdd.TabIndex = 19;
            this.btnRoleAdd.Text = "Yeni Rol Ekle";
            this.btnRoleAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoleAdd.UseVisualStyleBackColor = false;
            this.btnRoleAdd.Click += new System.EventHandler(this.btnRoleAdd_Click);
            // 
            // btnRoleDetail
            // 
            this.btnRoleDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnRoleDetail.FlatAppearance.BorderSize = 0;
            this.btnRoleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoleDetail.ForeColor = System.Drawing.Color.White;
            this.btnRoleDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnRoleDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoleDetail.Location = new System.Drawing.Point(32, 85);
            this.btnRoleDetail.Name = "btnRoleDetail";
            this.btnRoleDetail.Size = new System.Drawing.Size(165, 36);
            this.btnRoleDetail.TabIndex = 18;
            this.btnRoleDetail.Text = "Rol Detay";
            this.btnRoleDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoleDetail.UseVisualStyleBackColor = false;
            this.btnRoleDetail.Click += new System.EventHandler(this.btnRoleDetail_Click);
            // 
            // pnlPoliclinicButtonGroup
            // 
            this.pnlPoliclinicButtonGroup.Controls.Add(this.btnPoliclinicDetail);
            this.pnlPoliclinicButtonGroup.Controls.Add(this.btnPoliclinicAdd);
            this.pnlPoliclinicButtonGroup.Controls.Add(this.btnPoliclinic);
            this.pnlPoliclinicButtonGroup.Location = new System.Drawing.Point(3, 195);
            this.pnlPoliclinicButtonGroup.MaximumSize = new System.Drawing.Size(202, 124);
            this.pnlPoliclinicButtonGroup.MinimumSize = new System.Drawing.Size(202, 42);
            this.pnlPoliclinicButtonGroup.Name = "pnlPoliclinicButtonGroup";
            this.pnlPoliclinicButtonGroup.Size = new System.Drawing.Size(202, 42);
            this.pnlPoliclinicButtonGroup.TabIndex = 28;
            // 
            // btnPoliclinicDetail
            // 
            this.btnPoliclinicDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnPoliclinicDetail.FlatAppearance.BorderSize = 0;
            this.btnPoliclinicDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoliclinicDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPoliclinicDetail.ForeColor = System.Drawing.Color.White;
            this.btnPoliclinicDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnPoliclinicDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoliclinicDetail.Location = new System.Drawing.Point(32, 85);
            this.btnPoliclinicDetail.Name = "btnPoliclinicDetail";
            this.btnPoliclinicDetail.Size = new System.Drawing.Size(165, 36);
            this.btnPoliclinicDetail.TabIndex = 16;
            this.btnPoliclinicDetail.Text = "PoliklinikDetay";
            this.btnPoliclinicDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPoliclinicDetail.UseVisualStyleBackColor = false;
            this.btnPoliclinicDetail.Click += new System.EventHandler(this.btnPoliclinicDetail_Click);
            // 
            // btnPoliclinicAdd
            // 
            this.btnPoliclinicAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.btnPoliclinicAdd.FlatAppearance.BorderSize = 0;
            this.btnPoliclinicAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoliclinicAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPoliclinicAdd.ForeColor = System.Drawing.Color.White;
            this.btnPoliclinicAdd.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Add_32px;
            this.btnPoliclinicAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoliclinicAdd.Location = new System.Drawing.Point(32, 43);
            this.btnPoliclinicAdd.Name = "btnPoliclinicAdd";
            this.btnPoliclinicAdd.Size = new System.Drawing.Size(165, 36);
            this.btnPoliclinicAdd.TabIndex = 17;
            this.btnPoliclinicAdd.Text = "Poliklinik Ekle";
            this.btnPoliclinicAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPoliclinicAdd.UseVisualStyleBackColor = false;
            this.btnPoliclinicAdd.Click += new System.EventHandler(this.btnPoliclinicAdd_Click);
            // 
            // btnPoliclinic
            // 
            this.btnPoliclinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnPoliclinic.FlatAppearance.BorderSize = 0;
            this.btnPoliclinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoliclinic.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPoliclinic.ForeColor = System.Drawing.Color.White;
            this.btnPoliclinic.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Expand_Arrow_36px;
            this.btnPoliclinic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPoliclinic.Location = new System.Drawing.Point(1, 3);
            this.btnPoliclinic.Margin = new System.Windows.Forms.Padding(1);
            this.btnPoliclinic.Name = "btnPoliclinic";
            this.btnPoliclinic.Size = new System.Drawing.Size(196, 36);
            this.btnPoliclinic.TabIndex = 24;
            this.btnPoliclinic.Text = "Poliklinik";
            this.btnPoliclinic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPoliclinic.UseVisualStyleBackColor = false;
            this.btnPoliclinic.Click += new System.EventHandler(this.btnPoliclinic_Click);
            // 
            // pnlLeftMainLogoContainer
            // 
            this.pnlLeftMainLogoContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftMainLogoContainer.Controls.Add(this.pnlLeftTitle);
            this.pnlLeftMainLogoContainer.Controls.Add(this.MenuLogo);
            this.pnlLeftMainLogoContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftMainLogoContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMainLogoContainer.Name = "pnlLeftMainLogoContainer";
            this.pnlLeftMainLogoContainer.Size = new System.Drawing.Size(225, 82);
            this.pnlLeftMainLogoContainer.TabIndex = 9;
            // 
            // pnlLeftTitle
            // 
            this.pnlLeftTitle.AutoSize = true;
            this.pnlLeftTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlLeftTitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.pnlLeftTitle.Location = new System.Drawing.Point(99, 7);
            this.pnlLeftTitle.Name = "pnlLeftTitle";
            this.pnlLeftTitle.Size = new System.Drawing.Size(107, 63);
            this.pnlLeftTitle.TabIndex = 8;
            this.pnlLeftTitle.Text = "Sağlık Ocağı\r\nHasta Takip \r\nSistemi";
            this.pnlLeftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuLogo
            // 
            this.MenuLogo.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.sblogo3;
            this.MenuLogo.Location = new System.Drawing.Point(3, 3);
            this.MenuLogo.Name = "MenuLogo";
            this.MenuLogo.Size = new System.Drawing.Size(80, 65);
            this.MenuLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuLogo.TabIndex = 6;
            this.MenuLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBottom.Controls.Add(this.pictureforStaff);
            this.pnlBottom.Controls.Add(this.btnExit);
            this.pnlBottom.Controls.Add(this.lblRole);
            this.pnlBottom.Controls.Add(this.lblUserName);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 478);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(225, 119);
            this.pnlBottom.TabIndex = 3;
            // 
            // pictureforStaff
            // 
            this.pictureforStaff.Location = new System.Drawing.Point(3, 45);
            this.pictureforStaff.Name = "pictureforStaff";
            this.pictureforStaff.Size = new System.Drawing.Size(80, 65);
            this.pictureforStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureforStaff.TabIndex = 5;
            this.pictureforStaff.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Import_32px;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 36);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Uygulamayı Kapat";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.ExitButtons);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(89, 78);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(86, 21);
            this.lblRole.TabIndex = 4;
            this.lblRole.Text = "Test.Data";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(89, 50);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(86, 21);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Test.Data";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.bodyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(227, 41);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(958, 599);
            this.bodyPanel.TabIndex = 3;
            // 
            // dropDownTriggerForStaff
            // 
            this.dropDownTriggerForStaff.Interval = 15;
            this.dropDownTriggerForStaff.Tick += new System.EventHandler(this.dropDownTriggerForStaff_Tick);
            // 
            // dropDownTriggerForPocces
            // 
            this.dropDownTriggerForPocces.Interval = 15;
            this.dropDownTriggerForPocces.Tick += new System.EventHandler(this.dropDownTriggerForPocces_Tick);
            // 
            // dropDownTriggerForRole
            // 
            this.dropDownTriggerForRole.Interval = 15;
            this.dropDownTriggerForRole.Tick += new System.EventHandler(this.dropDownTriggerForRole_Tick);
            // 
            // dropDownTriggerForPoliclinic
            // 
            this.dropDownTriggerForPoliclinic.Interval = 15;
            this.dropDownTriggerForPoliclinic.Tick += new System.EventHandler(this.dropDownTriggerForPoliclinic_Tick);
            // 
            // dropDownTriggerForPatient
            // 
            this.dropDownTriggerForPatient.Interval = 15;
            this.dropDownTriggerForPatient.Tick += new System.EventHandler(this.dropDownTriggerForPatient_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BackgroundImage = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Delete_32px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1185, 640);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTopBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = this.lblFormText.Text;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FormTitleLogo)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlPatientButtonGroup.ResumeLayout(false);
            this.pnlStaffButtonGroup.ResumeLayout(false);
            this.pnlProccesButtonGroup.ResumeLayout(false);
            this.pnlRoleButtonGroup.ResumeLayout(false);
            this.pnlPoliclinicButtonGroup.ResumeLayout(false);
            this.pnlLeftMainLogoContainer.ResumeLayout(false);
            this.pnlLeftMainLogoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogo)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureforStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.PictureBox FormTitleLogo;
        private System.Windows.Forms.Label lblFormText;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnClose;
        private Panel pnlBottom;
        private PictureBox pictureforStaff;
        private Label lblRole;
        private Label lblUserName;
        private Button btnExit;
        private PictureBox MenuLogo;
        private Label pnlLeftTitle;
        private Panel pnlLeftMainLogoContainer;
        private Button btnAddStaff;
        private Button btnStaffDetail;
        private Button btnPoliclinicAdd;
        private Button btnPoliclinicDetail;
        private Button btnRoleAdd;
        private Button btnRoleDetail;
        private Button btnProccesDetail;
        private Button btnProccesAdd;
        public Panel bodyPanel;
        private FlowLayoutPanel pnlLeftMenu;
        private Panel pnlStaffButtonGroup;
        private Timer dropDownTriggerForStaff;
        private Button btnStaff;
        private Panel pnlProccesButtonGroup;
        private Button btnProcces;
        private Timer dropDownTriggerForPocces;
        private Panel pnlRoleButtonGroup;
        private Button btnRole;
        private Timer dropDownTriggerForRole;
        private Panel pnlPoliclinicButtonGroup;
        private Button btnPoliclinic;
        private Timer dropDownTriggerForPoliclinic;
        private Panel pnlPatientButtonGroup;
        private Button btnPatientDetail;
        private Button btnPatientAdd;
        private Button btnPatient;
        private Button btnPatientProcces;
        private Timer dropDownTriggerForPatient;
        private Button btnDocumentClose;
    }
}