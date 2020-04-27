namespace GestioneBanca
{
    partial class removeCC
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
            this.btnCancellaCC = new System.Windows.Forms.Button();
            this.listRemove = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Scegli CC da cancellare:";
            // 
            // btnCancellaCC
            // 
            this.btnCancellaCC.Location = new System.Drawing.Point(12, 249);
            this.btnCancellaCC.Name = "btnCancellaCC";
            this.btnCancellaCC.Size = new System.Drawing.Size(100, 42);
            this.btnCancellaCC.TabIndex = 12;
            this.btnCancellaCC.Text = "Cancella CC";
            this.btnCancellaCC.UseVisualStyleBackColor = true;
            // 
            // listRemove
            // 
            this.listRemove.FormattingEnabled = true;
            this.listRemove.Location = new System.Drawing.Point(12, 34);
            this.listRemove.Name = "listRemove";
            this.listRemove.Size = new System.Drawing.Size(156, 199);
            this.listRemove.TabIndex = 0;
            // 
            // removeCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 303);
            this.Controls.Add(this.btnCancellaCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listRemove);
            this.Name = "removeCC";
            this.Text = "removeCC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancellaCC;
        private System.Windows.Forms.ListBox listRemove;
    }
}