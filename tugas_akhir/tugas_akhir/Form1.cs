using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_akhir
{
    public partial class Form1 : Form
    {
        private string nama_pembeli;
        private string merk_beli;
        private string ukuran_beli;
        private string warna_beli;
        private string jumlah_beli;
        private int hargatotal;

        // Method Setter
        public void setNama(string val)
        {
            this.nama_pembeli = val;
        }

        // Method Getter
        public string getNama()
        {
            return nama_pembeli;
        }

        public Form1()
        {
            InitializeComponent();
        }

        // Method Tombol Proses
        private void proses_Click(object sender, EventArgs e)
        {
            // Set Nilai
            string nama_pmbl = nama.Text;
            setNama(nama_pmbl);
            merk_beli = merk.Text;
            ukuran_beli = ukuran.Text;
            warna_beli = warna.Text;
            jumlah_beli = jumlah.Text;

            // Keluaran
            label1.Text = getNama();
            label2.Text = merk_beli;
            label3.Text = ukuran_beli;
            label4.Text = warna_beli;
            label5.Text = jumlah_beli;

            // Total Harga
            perhitungan();
            string hrgtotal = Convert.ToString(hargatotal);
            label6.Text = hrgtotal;
        }

        // Method Perhitungan
        public int perhitungan()
        {
            int jmlh = Convert.ToInt32(jumlah_beli);
            int[] hargabrng = { 
                700000, 800000, 900000, 1000000, 1100000, 1200000, 1300000, 1400000
            };
            for (int i = 0; i < hargabrng.Length; i++) {
                if (ukuran.SelectedIndex == i)
                {
                    hargatotal = hargabrng[i] * jmlh;
                }
            }
            return hargatotal;
        }

        // Method Tombol Reset
        private void reset_Click(object sender, EventArgs e)
        {
            nama.Text = "";
            merk.Text = "";
            ukuran.Text = "";
            warna.Text = "";
            jumlah.Text = "";

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
        }
    }
}
