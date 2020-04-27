namespace GestioneBanca
{
    partial class Bonifico
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBonifico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listCC = new System.Windows.Forms.ListView();
            this.Intestazione = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iban_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEffettuaBonifico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "A";
            // 
            // txtBonifico
            // 
            this.txtBonifico.Location = new System.Drawing.Point(12, 331);
            this.txtBonifico.Name = "txtBonifico";
            this.txtBonifico.Size = new System.Drawing.Size(120, 20);
            this.txtBonifico.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importo";
            // 
            // listCC
            // 
            this.listCC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Iban_,
            this.Intestazione});
            this.listCC.FullRowSelect = true;
            this.listCC.HideSelection = false;
            this.listCC.Location = new System.Drawing.Point(12, 25);
            this.listCC.MultiSelect = false;
            this.listCC.Name = "listCC";
            this.listCC.Size = new System.Drawing.Size(328, 300);
            this.listCC.TabIndex = 6;
            this.listCC.UseCompatibleStateImageBehavior = false;
            this.listCC.View = System.Windows.Forms.View.Details;
            // 
            // Intestazione
            // 
            this.Intestazione.Text = "Intestazione";
            this.Intestazione.Width = 150;
            // 
            // Iban_
            // 
            this.Iban_.Text = "Iban";
            this.Iban_.Width = 230;
            // 
            // btnEffettuaBonifico
            // 
            this.btnEffettuaBonifico.Location = new System.Drawing.Point(12, 357);
            this.btnEffettuaBonifico.Name = "btnEffettuaBonifico";
            this.btnEffettuaBonifico.Size = new System.Drawing.Size(328, 23);
            this.btnEffettuaBonifico.TabIndex = 7;
            this.btnEffettuaBonifico.Text = "Effettua il bonifico";
            this.btnEffettuaBonifico.UseVisualStyleBackColor = true;
            this.btnEffettuaBonifico.Click += new System.EventHandler(this.BtnEffettuaBonifico_Click);
            // 
            // Bonifico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 392);
            this.Controls.Add(this.btnEffettuaBonifico);
            this.Controls.Add(this.listCC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBonifico);
            this.Controls.Add(this.label2);
            this.Name = "Bonifico";
            this.Text = "Bonifico";
            this.Load += new System.EventHandler(this.Bonifico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBonifico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listCC;
        private System.Windows.Forms.ColumnHeader Intestazione;
        private System.Windows.Forms.ColumnHeader Iban_;
        private System.Windows.Forms.Button btnEffettuaBonifico;
    }
}