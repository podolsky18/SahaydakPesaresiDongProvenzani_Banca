namespace GestioneBanca
{
    partial class ListaVersamentiBanca
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listMovimenti = new System.Windows.Forms.ListView();
            this.Iban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoMovimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Importo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbDateMovimenti = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo e\' di:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoEllipsis = true;
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(77, 9);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 13);
            this.lblSaldo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listMovimenti);
            this.groupBox1.Location = new System.Drawing.Point(15, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 243);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MovimentI del CC:";
            // 
            // listMovimenti
            // 
            this.listMovimenti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Iban,
            this.Data,
            this.TipoMovimento,
            this.Importo});
            this.listMovimenti.HideSelection = false;
            this.listMovimenti.Location = new System.Drawing.Point(6, 19);
            this.listMovimenti.Name = "listMovimenti";
            this.listMovimenti.Size = new System.Drawing.Size(648, 208);
            this.listMovimenti.TabIndex = 0;
            this.listMovimenti.UseCompatibleStateImageBehavior = false;
            this.listMovimenti.View = System.Windows.Forms.View.Details;
            // 
            // Iban
            // 
            this.Iban.Text = "Iban";
            this.Iban.Width = 293;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 111;
            // 
            // TipoMovimento
            // 
            this.TipoMovimento.Text = "Tipo movimento";
            this.TipoMovimento.Width = 174;
            // 
            // Importo
            // 
            this.Importo.Text = "Importo";
            this.Importo.Width = 83;
            // 
            // cbDateMovimenti
            // 
            this.cbDateMovimenti.FormattingEnabled = true;
            this.cbDateMovimenti.Location = new System.Drawing.Point(220, 6);
            this.cbDateMovimenti.Name = "cbDateMovimenti";
            this.cbDateMovimenti.Size = new System.Drawing.Size(121, 21);
            this.cbDateMovimenti.TabIndex = 3;
            this.cbDateMovimenti.SelectedIndexChanged += new System.EventHandler(this.CbDateMovimenti_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seleziona la data dei movimenti giornalieri:";
            // 
            // ListaVersamentiBanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 327);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDateMovimenti);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.label1);
            this.Name = "ListaVersamentiBanca";
            this.Text = "ListaVersamentiBanca";
            this.Load += new System.EventHandler(this.ListaVersamentiBanca_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listMovimenti;
        private System.Windows.Forms.ColumnHeader TipoMovimento;
        private System.Windows.Forms.ColumnHeader Importo;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ComboBox cbDateMovimenti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Iban;
    }
}