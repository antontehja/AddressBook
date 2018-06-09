namespace Address_Book
{
    partial class FrmTambahData
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
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNoHp = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.dtpTglLahir = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(206, 13);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(272, 34);
            this.txtNama.TabIndex = 1;
            this.txtNama.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNama_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kota";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "No. Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tgl. Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(206, 255);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 34);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtNoHp
            // 
            this.txtNoHp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoHp.Location = new System.Drawing.Point(206, 153);
            this.txtNoHp.Name = "txtNoHp";
            this.txtNoHp.Size = new System.Drawing.Size(272, 34);
            this.txtNoHp.TabIndex = 4;
            // 
            // txtKota
            // 
            this.txtKota.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKota.Location = new System.Drawing.Point(206, 103);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(272, 34);
            this.txtKota.TabIndex = 3;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(206, 58);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(272, 34);
            this.txtAlamat.TabIndex = 2;
            // 
            // btnBatal
            // 
            this.btnBatal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(702, 403);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(86, 35);
            this.btnBatal.TabIndex = 8;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(557, 403);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(139, 35);
            this.btnSimpan.TabIndex = 7;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // dtpTglLahir
            // 
            this.dtpTglLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTglLahir.Location = new System.Drawing.Point(206, 207);
            this.dtpTglLahir.Name = "dtpTglLahir";
            this.dtpTglLahir.Size = new System.Drawing.Size(272, 34);
            this.dtpTglLahir.TabIndex = 5;
            // 
            // FrmTambahData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.dtpTglLahir);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtNoHp);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTambahData";
            this.Text = "Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNoHp;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.DateTimePicker dtpTglLahir;
    }
}