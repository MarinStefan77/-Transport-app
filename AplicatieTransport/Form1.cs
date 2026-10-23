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
    public partial class Form1 : Form
    {
        TransportRepository repo = new TransportRepository();

        public Form1()
        {
            InitializeComponent();
            IncarcaDate();
        }
        private void IncarcaDate()
        {
            dgvSoferi.DataSource = null;
            dgvSoferi.DataSource = repo.GetSoferi();

            dgvMasini.DataSource = null;
            dgvMasini.DataSource = repo.GetMasini();

            dgvRute.DataSource = null;
            dgvRute.DataSource = repo.GetRute();

            dgvMarfa.DataSource = null;
            dgvMarfa.DataSource = repo.GetMarfa();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Aplicatie Transport";
            IncarcaDate();
        }
        private void btnAdaugaSofer_Click(object sender, EventArgs e)
        {
            FormSofer form = new FormSofer(null, repo.GetSoferi());
            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.AddSofer(form.SoferRezultat);
                IncarcaDate();
                MessageBox.Show(this, "Sofer adaugat!");
            }
        }
        private void btnAdaugaMasina_Click(object sender, EventArgs e)
        {
            FormMasina form = new FormMasina(repo.GetSoferi(), null, repo.GetMasini());
            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.AddMasina(form.MasinaRezultat);
                IncarcaDate();
                MessageBox.Show(this, "Masina adaugata!");
            }
        }
        private void btnAdaugaRuta_Click(object sender, EventArgs e)
        {
            FormRuta form = new FormRuta(repo.GetMasini());
            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.AddRuta(form.RutaRezultat);
                IncarcaDate();
                MessageBox.Show(this, "Ruta adaugata!");
            }
        }
        private void btnAdaugaMarfa_Click(object sender, EventArgs e)
        {
            FormMarfa form = new FormMarfa(repo.GetRute());
            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.AddMarfa(form.MarfaRezultat);
                IncarcaDate();
                MessageBox.Show(this, "Marfa adaugata!");
            }
        }
        private void btnStergeSofer_Click(object sender, EventArgs e)
        {
            if (dgvSoferi.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(this, "Esti sigur ca vrei sa stergi?", "Confirmare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvSoferi.SelectedRows[0].Cells["Id"].Value);
                    repo.DeleteSofer(id);
                    IncarcaDate();
                    MessageBox.Show(this, "Sters!");
                }
            }
        }
        private void btnStergeMasina_Click(object sender, EventArgs e)
        {
            if (dgvMasini.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(this, "Esti sigur ca vrei sa stergi?", "Confirmare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvMasini.SelectedRows[0].Cells["Id"].Value);
                    repo.DeleteMasina(id);
                    IncarcaDate();
                    MessageBox.Show(this, "Sters!");
                }
            }
        }
        private void btnStergeRuta_Click(object sender, EventArgs e)
        {
            if (dgvRute.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(this, "Esti sigur ca vrei sa stergi?", "Confirmare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvRute.SelectedRows[0].Cells["Id"].Value);
                    repo.DeleteRuta(id);
                    IncarcaDate();
                    MessageBox.Show(this, "Sters!");
                }
            }
        }
        private void btnStergeMarfa_Click(object sender, EventArgs e)
        {
            if (dgvMarfa.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show(this, "Esti sigur ca vrei sa stergi?", "Confirmare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvMarfa.SelectedRows[0].Cells["Id"].Value);
                    repo.DeleteMarfa(id);
                    IncarcaDate();
                    MessageBox.Show(this, "Sters!");
                }
            }
        }
        private void btnModificaSofer_Click(object sender, EventArgs e)
        {
            if (dgvSoferi.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSoferi.SelectedRows[0].Cells["Id"].Value);
                Sofer soferSelectat = repo.GetSoferi().FirstOrDefault(s => s.Id == id);
                FormSofer form = new FormSofer(soferSelectat, repo.GetSoferi());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.UpdateSofer(form.SoferRezultat);
                    IncarcaDate();
                    MessageBox.Show(this, "Modificat!");
                }
            }
        }
        private void btnModificaMasina_Click(object sender, EventArgs e)
        {
            if (dgvMasini.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMasini.SelectedRows[0].Cells["Id"].Value);
                Masina masinaSelectata = repo.GetMasini().FirstOrDefault(m => m.Id == id);
                FormMasina form = new FormMasina(repo.GetSoferi(), masinaSelectata, repo.GetMasini());
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.UpdateMasina(form.MasinaRezultat);
                    IncarcaDate();
                    MessageBox.Show(this, "Modificat!");
                }
            }
        }
        private void btnModificaRuta_Click(object sender, EventArgs e)
        {
            if (dgvRute.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRute.SelectedRows[0].Cells["Id"].Value);
                Ruta rutaSelectata = repo.GetRute().FirstOrDefault(r => r.Id == id);
                FormRuta form = new FormRuta(repo.GetMasini(), rutaSelectata);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.UpdateRuta(form.RutaRezultat);
                    IncarcaDate();
                    MessageBox.Show(this, "Modificat!");
                }
            }
        }
        private void btnModificaMarfa_Click(object sender, EventArgs e)
        {
            if (dgvMarfa.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvMarfa.SelectedRows[0].Cells["Id"].Value);
                Marfa marfaSelectata = repo.GetMarfa().FirstOrDefault(m => m.Id == id);
                FormMarfa form = new FormMarfa(repo.GetRute(), marfaSelectata);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.UpdateMarfa(form.MarfaRezultat);
                    IncarcaDate();
                    MessageBox.Show(this, "Modificat!");
                }
            }
        }
        private void btnCautaSofer_Click(object sender, EventArgs e)
        {
            string termen = txtCautaSofer.Text.ToLower();
            var rezultat = repo.GetSoferi()
                .Where(s => s.Nume.ToLower().Contains(termen))
                .ToList();
            dgvSoferi.DataSource = rezultat;
        }
        private void btnCautaMasina_Click(object sender, EventArgs e)
        {
            string termen = txtCautaMasina.Text.ToLower();
            var rezultat = repo.GetMasini()
                .Where(m => m.Marca.ToLower().Contains(termen) ||
                            m.NumarInmatriculare.ToLower().Contains(termen))
                .ToList();
            dgvMasini.DataSource = rezultat;
        }
        private void btnCautaRuta_Click(object sender, EventArgs e)
        {
            string termen = txtCautaRuta.Text.ToLower();
            var rezultat = repo.GetRute()
                .Where(r => r.Destinatie.ToLower().Contains(termen))
                .ToList();
            dgvRute.DataSource = rezultat;
        }
        private void btnCautaMarfa_Click(object sender, EventArgs e)
        {
            string termen = txtCautaMarfa.Text.ToLower();
            var rezultat = repo.GetMarfa()
                .Where(m => m.Denumire.ToLower().Contains(termen))
                .ToList();
            dgvMarfa.DataSource = rezultat;
        }
        private void btnRaport_Click(object sender, EventArgs e)
        {
            var soferi = repo.GetSoferi();
            var masini = repo.GetMasini();
            var rute = repo.GetRute();
            var marfa = repo.GetMarfa();

            double distantaTotala = rute.Sum(r => r.DistantaKm);
            double greutateTotala = marfa.Sum(m => m.GreutateKg);

            string raport =
                "=== RAPORT APLICATIE TRANSPORT ===\n\n" +
                "Total soferi: " + soferi.Count + "\n" +
                "Total masini: " + masini.Count + "\n" +
                "Total rute: " + rute.Count + "\n" +
                "Total marfuri: " + marfa.Count + "\n\n" +
                "Distanta totala: " + distantaTotala + " km\n" +
                "Greutate totala marfa: " + greutateTotala + " kg";

            MessageBox.Show(this, raport, "Raport", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}