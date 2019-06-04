namespace ElectionDay
{
    partial class Form2
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
            this.cbxSeggio = new System.Windows.Forms.ComboBox();
            this.cbxPartiti = new System.Windows.Forms.ComboBox();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnSaveVote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNulle = new System.Windows.Forms.TextBox();
            this.txtBianche = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPV = new System.Windows.Forms.TextBox();
            this.lblCandidato = new System.Windows.Forms.Label();
            this.btnSchede = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSeggio
            // 
            this.cbxSeggio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSeggio.FormattingEnabled = true;
            this.cbxSeggio.Location = new System.Drawing.Point(68, 36);
            this.cbxSeggio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxSeggio.Name = "cbxSeggio";
            this.cbxSeggio.Size = new System.Drawing.Size(232, 21);
            this.cbxSeggio.TabIndex = 0;
            this.cbxSeggio.DropDownClosed += new System.EventHandler(this.cbxSeggio_DropDownClosed);
            // 
            // cbxPartiti
            // 
            this.cbxPartiti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPartiti.FormattingEnabled = true;
            this.cbxPartiti.Location = new System.Drawing.Point(68, 85);
            this.cbxPartiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxPartiti.Name = "cbxPartiti";
            this.cbxPartiti.Size = new System.Drawing.Size(232, 21);
            this.cbxPartiti.TabIndex = 1;
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(60, 221);
            this.txtVoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVoto.Multiline = true;
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(104, 33);
            this.txtVoto.TabIndex = 2;
            // 
            // btnSaveVote
            // 
            this.btnSaveVote.Location = new System.Drawing.Point(60, 309);
            this.btnSaveVote.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveVote.Name = "btnSaveVote";
            this.btnSaveVote.Size = new System.Drawing.Size(104, 37);
            this.btnSaveVote.TabIndex = 3;
            this.btnSaveVote.Text = "Save Vote";
            this.btnSaveVote.UseVisualStyleBackColor = true;
            this.btnSaveVote.Click += new System.EventHandler(this.btnSaveVote_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(326, 142);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 223);
            this.textBox1.TabIndex = 4;
            // 
            // txtNulle
            // 
            this.txtNulle.Location = new System.Drawing.Point(189, 242);
            this.txtNulle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNulle.Multiline = true;
            this.txtNulle.Name = "txtNulle";
            this.txtNulle.Size = new System.Drawing.Size(104, 30);
            this.txtNulle.TabIndex = 5;
            this.txtNulle.Text = "0";
            // 
            // txtBianche
            // 
            this.txtBianche.Location = new System.Drawing.Point(189, 169);
            this.txtBianche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBianche.Multiline = true;
            this.txtBianche.Name = "txtBianche";
            this.txtBianche.Size = new System.Drawing.Size(104, 30);
            this.txtBianche.TabIndex = 6;
            this.txtBianche.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "lblBianche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "lblNulle";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(356, 37);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(185, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtPV
            // 
            this.txtPV.Location = new System.Drawing.Point(356, 76);
            this.txtPV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPV.Name = "txtPV";
            this.txtPV.ReadOnly = true;
            this.txtPV.Size = new System.Drawing.Size(185, 20);
            this.txtPV.TabIndex = 10;
            // 
            // lblCandidato
            // 
            this.lblCandidato.AutoSize = true;
            this.lblCandidato.Location = new System.Drawing.Point(93, 172);
            this.lblCandidato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCandidato.Name = "lblCandidato";
            this.lblCandidato.Size = new System.Drawing.Size(0, 13);
            this.lblCandidato.TabIndex = 11;
            this.lblCandidato.Visible = false;
            // 
            // btnSchede
            // 
            this.btnSchede.Location = new System.Drawing.Point(189, 309);
            this.btnSchede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSchede.Name = "btnSchede";
            this.btnSchede.Size = new System.Drawing.Size(104, 37);
            this.btnSchede.TabIndex = 12;
            this.btnSchede.Text = "Save Bianche e Nulle";
            this.btnSchede.UseVisualStyleBackColor = true;
            this.btnSchede.Click += new System.EventHandler(this.btnSchede_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 414);
            this.Controls.Add(this.btnSchede);
            this.Controls.Add(this.lblCandidato);
            this.Controls.Add(this.txtPV);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBianche);
            this.Controls.Add(this.txtNulle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveVote);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.cbxPartiti);
            this.Controls.Add(this.cbxSeggio);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSeggio;
        private System.Windows.Forms.ComboBox cbxPartiti;
        private System.Windows.Forms.TextBox txtVoto;
        private System.Windows.Forms.Button btnSaveVote;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNulle;
        private System.Windows.Forms.TextBox txtBianche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPV;
        private System.Windows.Forms.Label lblCandidato;
        private System.Windows.Forms.Button btnSchede;
    }
}