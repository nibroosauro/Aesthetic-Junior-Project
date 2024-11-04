using System.Text;

namespace RestAPI
{
    public partial class Form1 : Form
    {
        List<string> listkota = new List<string>();
        public Form1()
        {
            InitializeComponent();
            listkota = Ongkir.GetKotaList();
            foreach (string kota in listkota)
            {
                tbAsal.AutoCompleteCustomSource.Add(kota);
                tbAsal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbAsal.AutoCompleteSource = AutoCompleteSource.CustomSource;

                tbTujuan.AutoCompleteCustomSource.Add(kota);
                tbTujuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                tbTujuan.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }


        private int GetIdKota(string kota)
        {
            int idKota = -1;
            idKota = Ongkir.GetIdKotaList(kota);
            return idKota;
        }

        private void TampilkanDaftar(List<string> daftarLayanan)
        {
            groupBox1.Text = "Detail Layanan";
            foreach (string layanan in daftarLayanan)
            {
                groupBox1.Text += "\n-" + layanan;
            }
        }

        private void btnCekHarga_Click(object sender, EventArgs e)
        {
            string kurir = "";
            if (rbJne.Checked)
                kurir = "jne";
            else if (rbPos.Checked)
                kurir = "pos";
            else if (rbTiki.Checked)
                kurir = "tiki";

            List<string> daftarLayanan = Ongkir.GetLayananList
                (GetIdKota(tbAsal.Text), GetIdKota(tbTujuan.Text), int.Parse(tbBerat.Text), kurir);
            TampilkanDaftar(daftarLayanan);
        }

        private void rbJne_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}