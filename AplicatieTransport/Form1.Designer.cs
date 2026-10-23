namespace AplicatieTransport
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRaport = new System.Windows.Forms.Button();
            this.btnCautaSofer = new System.Windows.Forms.Button();
            this.txtCautaSofer = new System.Windows.Forms.TextBox();
            this.btnModificaSofer = new System.Windows.Forms.Button();
            this.btnStergeSofer = new System.Windows.Forms.Button();
            this.btnAdaugaSofer = new System.Windows.Forms.Button();
            this.dgvSoferi = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCautaMasina = new System.Windows.Forms.Button();
            this.txtCautaMasina = new System.Windows.Forms.TextBox();
            this.btnModificaMasina = new System.Windows.Forms.Button();
            this.btnStergeMasina = new System.Windows.Forms.Button();
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.dgvMasini = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtCautaRuta = new System.Windows.Forms.TextBox();
            this.btnCautaRuta = new System.Windows.Forms.Button();
            this.btnModificaRuta = new System.Windows.Forms.Button();
            this.btnStergeRuta = new System.Windows.Forms.Button();
            this.btnAdaugaRuta = new System.Windows.Forms.Button();
            this.dgvRute = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCautaMarfa = new System.Windows.Forms.Button();
            this.txtCautaMarfa = new System.Windows.Forms.TextBox();
            this.btnModificaMarfa = new System.Windows.Forms.Button();
            this.btnStergeMarfa = new System.Windows.Forms.Button();
            this.btnAdaugaMarfa = new System.Windows.Forms.Button();
            this.dgvMarfa = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoferi)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasini)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarfa)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(984, 419);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRaport);
            this.tabPage1.Controls.Add(this.btnCautaSofer);
            this.tabPage1.Controls.Add(this.txtCautaSofer);
            this.tabPage1.Controls.Add(this.btnModificaSofer);
            this.tabPage1.Controls.Add(this.btnStergeSofer);
            this.tabPage1.Controls.Add(this.btnAdaugaSofer);
            this.tabPage1.Controls.Add(this.dgvSoferi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(976, 393);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Șoferi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRaport
            // 
            this.btnRaport.Location = new System.Drawing.Point(430, 313);
            this.btnRaport.Name = "btnRaport";
            this.btnRaport.Size = new System.Drawing.Size(100, 23);
            this.btnRaport.TabIndex = 16;
            this.btnRaport.Text = "Raport";
            this.btnRaport.UseVisualStyleBackColor = true;
            this.btnRaport.Click += new System.EventHandler(this.btnRaport_Click);
            // 
            // btnCautaSofer
            // 
            this.btnCautaSofer.Location = new System.Drawing.Point(860, 228);
            this.btnCautaSofer.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautaSofer.Name = "btnCautaSofer";
            this.btnCautaSofer.Size = new System.Drawing.Size(60, 21);
            this.btnCautaSofer.TabIndex = 15;
            this.btnCautaSofer.Text = "Cauta";
            this.btnCautaSofer.UseVisualStyleBackColor = true;
            this.btnCautaSofer.Click += new System.EventHandler(this.btnCautaSofer_Click);
            // 
            // txtCautaSofer
            // 
            this.txtCautaSofer.Location = new System.Drawing.Point(700, 230);
            this.txtCautaSofer.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautaSofer.Name = "txtCautaSofer";
            this.txtCautaSofer.Size = new System.Drawing.Size(114, 20);
            this.txtCautaSofer.TabIndex = 14;
            // 
            // btnModificaSofer
            // 
            this.btnModificaSofer.ForeColor = System.Drawing.Color.Blue;
            this.btnModificaSofer.Location = new System.Drawing.Point(305, 240);
            this.btnModificaSofer.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaSofer.Name = "btnModificaSofer";
            this.btnModificaSofer.Size = new System.Drawing.Size(100, 23);
            this.btnModificaSofer.TabIndex = 13;
            this.btnModificaSofer.Text = "Modifică Șofer";
            this.btnModificaSofer.UseVisualStyleBackColor = true;
            this.btnModificaSofer.Click += new System.EventHandler(this.btnModificaSofer_Click);
            // 
            // btnStergeSofer
            // 
            this.btnStergeSofer.ForeColor = System.Drawing.Color.Red;
            this.btnStergeSofer.Location = new System.Drawing.Point(483, 240);
            this.btnStergeSofer.Name = "btnStergeSofer";
            this.btnStergeSofer.Size = new System.Drawing.Size(100, 23);
            this.btnStergeSofer.TabIndex = 12;
            this.btnStergeSofer.Text = "Șterge Șofer";
            this.btnStergeSofer.UseVisualStyleBackColor = true;
            this.btnStergeSofer.Click += new System.EventHandler(this.btnStergeSofer_Click);
            // 
            // btnAdaugaSofer
            // 
            this.btnAdaugaSofer.Location = new System.Drawing.Point(123, 240);
            this.btnAdaugaSofer.Name = "btnAdaugaSofer";
            this.btnAdaugaSofer.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaSofer.TabIndex = 11;
            this.btnAdaugaSofer.Text = "Adaugă Șofer";
            this.btnAdaugaSofer.UseVisualStyleBackColor = true;
            this.btnAdaugaSofer.Click += new System.EventHandler(this.btnAdaugaSofer_Click);
            // 
            // dgvSoferi
            // 
            this.dgvSoferi.AllowUserToOrderColumns = true;
            this.dgvSoferi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSoferi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSoferi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSoferi.Location = new System.Drawing.Point(-2, 0);
            this.dgvSoferi.Name = "dgvSoferi";
            this.dgvSoferi.RowHeadersWidth = 51;
            this.dgvSoferi.Size = new System.Drawing.Size(982, 175);
            this.dgvSoferi.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCautaMasina);
            this.tabPage2.Controls.Add(this.txtCautaMasina);
            this.tabPage2.Controls.Add(this.btnModificaMasina);
            this.tabPage2.Controls.Add(this.btnStergeMasina);
            this.tabPage2.Controls.Add(this.btnAdaugaMasina);
            this.tabPage2.Controls.Add(this.dgvMasini);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(976, 393);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mașini";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCautaMasina
            // 
            this.btnCautaMasina.Location = new System.Drawing.Point(860, 228);
            this.btnCautaMasina.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautaMasina.Name = "btnCautaMasina";
            this.btnCautaMasina.Size = new System.Drawing.Size(60, 21);
            this.btnCautaMasina.TabIndex = 17;
            this.btnCautaMasina.Text = "Cauta";
            this.btnCautaMasina.UseVisualStyleBackColor = true;
            this.btnCautaMasina.Click += new System.EventHandler(this.btnCautaMasina_Click);
            // 
            // txtCautaMasina
            // 
            this.txtCautaMasina.Location = new System.Drawing.Point(700, 230);
            this.txtCautaMasina.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautaMasina.Name = "txtCautaMasina";
            this.txtCautaMasina.Size = new System.Drawing.Size(114, 20);
            this.txtCautaMasina.TabIndex = 16;
            // 
            // btnModificaMasina
            // 
            this.btnModificaMasina.ForeColor = System.Drawing.Color.Blue;
            this.btnModificaMasina.Location = new System.Drawing.Point(305, 240);
            this.btnModificaMasina.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaMasina.Name = "btnModificaMasina";
            this.btnModificaMasina.Size = new System.Drawing.Size(100, 23);
            this.btnModificaMasina.TabIndex = 14;
            this.btnModificaMasina.Text = "Modifică Mașină";
            this.btnModificaMasina.UseVisualStyleBackColor = true;
            this.btnModificaMasina.Click += new System.EventHandler(this.btnModificaMasina_Click);
            // 
            // btnStergeMasina
            // 
            this.btnStergeMasina.ForeColor = System.Drawing.Color.Red;
            this.btnStergeMasina.Location = new System.Drawing.Point(483, 240);
            this.btnStergeMasina.Name = "btnStergeMasina";
            this.btnStergeMasina.Size = new System.Drawing.Size(100, 23);
            this.btnStergeMasina.TabIndex = 8;
            this.btnStergeMasina.Text = "Șterge Mașină";
            this.btnStergeMasina.UseVisualStyleBackColor = true;
            this.btnStergeMasina.Click += new System.EventHandler(this.btnStergeMasina_Click);
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.Location = new System.Drawing.Point(123, 240);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaMasina.TabIndex = 7;
            this.btnAdaugaMasina.Text = "Adaugă Mașină";
            this.btnAdaugaMasina.UseVisualStyleBackColor = true;
            this.btnAdaugaMasina.Click += new System.EventHandler(this.btnAdaugaMasina_Click);
            // 
            // dgvMasini
            // 
            this.dgvMasini.AllowUserToOrderColumns = true;
            this.dgvMasini.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMasini.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasini.Location = new System.Drawing.Point(-2, 0);
            this.dgvMasini.Name = "dgvMasini";
            this.dgvMasini.RowHeadersWidth = 51;
            this.dgvMasini.Size = new System.Drawing.Size(982, 175);
            this.dgvMasini.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtCautaRuta);
            this.tabPage3.Controls.Add(this.btnCautaRuta);
            this.tabPage3.Controls.Add(this.btnModificaRuta);
            this.tabPage3.Controls.Add(this.btnStergeRuta);
            this.tabPage3.Controls.Add(this.btnAdaugaRuta);
            this.tabPage3.Controls.Add(this.dgvRute);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(976, 393);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rute";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtCautaRuta
            // 
            this.txtCautaRuta.Location = new System.Drawing.Point(700, 230);
            this.txtCautaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautaRuta.Name = "txtCautaRuta";
            this.txtCautaRuta.Size = new System.Drawing.Size(114, 20);
            this.txtCautaRuta.TabIndex = 12;
            // 
            // btnCautaRuta
            // 
            this.btnCautaRuta.Location = new System.Drawing.Point(860, 228);
            this.btnCautaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautaRuta.Name = "btnCautaRuta";
            this.btnCautaRuta.Size = new System.Drawing.Size(60, 21);
            this.btnCautaRuta.TabIndex = 11;
            this.btnCautaRuta.Text = "Cauta";
            this.btnCautaRuta.UseVisualStyleBackColor = true;
            this.btnCautaRuta.Click += new System.EventHandler(this.btnCautaRuta_Click);
            // 
            // btnModificaRuta
            // 
            this.btnModificaRuta.ForeColor = System.Drawing.Color.Blue;
            this.btnModificaRuta.Location = new System.Drawing.Point(305, 240);
            this.btnModificaRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaRuta.Name = "btnModificaRuta";
            this.btnModificaRuta.Size = new System.Drawing.Size(100, 23);
            this.btnModificaRuta.TabIndex = 9;
            this.btnModificaRuta.Text = "Modifică Rută";
            this.btnModificaRuta.UseVisualStyleBackColor = true;
            this.btnModificaRuta.Click += new System.EventHandler(this.btnModificaRuta_Click);
            // 
            // btnStergeRuta
            // 
            this.btnStergeRuta.ForeColor = System.Drawing.Color.Red;
            this.btnStergeRuta.Location = new System.Drawing.Point(483, 240);
            this.btnStergeRuta.Name = "btnStergeRuta";
            this.btnStergeRuta.Size = new System.Drawing.Size(100, 23);
            this.btnStergeRuta.TabIndex = 8;
            this.btnStergeRuta.Text = "Șterge Rută";
            this.btnStergeRuta.UseVisualStyleBackColor = true;
            this.btnStergeRuta.Click += new System.EventHandler(this.btnStergeRuta_Click);
            // 
            // btnAdaugaRuta
            // 
            this.btnAdaugaRuta.Location = new System.Drawing.Point(123, 240);
            this.btnAdaugaRuta.Name = "btnAdaugaRuta";
            this.btnAdaugaRuta.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaRuta.TabIndex = 7;
            this.btnAdaugaRuta.Text = "Adaugă Rută";
            this.btnAdaugaRuta.UseVisualStyleBackColor = true;
            this.btnAdaugaRuta.Click += new System.EventHandler(this.btnAdaugaRuta_Click);
            // 
            // dgvRute
            // 
            this.dgvRute.AllowUserToOrderColumns = true;
            this.dgvRute.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRute.Location = new System.Drawing.Point(-4, 0);
            this.dgvRute.Name = "dgvRute";
            this.dgvRute.RowHeadersWidth = 51;
            this.dgvRute.Size = new System.Drawing.Size(982, 175);
            this.dgvRute.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCautaMarfa);
            this.tabPage4.Controls.Add(this.txtCautaMarfa);
            this.tabPage4.Controls.Add(this.btnModificaMarfa);
            this.tabPage4.Controls.Add(this.btnStergeMarfa);
            this.tabPage4.Controls.Add(this.btnAdaugaMarfa);
            this.tabPage4.Controls.Add(this.dgvMarfa);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(976, 393);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Marfă";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCautaMarfa
            // 
            this.btnCautaMarfa.Location = new System.Drawing.Point(860, 228);
            this.btnCautaMarfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnCautaMarfa.Name = "btnCautaMarfa";
            this.btnCautaMarfa.Size = new System.Drawing.Size(60, 21);
            this.btnCautaMarfa.TabIndex = 13;
            this.btnCautaMarfa.Text = "Cauta";
            this.btnCautaMarfa.UseVisualStyleBackColor = true;
            this.btnCautaMarfa.Click += new System.EventHandler(this.btnCautaMarfa_Click);
            // 
            // txtCautaMarfa
            // 
            this.txtCautaMarfa.Location = new System.Drawing.Point(700, 230);
            this.txtCautaMarfa.Margin = new System.Windows.Forms.Padding(2);
            this.txtCautaMarfa.Name = "txtCautaMarfa";
            this.txtCautaMarfa.Size = new System.Drawing.Size(114, 20);
            this.txtCautaMarfa.TabIndex = 12;
            // 
            // btnModificaMarfa
            // 
            this.btnModificaMarfa.ForeColor = System.Drawing.Color.Blue;
            this.btnModificaMarfa.Location = new System.Drawing.Point(305, 240);
            this.btnModificaMarfa.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaMarfa.Name = "btnModificaMarfa";
            this.btnModificaMarfa.Size = new System.Drawing.Size(100, 23);
            this.btnModificaMarfa.TabIndex = 10;
            this.btnModificaMarfa.Text = "Modifică Marfă";
            this.btnModificaMarfa.UseVisualStyleBackColor = true;
            this.btnModificaMarfa.Click += new System.EventHandler(this.btnModificaMarfa_Click);
            // 
            // btnStergeMarfa
            // 
            this.btnStergeMarfa.ForeColor = System.Drawing.Color.Red;
            this.btnStergeMarfa.Location = new System.Drawing.Point(483, 240);
            this.btnStergeMarfa.Name = "btnStergeMarfa";
            this.btnStergeMarfa.Size = new System.Drawing.Size(100, 23);
            this.btnStergeMarfa.TabIndex = 9;
            this.btnStergeMarfa.Text = "Șterge Marfă";
            this.btnStergeMarfa.UseVisualStyleBackColor = true;
            this.btnStergeMarfa.Click += new System.EventHandler(this.btnStergeMarfa_Click);
            // 
            // btnAdaugaMarfa
            // 
            this.btnAdaugaMarfa.Location = new System.Drawing.Point(123, 240);
            this.btnAdaugaMarfa.Name = "btnAdaugaMarfa";
            this.btnAdaugaMarfa.Size = new System.Drawing.Size(100, 23);
            this.btnAdaugaMarfa.TabIndex = 7;
            this.btnAdaugaMarfa.Text = "Adaugă Marfă";
            this.btnAdaugaMarfa.UseVisualStyleBackColor = true;
            this.btnAdaugaMarfa.Click += new System.EventHandler(this.btnAdaugaMarfa_Click);
            // 
            // dgvMarfa
            // 
            this.dgvMarfa.AllowUserToOrderColumns = true;
            this.dgvMarfa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMarfa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMarfa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarfa.Location = new System.Drawing.Point(-4, 0);
            this.dgvMarfa.Name = "dgvMarfa";
            this.dgvMarfa.RowHeadersWidth = 51;
            this.dgvMarfa.Size = new System.Drawing.Size(982, 175);
            this.dgvMarfa.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 422);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSoferi)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasini)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRute)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarfa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAdaugaSofer;
        private System.Windows.Forms.DataGridView dgvSoferi;
        private System.Windows.Forms.DataGridView dgvMasini;
        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvRute;
        private System.Windows.Forms.Button btnAdaugaRuta;
        private System.Windows.Forms.DataGridView dgvMarfa;
        private System.Windows.Forms.Button btnAdaugaMarfa;
        private System.Windows.Forms.Button btnStergeSofer;
        private System.Windows.Forms.Button btnStergeMasina;
        private System.Windows.Forms.Button btnStergeRuta;
        private System.Windows.Forms.Button btnStergeMarfa;
        private System.Windows.Forms.Button btnModificaSofer;
        private System.Windows.Forms.Button btnModificaMasina;
        private System.Windows.Forms.Button btnModificaRuta;
        private System.Windows.Forms.Button btnModificaMarfa;
        private System.Windows.Forms.TextBox txtCautaSofer;
        private System.Windows.Forms.Button btnCautaSofer;
        private System.Windows.Forms.Button btnCautaMasina;
        private System.Windows.Forms.TextBox txtCautaMasina;
        private System.Windows.Forms.TextBox txtCautaRuta;
        private System.Windows.Forms.Button btnCautaRuta;
        private System.Windows.Forms.Button btnCautaMarfa;
        private System.Windows.Forms.TextBox txtCautaMarfa;
        private System.Windows.Forms.Button btnRaport;
    }
}

