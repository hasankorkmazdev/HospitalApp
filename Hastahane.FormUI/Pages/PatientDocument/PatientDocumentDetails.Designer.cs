namespace Hastahane.FormUI.Pages.PatientDocument
{
    partial class PatientDocumentDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle28;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(0, 70);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle29;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle30;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(920, 442);
            this.dgvList.TabIndex = 31;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Save_as_32px;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(3, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(173, 40);
            this.btnPrint.TabIndex = 32;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Save_as_32px;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(182, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(173, 40);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Çıkış Yap";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(719, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Toplam Tutar : ";
            // 
            // PatientDocumentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvList);
            this.Name = "PatientDocumentDetails";
            this.Size = new System.Drawing.Size(920, 512);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
    }
}
