﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Address_Book
{
    public partial class FrmTambahData : Form
    {
        bool _result = false;
        bool _addMode = false; // true = add Item , false = edit Item
        AddressBook _addrBook = null;

        public bool Run(FrmTambahData form)
        {
            form.ShowDialog();
            return _result;
        }

        public FrmTambahData(bool addMode, AddressBook addrBook = null)
        {
            InitializeComponent();
            _addMode = addMode;
            if (addrBook != null)
            {
                _addrBook = addrBook;
                this.txtNama.Text = addrBook.Nama;
                this.txtAlamat.Text = addrBook.Alamat;
                this.txtKota.Text = addrBook.Kota;
                this.txtNoHp.Text = addrBook.NoHp;
                this.dtpTglLahir.Value = addrBook.TanggalLahir.Date;
                this.txtEmail.Text = addrBook.Email;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // validasi
            if (this.txtNama.Text.Trim() == "") // jika isian nama kosong
            {
                MessageBox.Show("Sorry, Nama wajib diisi...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNama.Focus();
            }
            else if (this.txtAlamat.Text.Trim() == "") // jika Alamat nama kosong
            {
                MessageBox.Show("Sorry, Alamat wajib diisi...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtAlamat.Focus();
            }
            else if (this.txtKota.Text.Trim() == "")// jika Kota nama kosong
            {
                MessageBox.Show("Sorry, Kota wajib diisi...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtKota.Focus();
            }
            else if (this.txtNoHp.Text.Trim() == "") // jika No HP nama kosong
            {
                MessageBox.Show("Sorry, Nomor Hp wajib diisi...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNoHp.Focus();
            }
            else if (this.txtEmail.Text.Trim() == "") // jika email nama kosong
            {
                MessageBox.Show("Sorry, Email wajib diisi...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEmail.Focus();
            }
            else
            {
                try
                {
                    // simpan data ke file
                    if (_addMode == true) // add new item
                    {
                        using (var fs = new FileStream("addressbook.csv", FileMode.Append, FileAccess.Write))
                        // var = FileStream , bisa menggunakan var / FileStream
                        // Append = untuk dapat menambah apapun di dalam file nya lagi
                        {
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                writer.WriteLine($"{txtNama.Text.Trim()};{ txtAlamat.Text.Trim()};{ txtKota.Text.Trim()};" +
                                    $"{ txtNoHp.Text.Trim()};{ dtpTglLahir.Value.ToShortDateString()};{ txtEmail.Text.Trim()}");
                            }
                        }
                    }
                    else // edit data
                    {
                        string[] fileContent = File.ReadAllLines("addressbook.csv");
                        using (FileStream fs = new FileStream("temporary.csv", FileMode.Create, FileAccess.Write))
                        {
                            using (StreamWriter writer = new StreamWriter(fs))
                            {
                                foreach (string line in fileContent)
                                {
                                    string[] arrline = line.Split(';');
                                    if (arrline[0] == _addrBook.Nama && arrline[1] == _addrBook.Alamat && arrline[2] == _addrBook.Kota && arrline[3] == _addrBook.NoHp && Convert.ToDateTime(arrline[4]).Date == _addrBook.TanggalLahir.Date && arrline[5] == _addrBook.Email)
                                    {
                                        writer.WriteLine($"{txtNama.Text.Trim()};{txtAlamat.Text.Trim()};{txtKota.Text.Trim()};{txtNoHp.Text.Trim()};{dtpTglLahir.Value.ToShortDateString()};{txtEmail.Text.Trim()}");
                                    }
                                    else
                                    {
                                        writer.WriteLine(line);
                                    }
                                }
                            }
                        }
                        File.Delete("addressbook.csv");
                        File.Move("temporary.csv", "addressbook.csv");
                    }
                    _result = true;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
        }

        private void txtNama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{tab}");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (this.txtEmail.Text.Trim() != "")
            {
                if (txtEmail.Text)
                {
                    MessageBox.Show("Sorry, data email tidak valid ...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtEmail.Clear();
                    this.txtEmail.Focus();
                }
            }
        }
    }
}
