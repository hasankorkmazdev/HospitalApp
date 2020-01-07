namespace Hastahane.FormUI.Pages.Patient
{
    partial class PatientList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTCNumber = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(288, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Soyisim :";
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.Location = new System.Drawing.Point(368, 3);
            this.txtSurname.Multiline = true;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 25);
            this.txtSurname.TabIndex = 52;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtParametersChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "İsim :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(82, 3);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 51;
            this.txtName.TextChanged += new System.EventHandler(this.txtParametersChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "TC Kimlik :";
            // 
            // txtTCNumber
            // 
            this.txtTCNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtTCNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTCNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTCNumber.ForeColor = System.Drawing.Color.White;
            this.txtTCNumber.Location = new System.Drawing.Point(82, 34);
            this.txtTCNumber.Multiline = true;
            this.txtTCNumber.Name = "txtTCNumber";
            this.txtTCNumber.Size = new System.Drawing.Size(200, 25);
            this.txtTCNumber.TabIndex = 55;
            this.txtTCNumber.TextChanged += new System.EventHandler(this.txtParametersChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Location = new System.Drawing.Point(0, 144);
            this.dgvList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvList.RowTemplate.Height = 24;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(986, 497);
            this.dgvList.TabIndex = 57;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Edit_32px;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(783, 49);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(200, 40);
            this.btnEdit.TabIndex = 69;
            this.btnEdit.Text = "Hastayı Düzenle";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Trash_Can_32px;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(783, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 40);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Hastayı Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = global::Hastahane.FormUI.ApplicationData.HospitalRosurces.Search_32px;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(577, 3);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(200, 40);
            this.btnFind.TabIndex = 67;
            this.btnFind.Text = "Hastayı Bul";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // PatientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTCNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "PatientList";
            this.Size = new System.Drawing.Size(986, 641);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTCNumber;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
    }
}
