namespace KiemtraBai1
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texta = new System.Windows.Forms.TextBox();
            this.textb = new System.Windows.Forms.TextBox();
            this.textc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kiemtra = new System.Windows.Forms.Button();
            this.xoa = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textKiemtra = new System.Windows.Forms.Label();
            this.textChuvi = new System.Windows.Forms.TextBox();
            this.textDientich = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(140, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào độ dài 3 cạnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(82, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cạnh a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(244, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cạnh b";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(414, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cạnh c";
            // 
            // texta
            // 
            this.texta.Location = new System.Drawing.Point(86, 160);
            this.texta.Name = "texta";
            this.texta.Size = new System.Drawing.Size(64, 20);
            this.texta.TabIndex = 4;
            // 
            // textb
            // 
            this.textb.Location = new System.Drawing.Point(248, 160);
            this.textb.Name = "textb";
            this.textb.Size = new System.Drawing.Size(64, 20);
            this.textb.TabIndex = 5;
            // 
            // textc
            // 
            this.textc.Location = new System.Drawing.Point(417, 160);
            this.textc.Name = "textc";
            this.textc.Size = new System.Drawing.Size(64, 20);
            this.textc.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(82, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kết Quả";
            // 
            // kiemtra
            // 
            this.kiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kiemtra.Location = new System.Drawing.Point(89, 260);
            this.kiemtra.Name = "kiemtra";
            this.kiemtra.Size = new System.Drawing.Size(69, 26);
            this.kiemtra.TabIndex = 8;
            this.kiemtra.Text = "Kiểm tra";
            this.kiemtra.UseVisualStyleBackColor = true;
            this.kiemtra.Click += new System.EventHandler(this.kiemtra_Click);
            // 
            // xoa
            // 
            this.xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(234, 260);
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(69, 26);
            this.xoa.TabIndex = 9;
            this.xoa.Text = "Xoá";
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.Location = new System.Drawing.Point(369, 260);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(69, 26);
            this.thoat.TabIndex = 10;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Chu vi";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Diện tích";
            this.label7.Visible = false;
            // 
            // textKiemtra
            // 
            this.textKiemtra.AutoSize = true;
            this.textKiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKiemtra.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textKiemtra.Location = new System.Drawing.Point(186, 213);
            this.textKiemtra.Name = "textKiemtra";
            this.textKiemtra.Size = new System.Drawing.Size(0, 15);
            this.textKiemtra.TabIndex = 13;
            // 
            // textChuvi
            // 
            this.textChuvi.Location = new System.Drawing.Point(211, 312);
            this.textChuvi.Name = "textChuvi";
            this.textChuvi.Size = new System.Drawing.Size(119, 20);
            this.textChuvi.TabIndex = 14;
            this.textChuvi.Visible = false;
            // 
            // textDientich
            // 
            this.textDientich.Location = new System.Drawing.Point(211, 345);
            this.textDientich.Name = "textDientich";
            this.textDientich.Size = new System.Drawing.Size(119, 20);
            this.textDientich.TabIndex = 15;
            this.textDientich.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 398);
            this.Controls.Add(this.textDientich);
            this.Controls.Add(this.textChuvi);
            this.Controls.Add(this.textKiemtra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.kiemtra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textc);
            this.Controls.Add(this.textb);
            this.Controls.Add(this.texta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texta;
        private System.Windows.Forms.TextBox textb;
        private System.Windows.Forms.TextBox textc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button kiemtra;
        private System.Windows.Forms.Button xoa;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label textKiemtra;
        private System.Windows.Forms.TextBox textChuvi;
        private System.Windows.Forms.TextBox textDientich;
    }
}

