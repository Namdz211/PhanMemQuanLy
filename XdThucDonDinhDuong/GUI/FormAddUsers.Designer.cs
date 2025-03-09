namespace XdThucDonDinhDuong
{
    partial class FrmAddUsers
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
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.cbbChucNang = new System.Windows.Forms.ComboBox();
            this.TextBoxThongTin = new System.Windows.Forms.RichTextBox();
            this.bttSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtMatKhau2 = new System.Windows.Forms.TextBox();
            this.bttBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm mới người dùng";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(276, 64);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(100, 22);
            this.txtTaiKhoan.TabIndex = 1;
            this.txtTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbbChucNang
            // 
            this.cbbChucNang.FormattingEnabled = true;
            this.cbbChucNang.Items.AddRange(new object[] {
            "Toàn quyền nội dung",
            "Chỉ xem",
            "Chỉ viết",
            "Chỉ sửa",
            "Chỉ xóa"});
            this.cbbChucNang.Location = new System.Drawing.Point(276, 130);
            this.cbbChucNang.Name = "cbbChucNang";
            this.cbbChucNang.Size = new System.Drawing.Size(171, 24);
            this.cbbChucNang.TabIndex = 2;
            this.cbbChucNang.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TextBoxThongTin
            // 
            this.TextBoxThongTin.Location = new System.Drawing.Point(276, 313);
            this.TextBoxThongTin.Name = "TextBoxThongTin";
            this.TextBoxThongTin.Size = new System.Drawing.Size(279, 96);
            this.TextBoxThongTin.TabIndex = 3;
            this.TextBoxThongTin.Text = "";
            // 
            // bttSave
            // 
            this.bttSave.Location = new System.Drawing.Point(512, 415);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(119, 23);
            this.bttSave.TabIndex = 4;
            this.bttSave.Text = "Lưu thông tin";
            this.bttSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức năng của người dùng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Điện thoại liên hệ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mật khẩu:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhập lại mật khẩu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 347);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thông tin về người dùng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(276, 97);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(100, 22);
            this.txtHoTen.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(276, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(276, 202);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 22);
            this.txtSDT.TabIndex = 15;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(276, 237);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(100, 22);
            this.txtMatKhau.TabIndex = 16;
            // 
            // txtMatKhau2
            // 
            this.txtMatKhau2.Location = new System.Drawing.Point(276, 270);
            this.txtMatKhau2.Name = "txtMatKhau2";
            this.txtMatKhau2.Size = new System.Drawing.Size(100, 22);
            this.txtMatKhau2.TabIndex = 17;
            // 
            // bttBack
            // 
            this.bttBack.Location = new System.Drawing.Point(221, 415);
            this.bttBack.Name = "bttBack";
            this.bttBack.Size = new System.Drawing.Size(75, 23);
            this.bttBack.TabIndex = 18;
            this.bttBack.Text = "Quay lại";
            this.bttBack.UseVisualStyleBackColor = true;
            this.bttBack.Click += new System.EventHandler(this.bttBack_Click);
            // 
            // FrmAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttBack);
            this.Controls.Add(this.txtMatKhau2);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttSave);
            this.Controls.Add(this.TextBoxThongTin);
            this.Controls.Add(this.cbbChucNang);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label1);
            this.Name = "FrmAddUsers";
            this.Text = "FrmAddUsers";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.ComboBox cbbChucNang;
        private System.Windows.Forms.RichTextBox TextBoxThongTin;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau2;
        private System.Windows.Forms.Button bttBack;
    }
}