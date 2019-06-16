namespace ElectionDay
{
    partial class Form1
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
            this.btnNazionali = new System.Windows.Forms.Button();
            this.btnRegionali = new System.Windows.Forms.Button();
            this.btnCalcReg = new System.Windows.Forms.Button();
            this.btnCalcNaz = new System.Windows.Forms.Button();
            this.lblRegPV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNazionali
            // 
            this.btnNazionali.Location = new System.Drawing.Point(425, 74);
            this.btnNazionali.Margin = new System.Windows.Forms.Padding(4);
            this.btnNazionali.Name = "btnNazionali";
            this.btnNazionali.Size = new System.Drawing.Size(171, 83);
            this.btnNazionali.TabIndex = 0;
            this.btnNazionali.Text = "Elezioni Nazionali";
            this.btnNazionali.UseVisualStyleBackColor = true;
            this.btnNazionali.Click += new System.EventHandler(this.btnNazionali_Click);
            // 
            // btnRegionali
            // 
            this.btnRegionali.Location = new System.Drawing.Point(119, 74);
            this.btnRegionali.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegionali.Name = "btnRegionali";
            this.btnRegionali.Size = new System.Drawing.Size(184, 83);
            this.btnRegionali.TabIndex = 1;
            this.btnRegionali.Text = "Elezioni Regionali";
            this.btnRegionali.UseVisualStyleBackColor = true;
            this.btnRegionali.Click += new System.EventHandler(this.btnRegionali_Click);
            // 
            // btnCalcReg
            // 
            this.btnCalcReg.Location = new System.Drawing.Point(89, 275);
            this.btnCalcReg.Name = "btnCalcReg";
            this.btnCalcReg.Size = new System.Drawing.Size(233, 83);
            this.btnCalcReg.TabIndex = 2;
            this.btnCalcReg.Text = "Ottieni i risultati per le Regionali";
            this.btnCalcReg.UseVisualStyleBackColor = true;
            this.btnCalcReg.Click += new System.EventHandler(this.btnCalcReg_Click);
            // 
            // btnCalcNaz
            // 
            this.btnCalcNaz.Location = new System.Drawing.Point(396, 275);
            this.btnCalcNaz.Name = "btnCalcNaz";
            this.btnCalcNaz.Size = new System.Drawing.Size(233, 83);
            this.btnCalcNaz.TabIndex = 3;
            this.btnCalcNaz.Text = "Ottieni i risultati per le Nazionali";
            this.btnCalcNaz.UseVisualStyleBackColor = true;
            this.btnCalcNaz.Click += new System.EventHandler(this.btnCalcNaz_Click);
            // 
            // lblRegPV
            // 
            this.lblRegPV.AutoSize = true;
            this.lblRegPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPV.Location = new System.Drawing.Point(172, 140);
            this.lblRegPV.Name = "lblRegPV";
            this.lblRegPV.Size = new System.Drawing.Size(79, 20);
            this.lblRegPV.TabIndex = 4;
            this.lblRegPV.Text = "Piemonte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 469);
            this.Controls.Add(this.lblRegPV);
            this.Controls.Add(this.btnCalcNaz);
            this.Controls.Add(this.btnCalcReg);
            this.Controls.Add(this.btnRegionali);
            this.Controls.Add(this.btnNazionali);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNazionali;
        private System.Windows.Forms.Button btnRegionali;
        private System.Windows.Forms.Button btnCalcReg;
        private System.Windows.Forms.Button btnCalcNaz;
        private System.Windows.Forms.Label lblRegPV;
    }
}

