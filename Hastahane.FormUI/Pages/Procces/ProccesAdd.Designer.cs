namespace Hastahane.FormUI.Pages.Procces
{
    partial class ProccesAdd
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
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdPasive = new System.Windows.Forms.RadioButton();
            this.rdActive = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rcTxtDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 51;
            this.label15.Text = "Durum :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdPasive);
            this.panel2.Controls.Add(this.rdActive);
            this.panel2.Location = new System.Drawing.Point(120, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 32);
            this.panel2.TabIndex = 50;
            // 
            // rdPasive
            // 
            this.rdPasive.AutoSize = true;
            this.rdPasive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdPasive.ForeColor = System.Drawing.Color.White;
            this.rdPasive.Location = new System.Drawing.Point(99, 4);
            this.rdPasive.Name = "rdPasive";
            this.rdPasive.Size = new System.Drawing.Size(62, 25);
            this.rdPasive.TabIndex = 1;
            this.rdPasive.Text = "Pasif";
            this.rdPasive.UseVisualStyleBackColor = true;
            // 
            // rdActive
            // 
            this.rdActive.AutoSize = true;
            this.rdActive.Checked = true;
            this.rdActive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdActive.ForeColor = System.Drawing.Color.White;
            this.rdActive.Location = new System.Drawing.Point(13, 4);
            this.rdActive.Name = "rdActive";
            this.rdActive.Size = new System.Drawing.Size(64, 25);
            this.rdActive.TabIndex = 0;
            this.rdActive.TabStop = true;
            this.rdActive.Text = "Aktif";
            this.rdActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Açıklama :";
            // 
            // rcTxtDescription
            // 
            this.rcTxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.rcTxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rcTxtDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rcTxtDescription.ForeColor = System.Drawing.Color.White;
            this.rcTxtDescription.Location = new System.Drawing.Point(120, 34);
            this.rcTxtDescription.Name = "rcTxtDescription";
            this.rcTxtDescription.Size = new System.Drawing.Size(200, 62);
            this.rcTxtDescription.TabIndex = 47;
            this.rcTxtDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "İşlem Adı :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(120, 4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 45;
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
            this.btnSave.Location = new System.Drawing.Point(149, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(171, 40);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Verileri Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(0, 137);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 40);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProccesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rcTxtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "ProccesAdd";
            this.Size = new System.Drawing.Size(325, 192);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdPasive;
        private System.Windows.Forms.RadioButton rdActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rcTxtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
    }
}
