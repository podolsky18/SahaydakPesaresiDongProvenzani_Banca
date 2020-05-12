namespace GestioneBanca
{
    partial class Banca
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddCC = new System.Windows.Forms.Button();
            this.removeCC = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListaVersamenti = new System.Windows.Forms.Button();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.addSoldi = new System.Windows.Forms.Button();
            this.rmvSoldi = new System.Windows.Forms.Button();
            this.btnBonifico = new System.Windows.Forms.Button();
            this.listCC = new System.Windows.Forms.ListView();
            this.Iban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Intestazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddCC
            // 
            this.AddCC.Location = new System.Drawing.Point(30, 31);
            this.AddCC.Name = "AddCC";
            this.AddCC.Size = new System.Drawing.Size(150, 50);
            this.AddCC.TabIndex = 0;
            this.AddCC.Text = "Crea CC";
            this.AddCC.UseVisualStyleBackColor = true;
            this.AddCC.Click += new System.EventHandler(this.Button1_Click);
            // 
            // removeCC
            // 
            this.removeCC.Location = new System.Drawing.Point(30, 111);
            this.removeCC.Name = "removeCC";
            this.removeCC.Size = new System.Drawing.Size(150, 50);
            this.removeCC.TabIndex = 1;
            this.removeCC.Text = "Cancella CC";
            this.removeCC.UseVisualStyleBackColor = true;
            this.removeCC.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.AddCC);
            this.groupBox1.Controls.Add(this.removeCC);
            this.groupBox1.Location = new System.Drawing.Point(305, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 244);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Banca";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "Lista Versamenti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListaVersamenti);
            this.groupBox2.Controls.Add(this.btnSaldo);
            this.groupBox2.Controls.Add(this.addSoldi);
            this.groupBox2.Controls.Add(this.rmvSoldi);
            this.groupBox2.Location = new System.Drawing.Point(305, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conto Corrente";
            // 
            // btnListaVersamenti
            // 
            this.btnListaVersamenti.Location = new System.Drawing.Point(30, 167);
            this.btnListaVersamenti.Name = "btnListaVersamenti";
            this.btnListaVersamenti.Size = new System.Drawing.Size(144, 30);
            this.btnListaVersamenti.TabIndex = 8;
            this.btnListaVersamenti.Text = "Lista Versamenti";
            this.btnListaVersamenti.UseVisualStyleBackColor = true;
            this.btnListaVersamenti.Click += new System.EventHandler(this.BtnListaVersamenti_Click);
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(30, 120);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(144, 30);
            this.btnSaldo.TabIndex = 7;
            this.btnSaldo.Text = "Stato";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.BtnSaldo_Click);
            // 
            // addSoldi
            // 
            this.addSoldi.Location = new System.Drawing.Point(30, 26);
            this.addSoldi.Name = "addSoldi";
            this.addSoldi.Size = new System.Drawing.Size(144, 30);
            this.addSoldi.TabIndex = 0;
            this.addSoldi.Text = "Versamento";
            this.addSoldi.UseVisualStyleBackColor = true;
            this.addSoldi.Click += new System.EventHandler(this.AddSoldi_Click);
            // 
            // rmvSoldi
            // 
            this.rmvSoldi.Location = new System.Drawing.Point(30, 71);
            this.rmvSoldi.Name = "rmvSoldi";
            this.rmvSoldi.Size = new System.Drawing.Size(144, 30);
            this.rmvSoldi.TabIndex = 1;
            this.rmvSoldi.Text = "Prelievo";
            this.rmvSoldi.UseVisualStyleBackColor = true;
            this.rmvSoldi.Click += new System.EventHandler(this.RmvSoldi_Click);
            // 
            // btnBonifico
            // 
            this.btnBonifico.Location = new System.Drawing.Point(305, 491);
            this.btnBonifico.Name = "btnBonifico";
            this.btnBonifico.Size = new System.Drawing.Size(209, 76);
            this.btnBonifico.TabIndex = 4;
            this.btnBonifico.Text = "Bonifico";
            this.btnBonifico.UseVisualStyleBackColor = true;
            this.btnBonifico.Click += new System.EventHandler(this.BtnBonifico_Click);
            // 
            // listCC
            // 
            this.listCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Iban,
            this.Intestazione});
            this.listCC.FullRowSelect = true;
            this.listCC.HideSelection = false;
            this.listCC.Location = new System.Drawing.Point(15, 31);
            this.listCC.MultiSelect = false;
            this.listCC.Name = "listCC";
            this.listCC.Size = new System.Drawing.Size(282, 536);
            this.listCC.TabIndex = 5;
            this.listCC.UseCompatibleStateImageBehavior = false;
            this.listCC.View = System.Windows.Forms.View.Details;
            // 
            // Iban
            // 
            this.Iban.Text = "Iban";
            this.Iban.Width = 198;
            // 
            // Intestazione
            // 
            this.Intestazione.Text = "Intestazione";
            this.Intestazione.Width = 170;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elenco CC";
            // 
            // Banca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 579);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCC);
            this.Controls.Add(this.btnBonifico);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banca";
            this.Text = "Gestione Banca";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCC;
        private System.Windows.Forms.Button removeCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addSoldi;
        private System.Windows.Forms.Button rmvSoldi;
        private System.Windows.Forms.Button btnBonifico;
        private System.Windows.Forms.ListView listCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.ColumnHeader Iban;
        private System.Windows.Forms.ColumnHeader Intestazione;
        private System.Windows.Forms.Button btnListaVersamenti;
        private System.Windows.Forms.Button button1;
    }
}

