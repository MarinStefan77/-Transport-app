using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieTransport
{
    public partial class FormRuta : Form
    {
        public Ruta RutaRezultat { get; set; }
        private Ruta _rutaExistenta;

        public FormRuta(List<Masina> masini, Ruta ruta = null)
        {
            InitializeComponent();
            _rutaExistenta = ruta;

            cbMasina.DataSource = masini;
            cbMasina.DisplayMember = "NumarInmatriculare";
            cbMasina.ValueMember = "Id";

            if (ruta != null)
            {
                txtDestinatie.Text = ruta.Destinatie;
                txtDistantaKm.Text = ruta.DistantaKm.ToString();
                cbMasina.SelectedValue = ruta.MasinaId;
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDestinatie.Text) ||
                string.IsNullOrWhiteSpace(txtDistantaKm.Text) ||
                cbMasina.SelectedItem == null)
            {
                MessageBox.Show(this, "Completeaza toate campurile!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtDistantaKm.Text, out int dist))
            {
                MessageBox.Show(this, "Distanta trebuie sa fie un numar!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            RutaRezultat = new Ruta
            {
                Id = _rutaExistenta != null ? _rutaExistenta.Id : 0,
                Destinatie = txtDestinatie.Text,
                DistantaKm = dist,
                MasinaId = (int)cbMasina.SelectedValue
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}