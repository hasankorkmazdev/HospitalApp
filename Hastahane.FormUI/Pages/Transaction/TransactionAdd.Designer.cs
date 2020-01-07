namespace Hastahane.FormUI.Pages.Transaction
{
    partial class TransactionAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbStaff = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbProcces = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericPiece = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numPrice = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 11515;
            this.label3.Text = "Dosya Numarası :";
            // 
            // txtDocumentID
            // 
            this.txtDocumentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDocumentID.ForeColor = System.Drawing.Color.White;
            this.txtDocumentID.Location = new System.Drawing.Point(144, 3);
            this.txtDocumentID.Multiline = true;
            this.txtDocumentID.Name = "txtDocumentID";
            this.txtDocumentID.Size = new System.Drawing.Size(200, 25);
            this.txtDocumentID.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(73, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 55;
            this.label9.Text = "Doktor :";
            // 
            // cmbStaff
            // 
            this.cmbStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbStaff.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbStaff.ForeColor = System.Drawing.Color.White;
            this.cmbStaff.FormattingEnabled = true;
            this.cmbStaff.Location = new System.Drawing.Point(144, 32);
            this.cmbStaff.Name = "cmbStaff";
            this.cmbStaff.Size = new System.Drawing.Size(200, 29);
            this.cmbStaff.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "İşlem :";
            // 
            // cmbProcces
            // 
            this.cmbProcces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.cmbProcces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProcces.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbProcces.ForeColor = System.Drawing.Color.White;
            this.cmbProcces.FormattingEnabled = true;
            this.cmbProcces.Location = new System.Drawing.Point(144, 64);
            this.cmbProcces.Name = "cmbProcces";
            this.cmbProcces.Size = new System.Drawing.Size(200, 29);
            this.cmbProcces.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(357, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 59;
            this.label5.Text = "İşlem Adeti :";
            // 
            // numericPiece
            // 
            this.numericPiece.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.numericPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericPiece.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numericPiece.ForeColor = System.Drawing.Color.White;
            this.numericPiece.Location = new System.Drawing.Point(459, 4);
            this.numericPiece.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericPiece.Name = "numericPiece";
            this.numericPiece.Size = new System.Drawing.Size(161, 23);
            this.numericPiece.TabIndex = 3;
            this.numericPiece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "Birim Tutar :";
            // 
            // numPrice
            // 
            this.numPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.numPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numPrice.DecimalPlaces = 2;
            this.numPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numPrice.ForeColor = System.Drawing.Color.White;
            this.numPrice.Location = new System.Drawing.Point(459, 36);
            this.numPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPrice.Name = "numPrice";
            this.numPrice.Size = new System.Drawing.Size(161, 23);
            this.numPrice.TabIndex = 4;
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
            this.btnSave.Location = new System.Drawing.Point(420, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Verileri Kaydet";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TransactionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericPiece);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProcces);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbStaff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumentID);
            this.Controls.Add(this.btnSave);
            this.Name = "TransactionAdd";
            this.Size = new System.Drawing.Size(624, 113);
            ((System.ComponentModel.ISupportInitialize)(this.numericPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProcces;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericPiece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numPrice;
    }
}
