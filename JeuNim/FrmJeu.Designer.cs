namespace JeuNim
{
    partial class FrmJeu
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
            components = new System.ComponentModel.Container();
            labelNombreBaton = new Label();
            buttonEnleverBaton = new Button();
            labelBatonsAEnlever = new Label();
            numericBatonARetirer = new NumericUpDown();
            timerRefreshDonnee = new System.Windows.Forms.Timer(components);
            buttonAbandonner = new Button();
            labelAdversaire = new Label();
            labelNomAdversaire = new Label();
            labelNumPar = new Label();
            labelNumeroPartie = new Label();
            buttonQuitter = new Button();
            ((System.ComponentModel.ISupportInitialize)numericBatonARetirer).BeginInit();
            SuspendLayout();
            // 
            // labelNombreBaton
            // 
            labelNombreBaton.AutoSize = true;
            labelNombreBaton.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNombreBaton.Location = new Point(490, 88);
            labelNombreBaton.MaximumSize = new Size(200, 150);
            labelNombreBaton.Name = "labelNombreBaton";
            labelNombreBaton.Size = new Size(173, 129);
            labelNombreBaton.TabIndex = 1;
            labelNombreBaton.Text = "Nombre de bâtons";
            labelNombreBaton.TextAlign = ContentAlignment.TopCenter;
            // 
            // buttonEnleverBaton
            // 
            buttonEnleverBaton.BackColor = Color.FromArgb(128, 64, 0);
            buttonEnleverBaton.Enabled = false;
            buttonEnleverBaton.ForeColor = Color.Transparent;
            buttonEnleverBaton.Location = new Point(490, 451);
            buttonEnleverBaton.Margin = new Padding(3, 4, 3, 4);
            buttonEnleverBaton.Name = "buttonEnleverBaton";
            buttonEnleverBaton.Size = new Size(167, 69);
            buttonEnleverBaton.TabIndex = 2;
            buttonEnleverBaton.Text = "Enlever";
            buttonEnleverBaton.UseVisualStyleBackColor = false;
            buttonEnleverBaton.Click += buttonEnleverBaton_Click;
            // 
            // labelBatonsAEnlever
            // 
            labelBatonsAEnlever.AutoSize = true;
            labelBatonsAEnlever.BackColor = Color.Transparent;
            labelBatonsAEnlever.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelBatonsAEnlever.ForeColor = SystemColors.ControlLightLight;
            labelBatonsAEnlever.Location = new Point(425, 325);
            labelBatonsAEnlever.Name = "labelBatonsAEnlever";
            labelBatonsAEnlever.Size = new Size(301, 23);
            labelBatonsAEnlever.TabIndex = 3;
            labelBatonsAEnlever.Text = "Nombre de bâtons à retirer";
            // 
            // numericBatonARetirer
            // 
            numericBatonARetirer.Enabled = false;
            numericBatonARetirer.Location = new Point(490, 377);
            numericBatonARetirer.Margin = new Padding(3, 4, 3, 4);
            numericBatonARetirer.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericBatonARetirer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericBatonARetirer.Name = "numericBatonARetirer";
            numericBatonARetirer.Size = new Size(167, 27);
            numericBatonARetirer.TabIndex = 4;
            numericBatonARetirer.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // timerRefreshDonnee
            // 
            timerRefreshDonnee.Interval = 1000;
            timerRefreshDonnee.Tick += timerRefreshDonnee_Tick;
            // 
            // buttonAbandonner
            // 
            buttonAbandonner.BackColor = Color.FromArgb(128, 64, 0);
            buttonAbandonner.ForeColor = Color.White;
            buttonAbandonner.Location = new Point(940, 13);
            buttonAbandonner.Margin = new Padding(3, 4, 3, 4);
            buttonAbandonner.Name = "buttonAbandonner";
            buttonAbandonner.Size = new Size(148, 78);
            buttonAbandonner.TabIndex = 5;
            buttonAbandonner.Text = "Abandonner";
            buttonAbandonner.UseVisualStyleBackColor = false;
            buttonAbandonner.Click += buttonAbandonner_Click;
            // 
            // labelAdversaire
            // 
            labelAdversaire.AutoSize = true;
            labelAdversaire.Location = new Point(388, 42);
            labelAdversaire.Name = "labelAdversaire";
            labelAdversaire.Size = new Size(86, 20);
            labelAdversaire.TabIndex = 6;
            labelAdversaire.Text = "Adversaire :";
            // 
            // labelNomAdversaire
            // 
            labelNomAdversaire.AutoSize = true;
            labelNomAdversaire.Location = new Point(480, 42);
            labelNomAdversaire.Name = "labelNomAdversaire";
            labelNomAdversaire.Size = new Size(193, 20);
            labelNomAdversaire.TabIndex = 7;
            labelNomAdversaire.Text = "En attente d'un adversaire ...";
            // 
            // labelNumPar
            // 
            labelNumPar.AutoSize = true;
            labelNumPar.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumPar.Location = new Point(14, 8);
            labelNumPar.Name = "labelNumPar";
            labelNumPar.Size = new Size(158, 18);
            labelNumPar.TabIndex = 8;
            labelNumPar.Text = "Numéro de partie :";
            // 
            // labelNumeroPartie
            // 
            labelNumeroPartie.AutoSize = true;
            labelNumeroPartie.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelNumeroPartie.Location = new Point(178, 8);
            labelNumeroPartie.Name = "labelNumeroPartie";
            labelNumeroPartie.Size = new Size(70, 18);
            labelNumeroPartie.TabIndex = 9;
            labelNumeroPartie.Text = "NPartie";
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.FromArgb(128, 64, 0);
            buttonQuitter.ForeColor = Color.White;
            buttonQuitter.Location = new Point(982, 504);
            buttonQuitter.Margin = new Padding(3, 4, 3, 4);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(106, 43);
            buttonQuitter.TabIndex = 10;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // FrmJeu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Jeu_de_nim_2;
            ClientSize = new Size(1130, 570);
            ControlBox = false;
            Controls.Add(buttonQuitter);
            Controls.Add(labelNumeroPartie);
            Controls.Add(labelNumPar);
            Controls.Add(labelNomAdversaire);
            Controls.Add(labelAdversaire);
            Controls.Add(buttonAbandonner);
            Controls.Add(numericBatonARetirer);
            Controls.Add(labelBatonsAEnlever);
            Controls.Add(buttonEnleverBaton);
            Controls.Add(labelNombreBaton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmJeu";
            Text = "Jeu de Nim";
            ((System.ComponentModel.ISupportInitialize)numericBatonARetirer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombreBaton;
        private Button buttonEnleverBaton;
        private Label labelBatonsAEnlever;
        private NumericUpDown numericBatonARetirer;
        private System.Windows.Forms.Timer timerRefreshDonnee;
        private Button buttonAbandonner;
        private Label labelAdversaire;
        private Label labelNomAdversaire;
        private Label labelNumPar;
        private Label labelNumeroPartie;
        private Button buttonQuitter;
    }
}