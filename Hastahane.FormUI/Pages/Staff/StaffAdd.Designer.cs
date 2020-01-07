namespace Hastahane.FormUI.Pages.Staff
{
    partial class StaffAdd
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.MaskedTextBox();
            this.numericSalary = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.rcTxtAdress = new System.Windows.Forms.RichTextBox();
            this.pickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pickerEntryDate = new System.Windows.Forms.DateTimePicker();
            this.cmbBloodTypes = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdKadin = new System.Windows.Forms.RadioButton();
            this.rdErkek = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbPoliclinic = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdBekar = new System.Windows.Forms.RadioButton();
            this.rdEvli = new System.Windows.Forms.RadioButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(140, 14);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyisim :";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(140, 44);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 25);
            this.txtSurname.TabIndex = 1;
            // 
            // txtTel1
            // 
            this.txtTel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel1.ForeColor = System.Drawing.Color.White;
            this.txtTel1.Location = new System.Drawing.Point(452, 18);
            this.txtTel1.Mask = "(999) 000-0000";
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(200, 20);
            this.txtTel1.SkipLiterals = false;
            this.txtTel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(394, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "GSM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "EV :";
            // 
            // txtTel2
            // 
            this.txtTel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTel2.ForeColor = System.Drawing.Color.White;
            this.txtTel2.Location = new System.Drawing.Point(452, 47);
            this.txtTel2.Mask = "(999) 000-0000";
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(200, 20);
            this.txtTel2.TabIndex = 9;
            // 
            // numericSalary
            // 
            this.numericSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.numericSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericSalary.DecimalPlaces = 2;
            this.numericSalary.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericSalary.ForeColor = System.Drawing.Color.White;
            this.numericSalary.Location = new System.Drawing.Point(140, 142);
            this.numericSalary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numericSalary.Name = "numericSalary";
            this.numericSalary.Size = new System.Drawing.Size(200, 23);
            this.numericSalary.TabIndex = 4;
            this.numericSalary.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(77, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Maaş :";
            // 
            // rcTxtAdress
            // 
            this.rcTxtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.rcTxtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcTxtAdress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcTxtAdress.ForeColor = System.Drawing.Color.White;
            this.rcTxtAdress.Location = new System.Drawing.Point(452, 73);
            this.rcTxtAdress.MaxLength = 250;
            this.rcTxtAdress.Name = "rcTxtAdress";
            this.rcTxtAdress.Size = new System.Drawing.Size(200, 62);
            this.rcTxtAdress.TabIndex = 10;
            this.rcTxtAdress.Text = "";
            // 
            // pickerBornDate
            // 
            this.pickerBornDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pickerBornDate.Location = new System.Drawing.Point(140, 76);
            this.pickerBornDate.Name = "pickerBornDate";
            this.pickerBornDate.Size = new System.Drawing.Size(200, 26);
            this.pickerBornDate.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(389, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Adres :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Doğum Tarihi :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Başlangıç Tarihi :";
            // 
            // pickerEntryDate
            // 
            this.pickerEntryDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerEntryDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerEntryDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pickerEntryDate.Location = new System.Drawing.Point(140, 109);
            this.pickerEntryDate.Name = "pickerEntryDate";
            this.pickerEntryDate.Size = new System.Drawing.Size(200, 26);
            this.pickerEntryDate.TabIndex = 3;
            // 
            // cmbBloodTypes
            // 
            this.cmbBloodTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbBloodTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBloodTypes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbBloodTypes.ForeColor = System.Drawing.Color.White;
            this.cmbBloodTypes.FormattingEnabled = true;
            this.cmbBloodTypes.Location = new System.Drawing.Point(140, 170);
            this.cmbBloodTypes.Name = "cmbBloodTypes";
            this.cmbBloodTypes.Size = new System.Drawing.Size(200, 29);
            this.cmbBloodTypes.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kan Gurubu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(68, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ünvan :";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(140, 240);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(200, 29);
            this.cmbRole.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdKadin);
            this.panel1.Controls.Add(this.rdErkek);
            this.panel1.Location = new System.Drawing.Point(452, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 32);
            this.panel1.TabIndex = 13;
            // 
            // rdKadin
            // 
            this.rdKadin.AutoSize = true;
            this.rdKadin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdKadin.ForeColor = System.Drawing.Color.White;
            this.rdKadin.Location = new System.Drawing.Point(99, 4);
            this.rdKadin.Name = "rdKadin";
            this.rdKadin.Size = new System.Drawing.Size(72, 25);
            this.rdKadin.TabIndex = 1;
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
            this.rdErkek.TabIndex = 0;
            this.rdErkek.TabStop = true;
            this.rdErkek.Text = "Erkek";
            this.rdErkek.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(55, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Poliklinik :";
            // 
            // cmbPoliclinic
            // 
            this.cmbPoliclinic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbPoliclinic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPoliclinic.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPoliclinic.ForeColor = System.Drawing.Color.White;
            this.cmbPoliclinic.FormattingEnabled = true;
            this.cmbPoliclinic.Location = new System.Drawing.Point(140, 205);
            this.cmbPoliclinic.Name = "cmbPoliclinic";
            this.cmbPoliclinic.Size = new System.Drawing.Size(200, 29);
            this.cmbPoliclinic.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(347, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Kullanıcı Adı :";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(452, 138);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(200, 25);
            this.txtUsername.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(398, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Şifre :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(376, 211);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Cinsiyet :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(351, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Medeni Hal :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rdBekar);
            this.panel2.Controls.Add(this.rdEvli);
            this.panel2.Location = new System.Drawing.Point(452, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 14;
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdBekar.ForeColor = System.Drawing.Color.White;
            this.rdBekar.Location = new System.Drawing.Point(99, 4);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(71, 25);
            this.rdBekar.TabIndex = 1;
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
            this.rdEvli.TabIndex = 0;
            this.rdEvli.TabStop = true;
            this.rdEvli.Text = "Evli ";
            this.rdEvli.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(452, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 25);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Edit_32px;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(26, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(179, 40);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
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
            this.btnClear.Location = new System.Drawing.Point(217, 275);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 40);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Verileri Temizle";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnSave.Location = new System.Drawing.Point(402, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 40);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Verileri Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // StaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbPoliclinic);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbBloodTypes);
            this.Controls.Add(this.pickerEntryDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pickerBornDate);
            this.Controls.Add(this.rcTxtAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "StaffAdd";
            this.Size = new System.Drawing.Size(657, 322);
            ((System.ComponentModel.ISupportInitialize)(this.numericSalary)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox txtTel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTel2;
        private System.Windows.Forms.NumericUpDown numericSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rcTxtAdress;
        private System.Windows.Forms.DateTimePicker pickerBornDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker pickerEntryDate;
        private System.Windows.Forms.ComboBox cmbBloodTypes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbPoliclinic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdKadin;
        private System.Windows.Forms.RadioButton rdErkek;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdBekar;
        private System.Windows.Forms.RadioButton rdEvli;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnUpdate;
    }
}
