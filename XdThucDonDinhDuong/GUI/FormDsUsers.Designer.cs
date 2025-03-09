namespace XdThucDonDinhDuong.GUI
{
    partial class FormDsUsers
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
            
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDsUsers = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dangNhapTableAdapter1
            // 
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH SÁCH NGƯỜI DÙNG";
            // 
            // dgvDsUsers
            // 
            this.dgvDsUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDsUsers.Location = new System.Drawing.Point(54, 183);
            this.dgvDsUsers.Name = "dgvDsUsers";
            this.dgvDsUsers.RowHeadersWidth = 51;
            this.dgvDsUsers.RowTemplate.Height = 24;
            this.dgvDsUsers.Size = new System.Drawing.Size(691, 221);
            this.dgvDsUsers.TabIndex = 1;
            this.dgvDsUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDsUsers_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(634, 110);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 46);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormDsUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvDsUsers);
            this.Controls.Add(this.label1);
            this.Name = "FormDsUsers";
            this.Text = "FormDsUsers";
            this.Load += new System.EventHandler(this.FormDsUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDsUsers;
        private System.Windows.Forms.Button btnAdd;
    }
}