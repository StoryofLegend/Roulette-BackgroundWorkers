namespace _4F_Kovacev_Roulette
{
    partial class frmGioco
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
            this.bgw1 = new System.ComponentModel.BackgroundWorker();
            this.bgw2 = new System.ComponentModel.BackgroundWorker();
            this.bgw3 = new System.ComponentModel.BackgroundWorker();
            this.bgw4 = new System.ComponentModel.BackgroundWorker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtGiocatore1 = new System.Windows.Forms.TextBox();
            this.txtGiocatore3 = new System.Windows.Forms.TextBox();
            this.txtGiocatore2 = new System.Windows.Forms.TextBox();
            this.txtGiocatore4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumeroRoulette = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBudgetGioc4 = new System.Windows.Forms.TextBox();
            this.txtBudgetGioc2 = new System.Windows.Forms.TextBox();
            this.txtBudgetGioc3 = new System.Windows.Forms.TextBox();
            this.txtBudgetGioc1 = new System.Windows.Forms.TextBox();
            this.lblGiocatore1 = new System.Windows.Forms.Label();
            this.lblGiocatore2 = new System.Windows.Forms.Label();
            this.lblGiocatore3 = new System.Windows.Forms.Label();
            this.lblGiocatore4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcbRoulette = new System.Windows.Forms.PictureBox();
            this.grpGiocatori = new System.Windows.Forms.GroupBox();
            this.pcbNumeroRoulette = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoulette)).BeginInit();
            this.grpGiocatori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNumeroRoulette)).BeginInit();
            this.SuspendLayout();
            // 
            // bgw1
            // 
            this.bgw1.WorkerReportsProgress = true;
            this.bgw1.WorkerSupportsCancellation = true;
            this.bgw1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkers_DoWork);
            this.bgw1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkers_ProgressChanged);
            this.bgw1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkers_RunWorkerCompleted);
            // 
            // bgw2
            // 
            this.bgw2.WorkerReportsProgress = true;
            this.bgw2.WorkerSupportsCancellation = true;
            this.bgw2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkers_DoWork);
            this.bgw2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkers_ProgressChanged);
            this.bgw2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkers_RunWorkerCompleted);
            // 
            // bgw3
            // 
            this.bgw3.WorkerReportsProgress = true;
            this.bgw3.WorkerSupportsCancellation = true;
            this.bgw3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkers_DoWork);
            this.bgw3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkers_ProgressChanged);
            this.bgw3.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkers_RunWorkerCompleted);
            // 
            // bgw4
            // 
            this.bgw4.WorkerReportsProgress = true;
            this.bgw4.WorkerSupportsCancellation = true;
            this.bgw4.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkers_DoWork);
            this.bgw4.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkers_ProgressChanged);
            this.bgw4.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkers_RunWorkerCompleted);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImage = global::_4F_Kovacev_Roulette.Properties.Resources.sfondoroulette;
            this.btnStart.Location = new System.Drawing.Point(979, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(121, 63);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::_4F_Kovacev_Roulette.Properties.Resources.sfondoroulette;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(1117, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 63);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtGiocatore1
            // 
            this.txtGiocatore1.Location = new System.Drawing.Point(182, 43);
            this.txtGiocatore1.Name = "txtGiocatore1";
            this.txtGiocatore1.Size = new System.Drawing.Size(111, 22);
            this.txtGiocatore1.TabIndex = 3;
            // 
            // txtGiocatore3
            // 
            this.txtGiocatore3.Location = new System.Drawing.Point(741, 42);
            this.txtGiocatore3.Name = "txtGiocatore3";
            this.txtGiocatore3.Size = new System.Drawing.Size(111, 22);
            this.txtGiocatore3.TabIndex = 4;
            // 
            // txtGiocatore2
            // 
            this.txtGiocatore2.Location = new System.Drawing.Point(457, 41);
            this.txtGiocatore2.Name = "txtGiocatore2";
            this.txtGiocatore2.Size = new System.Drawing.Size(111, 22);
            this.txtGiocatore2.TabIndex = 5;
            // 
            // txtGiocatore4
            // 
            this.txtGiocatore4.Location = new System.Drawing.Point(1020, 43);
            this.txtGiocatore4.Name = "txtGiocatore4";
            this.txtGiocatore4.Size = new System.Drawing.Size(115, 22);
            this.txtGiocatore4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giocatore 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Giocatore 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(746, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Giocatore 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1027, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giocatore 4";
            // 
            // txtNumeroRoulette
            // 
            this.txtNumeroRoulette.Location = new System.Drawing.Point(1165, 154);
            this.txtNumeroRoulette.Name = "txtNumeroRoulette";
            this.txtNumeroRoulette.Size = new System.Drawing.Size(31, 22);
            this.txtNumeroRoulette.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "tipo puntata :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Budget :";
            // 
            // txtBudgetGioc4
            // 
            this.txtBudgetGioc4.Location = new System.Drawing.Point(1020, 83);
            this.txtBudgetGioc4.Name = "txtBudgetGioc4";
            this.txtBudgetGioc4.Size = new System.Drawing.Size(115, 22);
            this.txtBudgetGioc4.TabIndex = 25;
            this.txtBudgetGioc4.Text = "5000";
            this.txtBudgetGioc4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBudgetGioc2
            // 
            this.txtBudgetGioc2.Location = new System.Drawing.Point(457, 83);
            this.txtBudgetGioc2.Name = "txtBudgetGioc2";
            this.txtBudgetGioc2.Size = new System.Drawing.Size(111, 22);
            this.txtBudgetGioc2.TabIndex = 24;
            this.txtBudgetGioc2.Text = "5000";
            this.txtBudgetGioc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBudgetGioc3
            // 
            this.txtBudgetGioc3.Location = new System.Drawing.Point(741, 83);
            this.txtBudgetGioc3.Name = "txtBudgetGioc3";
            this.txtBudgetGioc3.Size = new System.Drawing.Size(111, 22);
            this.txtBudgetGioc3.TabIndex = 23;
            this.txtBudgetGioc3.Text = "5000";
            this.txtBudgetGioc3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBudgetGioc1
            // 
            this.txtBudgetGioc1.Location = new System.Drawing.Point(182, 83);
            this.txtBudgetGioc1.Name = "txtBudgetGioc1";
            this.txtBudgetGioc1.Size = new System.Drawing.Size(111, 22);
            this.txtBudgetGioc1.TabIndex = 22;
            this.txtBudgetGioc1.Text = "5000";
            this.txtBudgetGioc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGiocatore1
            // 
            this.lblGiocatore1.AutoSize = true;
            this.lblGiocatore1.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore1.Location = new System.Drawing.Point(179, 124);
            this.lblGiocatore1.Name = "lblGiocatore1";
            this.lblGiocatore1.Size = new System.Drawing.Size(13, 17);
            this.lblGiocatore1.TabIndex = 26;
            this.lblGiocatore1.Text = "-";
            // 
            // lblGiocatore2
            // 
            this.lblGiocatore2.AutoSize = true;
            this.lblGiocatore2.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore2.Location = new System.Drawing.Point(454, 123);
            this.lblGiocatore2.Name = "lblGiocatore2";
            this.lblGiocatore2.Size = new System.Drawing.Size(13, 17);
            this.lblGiocatore2.TabIndex = 27;
            this.lblGiocatore2.Text = "-";
            // 
            // lblGiocatore3
            // 
            this.lblGiocatore3.AutoSize = true;
            this.lblGiocatore3.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore3.Location = new System.Drawing.Point(738, 124);
            this.lblGiocatore3.Name = "lblGiocatore3";
            this.lblGiocatore3.Size = new System.Drawing.Size(13, 17);
            this.lblGiocatore3.TabIndex = 28;
            this.lblGiocatore3.Text = "-";
            // 
            // lblGiocatore4
            // 
            this.lblGiocatore4.AutoSize = true;
            this.lblGiocatore4.BackColor = System.Drawing.Color.Transparent;
            this.lblGiocatore4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiocatore4.Location = new System.Drawing.Point(1017, 124);
            this.lblGiocatore4.Name = "lblGiocatore4";
            this.lblGiocatore4.Size = new System.Drawing.Size(13, 17);
            this.lblGiocatore4.TabIndex = 29;
            this.lblGiocatore4.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_4F_Kovacev_Roulette.Properties.Resources.Tavolo;
            this.pictureBox1.Location = new System.Drawing.Point(362, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 317);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pcbRoulette
            // 
            this.pcbRoulette.Image = global::_4F_Kovacev_Roulette.Properties.Resources.gifroulette;
            this.pcbRoulette.Location = new System.Drawing.Point(28, 21);
            this.pcbRoulette.Name = "pcbRoulette";
            this.pcbRoulette.Size = new System.Drawing.Size(328, 317);
            this.pcbRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRoulette.TabIndex = 31;
            this.pcbRoulette.TabStop = false;
            // 
            // grpGiocatori
            // 
            this.grpGiocatori.BackgroundImage = global::_4F_Kovacev_Roulette.Properties.Resources.sfondoroulette;
            this.grpGiocatori.Controls.Add(this.txtBudgetGioc1);
            this.grpGiocatori.Controls.Add(this.txtGiocatore1);
            this.grpGiocatori.Controls.Add(this.txtGiocatore3);
            this.grpGiocatori.Controls.Add(this.lblGiocatore4);
            this.grpGiocatori.Controls.Add(this.txtGiocatore2);
            this.grpGiocatori.Controls.Add(this.lblGiocatore3);
            this.grpGiocatori.Controls.Add(this.txtGiocatore4);
            this.grpGiocatori.Controls.Add(this.lblGiocatore2);
            this.grpGiocatori.Controls.Add(this.label1);
            this.grpGiocatori.Controls.Add(this.lblGiocatore1);
            this.grpGiocatori.Controls.Add(this.label2);
            this.grpGiocatori.Controls.Add(this.txtBudgetGioc4);
            this.grpGiocatori.Controls.Add(this.label5);
            this.grpGiocatori.Controls.Add(this.txtBudgetGioc2);
            this.grpGiocatori.Controls.Add(this.label6);
            this.grpGiocatori.Controls.Add(this.txtBudgetGioc3);
            this.grpGiocatori.Controls.Add(this.label11);
            this.grpGiocatori.Controls.Add(this.label3);
            this.grpGiocatori.Location = new System.Drawing.Point(28, 365);
            this.grpGiocatori.Name = "grpGiocatori";
            this.grpGiocatori.Size = new System.Drawing.Size(1237, 160);
            this.grpGiocatori.TabIndex = 32;
            this.grpGiocatori.TabStop = false;
            this.grpGiocatori.Text = "Giocatori";
            // 
            // pcbNumeroRoulette
            // 
            this.pcbNumeroRoulette.Location = new System.Drawing.Point(1010, 182);
            this.pcbNumeroRoulette.Name = "pcbNumeroRoulette";
            this.pcbNumeroRoulette.Size = new System.Drawing.Size(165, 118);
            this.pcbNumeroRoulette.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNumeroRoulette.TabIndex = 33;
            this.pcbNumeroRoulette.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1007, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 18);
            this.label7.TabIndex = 30;
            this.label7.Text = "Numero roulette :";
            // 
            // frmGioco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_4F_Kovacev_Roulette.Properties.Resources.sfondoroulette;
            this.ClientSize = new System.Drawing.Size(1277, 548);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pcbNumeroRoulette);
            this.Controls.Add(this.grpGiocatori);
            this.Controls.Add(this.pcbRoulette);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNumeroRoulette);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Name = "frmGioco";
            this.Text = "frmGioco";
            this.Load += new System.EventHandler(this.frmGioco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRoulette)).EndInit();
            this.grpGiocatori.ResumeLayout(false);
            this.grpGiocatori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNumeroRoulette)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bgw1;
        private System.ComponentModel.BackgroundWorker bgw2;
        private System.ComponentModel.BackgroundWorker bgw3;
        private System.ComponentModel.BackgroundWorker bgw4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtGiocatore1;
        private System.Windows.Forms.TextBox txtGiocatore3;
        private System.Windows.Forms.TextBox txtGiocatore2;
        private System.Windows.Forms.TextBox txtGiocatore4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumeroRoulette;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBudgetGioc4;
        private System.Windows.Forms.TextBox txtBudgetGioc2;
        private System.Windows.Forms.TextBox txtBudgetGioc3;
        private System.Windows.Forms.TextBox txtBudgetGioc1;
        private System.Windows.Forms.Label lblGiocatore1;
        private System.Windows.Forms.Label lblGiocatore2;
        private System.Windows.Forms.Label lblGiocatore3;
        private System.Windows.Forms.Label lblGiocatore4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcbRoulette;
        private System.Windows.Forms.GroupBox grpGiocatori;
        private System.Windows.Forms.PictureBox pcbNumeroRoulette;
        private System.Windows.Forms.Label label7;
    }
}