 using System;
using System.Windows.Forms;

namespace AplikasiPemesananTiket
{
    public partial class FormPemesananTiket : Form
    {
        public FormPemesananTiket()
        {
            InitializeComponent();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            // Mengambil data dari inputan pengguna
            string namaPemesan = txtNamaPemesan.Text;
            string tujuan = txtTujuan.Text;
            int jumlahTiket = Convert.ToInt32(numJumlahTiket.Value);

            // Validasi input
            if (string.IsNullOrEmpty(namaPemesan) || string.IsNullOrEmpty(tujuan) || jumlahTiket <= 0)
            {
                MessageBox.Show("Harap lengkapi semua kolom input dan pastikan jumlah tiket valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proses pemesanan (misalnya, menyimpan data ke database atau menampilkan ringkasan pemesanan)
            string ringkasanPemesanan = $"Terima kasih {namaPemesan} telah memesan {jumlahTiket} tiket ke {tujuan}.";
            MessageBox.Show(ringkasanPemesanan, "Pemesanan Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset input
            ResetForm();
        }

        private void ResetForm()
        {
            txtNamaPemesan.Text = "";
            txtTujuan.Text = "";
            numJumlahTiket.Value = 0;
        }
    }
}
