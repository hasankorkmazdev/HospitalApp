namespace Hastahane.FormUI.Pages.Patient
{
    partial class PatientAdd
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBekar = new System.Windows.Forms.RadioButton();
            this.rdEvli = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbBloodTypes = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.rcTxtAdress = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumentNumber = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Save_as_32px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(442, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(203, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Verileri Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(16, 206);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 64;
            this.label15.Text = "Medeni Hal :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdBekar);
            this.panel2.Controls.Add(this.rdEvli);
            this.panel2.Location = new System.Drawing.Point(119, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 6;
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBekar.ForeColor = System.Drawing.Color.White;
            this.rdBekar.Location = new System.Drawing.Point(99, 4);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(71, 25);
            this.rdBekar.TabIndex = 13;
            this.rdBekar.Text = "Bekar";
            this.rdBekar.UseVisualStyleBackColor = true;
            // 
            // rdEvli
            // 
            this.rdEvli.AutoSize = true;
            this.rdEvli.Checked = true;
            this.rdEvli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdEvli.ForeColor = System.Drawing.Color.White;
            this.rdEvli.Location = new System.Drawing.Point(13, 4);
            this.rdEvli.Name = "rdEvli";
            this.rdEvli.Size = new System.Drawing.Size(57, 25);
            this.rdEvli.TabIndex = 12;
            this.rdEvli.TabStop = true;
            this.rdEvli.Text = "Evli ";
            this.rdEvli.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(38, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 62;
            this.label14.Text = "Cinsiyet :";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdKadin);
            this.panel1.Controls.Add(this.rdErkek);
            this.panel1.Location = new System.Drawing.Point(119, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 5;
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKadin.ForeColor = System.Drawing.Color.White;
            this.rdKadin.Location = new System.Drawing.Point(99, 4);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(72, 25);
            this.rdKadin.TabIndex = 7;
            this.rdKadin.Text = "Kadın";
            this.rdKadin.UseVisualStyleBackColor = true;
            // 
            // rdErkek
            // 
            this.rdErkek.AutoSize = true;
            this.rdErkek.Checked = true;
            this.rdErkek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdErkek.ForeColor = System.Drawing.Color.White;
            this.rdErkek.Location = new System.Drawing.Point(13, 3);
            this.rdErkek.Name = "rdErkek";
            this.rdErkek.Size = new System.Drawing.Size(68, 25);
            this.rdErkek.TabIndex = 6;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Kan Gurubu :";
            // 
            // cmbBloodTypes
            // 
            this.cmbBloodTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbBloodTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloodTypes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBloodTypes.ForeColor = System.Drawing.Color.White;
            this.cmbBloodTypes.FormattingEnabled = true;
            this.cmbBloodTypes.Location = new System.Drawing.Point(119, 128);
            this.cmbBloodTypes.Name = "cmbBloodTypes";
            this.cmbBloodTypes.Size = new System.Drawing.Size(200, 29);
            this.cmbBloodTypes.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(327, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Doğum Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(379, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Adres :";
            // 
            // pickerBornDate
            // 
            this.pickerBornDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pickerBornDate.Location = new System.Drawing.Point(442, 164);
            this.pickerBornDate.Name = "pickerBornDate";
            this.pickerBornDate.Size = new System.Drawing.Size(200, 26);
            this.pickerBornDate.TabIndex = 10;
            // 
            // rcTxtAdress
            // 
            this.rcTxtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.rcTxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcTxtAdress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcTxtAdress.ForeColor = System.Drawing.Color.White;
            this.rcTxtAdress.Location = new System.Drawing.Point(442, 67);
            this.rcTxtAdress.Name = "rcTxtAdress";
            this.rcTxtAdress.Size = new System.Drawing.Size(200, 90);
            this.rcTxtAdress.TabIndex = 9;
            this.rcTxtAdress.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(399, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 43;
            this.label4.Text = "EV :";
            // 
            // txtTel2
            // 
            this.txtTel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel2.ForeColor = System.Drawing.Color.White;
            this.txtTel2.Location = new System.Drawing.Point(442, 41);
            this.txtTel2.Mask = "(999) 000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(200, 20);
            this.txtTel2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(384, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "GSM :";
            // 
            // txtTel1
            // 
            this.txtTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel1.ForeColor = System.Drawing.Color.White;
            this.txtTel1.Location = new System.Drawing.Point(442, 12);
            this.txtTel1.Mask = "(999) 000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(200, 20);
            this.txtTel1.SkipLiterals = false;
            this.txtTel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Soyisim :";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(119, 97);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 25);
            this.txtSurname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "İsim :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(119, 66);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Broom_32px;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(145, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(174, 40);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Verileri Temizle";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 68;
            this.label5.Text = "TC Kimlik No :";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(119, 7);
            this.txtTC.MaxLength = 11;
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 25);
            this.txtTC.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Save_as_32px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(5, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 40);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(44, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Dosya  :";
            // 
            // txtDocumentNumber
            // 
            this.txtDocumentNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtDocumentNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDocumentNumber.ForeColor = System.Drawing.Color.White;
            this.txtDocumentNumber.Location = new System.Drawing.Point(119, 36);
            this.txtDocumentNumber.Multiline = true;
            this.txtDocumentNumber.Name = "txtDocumentNumber";
            this.txtDocumentNumber.Size = new System.Drawing.Size(200, 25);
            this.txtDocumentNumber.TabIndex = 1;
            // 
            // PatientAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDocumentNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBloodTypes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pickerBornDate);
            this.Controls.Add(this.rcTxtAdress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "PatientAdd";
            this.Size = new System.Drawing.Size(672, 310);
            this.Load += new System.EventHandler(this.PatientAdd_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBekar;
        private System.Windows.Forms.RadioButton rdEvli;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBloodTypes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker pickerBornDate;
        private System.Windows.Forms.RichTextBox rcTxtAdress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumentNumber;
    }
}
