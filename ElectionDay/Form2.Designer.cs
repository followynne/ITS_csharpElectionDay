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
            this.SuspendLayout();
            // 
            // cbxSeggio
            // 
            this.cbxSeggio.FormattingEnabled = true;
            this.cbxSeggio.Location = new System.Drawing.Point(179, 45);
            this.cbxSeggio.Name = "cbxSeggio";
            this.cbxSeggio.Size = new System.Drawing.Size(308, 24);
            this.cbxSeggio.TabIndex = 0;
            // 
            // cbxPartiti
            // 
            this.cbxPartiti.FormattingEnabled = true;
            this.cbxPartiti.Location = new System.Drawing.Point(179, 128);
            this.cbxPartiti.Name = "cbxPartiti";
            this.cbxPartiti.Size = new System.Drawing.Size(308, 24);
            this.cbxPartiti.TabIndex = 1;
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(179, 222);
            this.txtVoto.Multiline = true;
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(138, 36);
            this.txtVoto.TabIndex = 2;
            // 
            // btnSaveVote
            // 
            this.btnSaveVote.Location = new System.Drawing.Point(177, 307);
            this.btnSaveVote.Name = "btnSaveVote";
            this.btnSaveVote.Size = new System.Drawing.Size(138, 22);
            this.btnSaveVote.TabIndex = 3;
            this.btnSaveVote.Text = "Save Vote";
            this.btnSaveVote.UseVisualStyleBackColor = true;
            this.btnSaveVote.Click += new System.EventHandler(this.btnSaveVote_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 200);
            this.textBox1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveVote);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.cbxPartiti);
            this.Controls.Add(this.cbxSeggio);
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
    }
}