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
            this.components = new System.ComponentModel.Container();
            this.cbxSeggio = new System.Windows.Forms.ComboBox();
            this.cbxPartiti = new System.Windows.Forms.ComboBox();
            this.txtVoto = new System.Windows.Forms.TextBox();
            this.btnSaveVote = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNulle = new System.Windows.Forms.TextBox();
            this.txtBianche = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // cbxSeggio
            // 
            this.cbxSeggio.FormattingEnabled = true;
            this.cbxSeggio.Location = new System.Drawing.Point(94, 37);
            this.cbxSeggio.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSeggio.Name = "cbxSeggio";
            this.cbxSeggio.Size = new System.Drawing.Size(232, 21);
            this.cbxSeggio.TabIndex = 0;
            // 
            // cbxPartiti
            // 
            this.cbxPartiti.FormattingEnabled = true;
            this.cbxPartiti.Location = new System.Drawing.Point(93, 95);
            this.cbxPartiti.Margin = new System.Windows.Forms.Padding(2);
            this.cbxPartiti.Name = "cbxPartiti";
            this.cbxPartiti.Size = new System.Drawing.Size(232, 21);
            this.cbxPartiti.TabIndex = 1;
            // 
            // txtVoto
            // 
            this.txtVoto.Location = new System.Drawing.Point(93, 165);
            this.txtVoto.Margin = new System.Windows.Forms.Padding(2);
            this.txtVoto.Multiline = true;
            this.txtVoto.Name = "txtVoto";
            this.txtVoto.Size = new System.Drawing.Size(104, 33);
            this.txtVoto.TabIndex = 2;
            // 
            // btnSaveVote
            // 
            this.btnSaveVote.Location = new System.Drawing.Point(93, 270);
            this.btnSaveVote.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveVote.Name = "btnSaveVote";
            this.btnSaveVote.Size = new System.Drawing.Size(104, 27);
            this.btnSaveVote.TabIndex = 3;
            this.btnSaveVote.Text = "Save Vote";
            this.btnSaveVote.UseVisualStyleBackColor = true;
            this.btnSaveVote.Click += new System.EventHandler(this.btnSaveVote_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(296, 165);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 163);
            this.textBox1.TabIndex = 4;
            // 
            // txtNulle
            // 
            this.txtNulle.Location = new System.Drawing.Point(41, 221);
            this.txtNulle.Margin = new System.Windows.Forms.Padding(2);
            this.txtNulle.Multiline = true;
            this.txtNulle.Name = "txtNulle";
            this.txtNulle.Size = new System.Drawing.Size(104, 30);
            this.txtNulle.TabIndex = 5;
            this.txtNulle.Text = "0";
            // 
            // txtBianche
            // 
            this.txtBianche.Location = new System.Drawing.Point(175, 221);
            this.txtBianche.Margin = new System.Windows.Forms.Padding(2);
            this.txtBianche.Multiline = true;
            this.txtBianche.Name = "txtBianche";
            this.txtBianche.Size = new System.Drawing.Size(104, 30);
            this.txtBianche.TabIndex = 6;
            this.txtBianche.Text = "0";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 366);
            this.Controls.Add(this.txtBianche);
            this.Controls.Add(this.txtNulle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSaveVote);
            this.Controls.Add(this.txtVoto);
            this.Controls.Add(this.cbxPartiti);
            this.Controls.Add(this.cbxSeggio);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ToolTip toolTip1;
    }
}