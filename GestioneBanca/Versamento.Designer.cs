namespace GestioneBanca
{
    partial class Versamento
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
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.btnAggiungiSoldi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Somma da mettere:";
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(116, 6);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(125, 20);
            this.txtCredito.TabIndex = 1;
            // 
            // btnAggiungiSoldi
            // 
            this.btnAggiungiSoldi.Location = new System.Drawing.Point(15, 34);
            this.btnAggiungiSoldi.Name = "btnAggiungiSoldi";
            this.btnAggiungiSoldi.Size = new System.Drawing.Size(329, 29);
            this.btnAggiungiSoldi.TabIndex = 2;
            this.btnAggiungiSoldi.Text = "Aggiungi";
            this.btnAggiungiSoldi.UseVisualStyleBackColor = true;
            this.btnAggiungiSoldi.Click += new System.EventHandler(this.BtnAggiungiSoldi_Click);
            // 
            // Versamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 68);
            this.Controls.Add(this.btnAggiungiSoldi);
            this.Controls.Add(this.txtCredito);
            this.Controls.Add(this.label1);
            this.Name = "Versamento";
            this.Text = "Versamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCredito;
        private System.Windows.Forms.Button btnAggiungiSoldi;
    }
}