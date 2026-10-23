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
    public partial class FormSofer : Form
    {
        public Sofer SoferRezultat { get; set; }
        private Sofer _soferExistent;
        private List<Sofer> _soferiExistenti;
        public FormSofer(Sofer sofer = null, List<Sofer> soferiExistenti = null)
        {
            InitializeComponent();
            _soferExistent = sofer;
            _soferiExistenti = soferiExistenti ?? new List<Sofer>();

            if (sofer != null)
            {
                txtNume.Text = sofer.Nume;
                txtNrPermis.Text = sofer.NumarPermis;
                txtTelefon.Text = sofer.Telefon;
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text) || string.IsNullOrWhiteSpace(txtNrPermis.Text))
            {
                MessageBox.Show(this, "Completeaza toate campurile!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && txtTelefon.Text.Length != 10)
            {
                MessageBox.Show(this, "Numarul de telefon trebuie sa aiba 10 cifre!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefon.Text) && !txtTelefon.Text.All(char.IsDigit))
            {
                MessageBox.Show(this, "Numarul de telefon poate contine doar cifre!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool duplicat = _soferiExistenti.Any(s => s.NumarPermis == txtNrPermis.Text &&
               s.Id != (_soferExistent != null ? _soferExistent.Id : 0));
            if (duplicat)
            {
                MessageBox.Show(this, "Exista deja un sofer cu acest numar de permis!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SoferRezultat = new Sofer
            {
                Id = _soferExistent != null ? _soferExistent.Id : 0,
                Nume = txtNume.Text,
                NumarPermis = txtNrPermis.Text,
                Telefon = txtTelefon.Text
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
