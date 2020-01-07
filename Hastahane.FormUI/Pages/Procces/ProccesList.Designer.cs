namespace Hastahane.FormUI.Pages.Procces
{
    partial class ProccesList
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 74;
            this.label1.Text = "İşlem Adı :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(7)))), ((int)(((byte)(21)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(109, 10);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 25);
            this.txtName.TabIndex = 72;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
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
            this.btnEdit.Location = new System.Drawing.Point(563, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(153, 40);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.Text = "Rol Düzenle";
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
            this.btnDelete.Location = new System.Drawing.Point(455, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 40);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Rol Sil";
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
            this.btnFind.Location = new System.Drawing.Point(315, 0);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(134, 40);
            this.btnFind.TabIndex = 73;
            this.btnFind.Text = "Rol Bul";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = false;
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
            this.dgvList.Location = new System.Drawing.Point(0, 64);
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
            this.dgvList.Size = new System.Drawing.Size(725, 383);
            this.dgvList.TabIndex = 77;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // ProccesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "ProccesList";
            this.Size = new System.Drawing.Size(725, 447);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvList;
    }
}
