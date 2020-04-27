namespace GestioneBanca
{
    partial class addCC
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.txtCreditoIniziale = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCreaCC = new System.Windows.Forms.Button();
            this.cbContoCorrenteOnline = new System.Windows.Forms.CheckBox();
            this.dtpDataNascita = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIndirizzo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(12, 123);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 1;
            // 
            // txtCreditoIniziale
            // 
            this.txtCreditoIniziale.Location = new System.Drawing.Point(12, 268);
            this.txtCreditoIniziale.Name = "txtCreditoIniziale";
            this.txtCreditoIniziale.Size = new System.Drawing.Size(100, 20);
            this.txtCreditoIniziale.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Credito iniziale";
            // 
            // btnCreaCC
            // 
            this.btnCreaCC.Location = new System.Drawing.Point(12, 305);
            this.btnCreaCC.Name = "btnCreaCC";
            this.btnCreaCC.Size = new System.Drawing.Size(100, 42);
            this.btnCreaCC.TabIndex = 11;
            this.btnCreaCC.Text = "Crea CC";
            this.btnCreaCC.UseVisualStyleBackColor = true;
            this.btnCreaCC.Click += new System.EventHandler(this.BtnCreaCC_Click);
            // 
            // cbContoCorrenteOnline
            // 
            this.cbContoCorrenteOnline.AutoSize = true;
            this.cbContoCorrenteOnline.Location = new System.Drawing.Point(12, 38);
            this.cbContoCorrenteOnline.Name = "cbContoCorrenteOnline";
            this.cbContoCorrenteOnline.Size = new System.Drawing.Size(135, 17);
            this.cbContoCorrenteOnline.TabIndex = 12;
            this.cbContoCorrenteOnline.Text = "Spuntare per CC online";
            this.cbContoCorrenteOnline.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascita
            // 
            this.dtpDataNascita.Location = new System.Drawing.Point(12, 161);
            this.dtpDataNascita.Name = "dtpDataNascita";
            this.dtpDataNascita.Size = new System.Drawing.Size(200, 20);
            this.dtpDataNascita.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data di nascita";
            // 
            // txtIndirizzo
            // 
            this.txtIndirizzo.Location = new System.Drawing.Point(12, 197);
            this.txtIndirizzo.Name = "txtIndirizzo";
            this.txtIndirizzo.Size = new System.Drawing.Size(100, 20);
            this.txtIndirizzo.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(124, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Indirizzo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "E-mail";
            // 
            // addCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 365);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIndirizzo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataNascita);
            this.Controls.Add(this.cbContoCorrenteOnline);
            this.Controls.Add(this.btnCreaCC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCreditoIniziale);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.txtNome);
            this.Name = "addCC";
            this.Text = "addCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.TextBox txtCreditoIniziale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCreaCC;
        private System.Windows.Forms.CheckBox cbContoCorrenteOnline;
        private System.Windows.Forms.DateTimePicker dtpDataNascita;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIndirizzo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
    }
}