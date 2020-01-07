namespace Hastahane.FormUI.Pages.PatientDocument
{
    partial class PatientDocument
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
            this.txtTC = new System.Windows.Forms.TextBox();
            this.pickerBornDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(158, 47);
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(200, 25);
            this.txtTC.TabIndex = 17;
            // 
            // pickerBornDate
            // 
            this.pickerBornDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.pickerBornDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pickerBornDate.Location = new System.Drawing.Point(163, 81);
            this.pickerBornDate.Name = "pickerBornDate";
            this.pickerBornDate.Size = new System.Drawing.Size(195, 26);
            this.pickerBornDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Hasta TC Numarası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kayıt Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Dosya Numarası :";
            // 
            // txtDocumentID
            // 
            this.txtDocumentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDocumentID.ForeColor = System.Drawing.Color.White;
            this.txtDocumentID.Location = new System.Drawing.Point(158, 16);
            this.txtDocumentID.Multiline = true;
            this.txtDocumentID.Name = "txtDocumentID";
            this.txtDocumentID.Size = new System.Drawing.Size(200, 25);
            this.txtDocumentID.TabIndex = 25;
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
            this.btnSave.Location = new System.Drawing.Point(185, 113);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(173, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Dosya Aç";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PatientDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumentID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pickerBornDate);
            this.Name = "PatientDocument";
            this.Size = new System.Drawing.Size(361, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker pickerBornDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentID;
    }
}
