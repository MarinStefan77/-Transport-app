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
    public partial class FormMarfa : Form
    {
        public Marfa MarfaRezultat { get; set; }
        private Marfa _marfaExistenta;

        public FormMarfa(List<Ruta> rute, Marfa marfa = null)
        {
            InitializeComponent();
            _marfaExistenta = marfa;

            cbRuta.DataSource = rute;
            cbRuta.DisplayMember = "Destinatie";
            cbRuta.ValueMember = "Id";

            if (marfa != null)
            {
                txtDenumire.Text = marfa.Denumire;
                txtGreutateKg.Text = marfa.GreutateKg.ToString();
                cbRuta.SelectedValue = marfa.RutaId;
            }
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDenumire.Text) ||
                string.IsNullOrWhiteSpace(txtGreutateKg.Text) ||
                cbRuta.SelectedItem == null)
            {
                MessageBox.Show(this, "Completeaza toate campurile!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtGreutateKg.Text, out double gr))
            {
                MessageBox.Show(this, "Greutatea trebuie sa fie un numar!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MarfaRezultat = new Marfa
            {
                Id = _marfaExistenta != null ? _marfaExistenta.Id : 0,
                Denumire = txtDenumire.Text,
                GreutateKg = gr,
                RutaId = (int)cbRuta.SelectedValue
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
