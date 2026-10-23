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
    public partial class FormMasina : Form
    {
        public Masina MasinaRezultat { get; set; }
        private Masina _masinaExistenta;
        private List<Masina> _masiniExistente;
        public FormMasina(List<Sofer> soferi, Masina masina = null, List<Masina> masiniExistente = null)
        {
            InitializeComponent();
            _masinaExistenta = masina;
            _masiniExistente = masiniExistente ?? new List<Masina>();

            cbSofer.DataSource = soferi;
            cbSofer.DisplayMember = "Nume";
            cbSofer.ValueMember = "Id";

            if (masina != null)
            {
                txtNrInmatriculare.Text = masina.NumarInmatriculare;
                txtMarca.Text = masina.Marca;
                cbSofer.SelectedValue = masina.SoferId;
            }
        }
        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNrInmatriculare.Text) ||
                string.IsNullOrWhiteSpace(txtMarca.Text) ||
                cbSofer.SelectedItem == null)
            {
                MessageBox.Show(this, "Completeaza toate campurile!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtNrInmatriculare.Text.Length < 6)
            {
                MessageBox.Show(this, "Numar de inmatriculare invalid!", "Atentie",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_masiniExistente != null && _masiniExistente.Count > 0)
            {
                bool duplicat = _masiniExistente.Any(m =>
                    m.NumarInmatriculare.ToLower().Trim() == txtNrInmatriculare.Text.ToLower().Trim() &&
                    m.Id != (_masinaExistenta != null ? _masinaExistenta.Id : 0));
                if (duplicat)
                {
                    MessageBox.Show(this, "Exista deja o masina cu acest numar de inmatriculare!", "Atentie",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            MasinaRezultat = new Masina
            {
                Id = _masinaExistenta != null ? _masinaExistenta.Id : 0,
                NumarInmatriculare = txtNrInmatriculare.Text,
                Marca = txtMarca.Text,
                SoferId = (int)cbSofer.SelectedValue
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
