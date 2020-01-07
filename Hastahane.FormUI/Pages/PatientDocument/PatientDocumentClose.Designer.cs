namespace Hastahane.FormUI.Pages.PatientDocument
{
    partial class PatientDocumentClose
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentID = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btnDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Dosya Numarası :";
            // 
            // txtDocumentID
            // 
            this.txtDocumentID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtDocumentID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDocumentID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDocumentID.ForeColor = System.Drawing.Color.White;
            this.txtDocumentID.Location = new System.Drawing.Point(143, 11);
            this.txtDocumentID.Multiline = true;
            this.txtDocumentID.Name = "txtDocumentID";
            this.txtDocumentID.Size = new System.Drawing.Size(200, 25);
            this.txtDocumentID.TabIndex = 27;
            this.txtDocumentID.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(0, 87);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(692, 497);
            this.dgvList.TabIndex = 30;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(350, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Hasta TC Numarası:";
            // 
            // txtTC
            // 
            this.txtTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTC.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTC.ForeColor = System.Drawing.Color.White;
            this.txtTC.Location = new System.Drawing.Point(507, 11);
            this.txtTC.Multiline = true;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(182, 25);
            this.txtTC.TabIndex = 33;
            this.txtTC.TextChanged += new System.EventHandler(this.txtTC_TextChanged);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnDetail.FlatAppearance.BorderSize = 0;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Save_as_32px;
            this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetail.Location = new System.Drawing.Point(516, 42);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(173, 40);
            this.btnDetail.TabIndex = 31;
            this.btnDetail.Text = "Detay Gör";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // PatientDocumentClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDocumentID);
            this.Name = "PatientDocumentClose";
            this.Size = new System.Drawing.Size(692, 584);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDocumentID;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTC;
    }
}
