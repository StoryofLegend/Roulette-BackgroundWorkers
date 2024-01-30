namespace ProvaRoulette
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtUtente = new System.Windows.Forms.TextBox();
            this.txtRandom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtColore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPariDispari = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDozzina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBassoAlto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColonna = new System.Windows.Forms.TextBox();
            this.btnRoulette = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.txtPuntata = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 157);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(154, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Punta";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtUtente
            // 
            this.txtUtente.Location = new System.Drawing.Point(55, 66);
            this.txtUtente.Name = "txtUtente";
            this.txtUtente.Size = new System.Drawing.Size(180, 22);
            this.txtUtente.TabIndex = 1;
            // 
            // txtRandom
            // 
            this.txtRandom.Location = new System.Drawing.Point(487, 66);
            this.txtRandom.Name = "txtRandom";
            this.txtRandom.Size = new System.Drawing.Size(139, 22);
            this.txtRandom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero random";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inserisci caratteristica numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Colore del numero";
            // 
            // txtColore
            // 
            this.txtColore.Location = new System.Drawing.Point(487, 127);
            this.txtColore.Name = "txtColore";
            this.txtColore.Size = new System.Drawing.Size(139, 22);
            this.txtColore.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pari o dispari del numero";
            // 
            // txtPariDispari
            // 
            this.txtPariDispari.Location = new System.Drawing.Point(487, 198);
            this.txtPariDispari.Name = "txtPariDispari";
            this.txtPariDispari.Size = new System.Drawing.Size(139, 22);
            this.txtPariDispari.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(490, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dozzina del numero";
            // 
            // txtDozzina
            // 
            this.txtDozzina.Location = new System.Drawing.Point(490, 265);
            this.txtDozzina.Name = "txtDozzina";
            this.txtDozzina.Size = new System.Drawing.Size(139, 22);
            this.txtDozzina.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Basso o alto del numero";
            // 
            // txtBassoAlto
            // 
            this.txtBassoAlto.Location = new System.Drawing.Point(493, 398);
            this.txtBassoAlto.Name = "txtBassoAlto";
            this.txtBassoAlto.Size = new System.Drawing.Size(139, 22);
            this.txtBassoAlto.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Colonna del numero";
            // 
            // txtColonna
            // 
            this.txtColonna.Location = new System.Drawing.Point(490, 331);
            this.txtColonna.Name = "txtColonna";
            this.txtColonna.Size = new System.Drawing.Size(139, 22);
            this.txtColonna.TabIndex = 11;
            // 
            // btnRoulette
            // 
            this.btnRoulette.Location = new System.Drawing.Point(65, 224);
            this.btnRoulette.Name = "btnRoulette";
            this.btnRoulette.Size = new System.Drawing.Size(154, 52);
            this.btnRoulette.TabIndex = 15;
            this.btnRoulette.Text = "Gira la roulette";
            this.btnRoulette.UseVisualStyleBackColor = true;
            this.btnRoulette.Click += new System.EventHandler(this.btnRoulette_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(321, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Budget";
            // 
            // txtBudget
            // 
            this.txtBudget.Location = new System.Drawing.Point(304, 66);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(100, 22);
            this.txtBudget.TabIndex = 17;
            this.txtBudget.Text = "5000";
            // 
            // txtPuntata
            // 
            this.txtPuntata.Location = new System.Drawing.Point(304, 126);
            this.txtPuntata.Name = "txtPuntata";
            this.txtPuntata.Size = new System.Drawing.Size(100, 22);
            this.txtPuntata.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(328, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Puntata";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPuntata);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRoulette);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBassoAlto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColonna);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDozzina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPariDispari);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtColore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRandom);
            this.Controls.Add(this.txtUtente);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtUtente;
        private System.Windows.Forms.TextBox txtRandom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtColore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPariDispari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDozzina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBassoAlto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColonna;
        private System.Windows.Forms.Button btnRoulette;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.TextBox txtPuntata;
        private System.Windows.Forms.Label label9;
    }
}

