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
            ((System.ComponentModel.ISupportInitialize)numericBatonARetirer).BeginInit();
            SuspendLayout();
            // 
            // labelNombreBaton
            // 
            labelNombreBaton.AutoSize = true;
            labelNombreBaton.Location = new Point(165, 123);
            labelNombreBaton.Name = "labelNombreBaton";
            labelNombreBaton.Size = new Size(106, 15);
            labelNombreBaton.TabIndex = 1;
            labelNombreBaton.Text = "Nombre de bâtons";
            // 
            // buttonEnleverBaton
            // 
            buttonEnleverBaton.Enabled = false;
            buttonEnleverBaton.Location = new Point(146, 256);
            buttonEnleverBaton.Name = "buttonEnleverBaton";
            buttonEnleverBaton.Size = new Size(146, 52);
            buttonEnleverBaton.TabIndex = 2;
            buttonEnleverBaton.Text = "Enlever";
            buttonEnleverBaton.UseVisualStyleBackColor = true;
            // 
            // labelBatonsAEnlever
            // 
            labelBatonsAEnlever.AutoSize = true;
            labelBatonsAEnlever.Location = new Point(143, 209);
            labelBatonsAEnlever.Name = "labelBatonsAEnlever";
            labelBatonsAEnlever.Size = new Size(149, 15);
            labelBatonsAEnlever.TabIndex = 3;
            labelBatonsAEnlever.Text = "Nombre de bâtons à retirer";
            // 
            // numericBatonARetirer
            // 
            numericBatonARetirer.Enabled = false;
            numericBatonARetirer.Location = new Point(146, 227);
            numericBatonARetirer.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericBatonARetirer.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericBatonARetirer.Name = "numericBatonARetirer";
            numericBatonARetirer.Size = new Size(146, 23);
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
            buttonAbandonner.Location = new Point(339, 12);
            buttonAbandonner.Name = "buttonAbandonner";
            buttonAbandonner.Size = new Size(93, 32);
            buttonAbandonner.TabIndex = 5;
            buttonAbandonner.Text = "Abandonner";
            buttonAbandonner.UseVisualStyleBackColor = true;
            // 
            // labelAdversaire
            // 
            labelAdversaire.AutoSize = true;
            labelAdversaire.Location = new Point(12, 29);
            labelAdversaire.Name = "labelAdversaire";
            labelAdversaire.Size = new Size(68, 15);
            labelAdversaire.TabIndex = 6;
            labelAdversaire.Text = "Adversaire :";
            // 
            // labelNomAdversaire
            // 
            labelNomAdversaire.AutoSize = true;
            labelNomAdversaire.Location = new Point(124, 29);
            labelNomAdversaire.Name = "labelNomAdversaire";
            labelNomAdversaire.Size = new Size(155, 15);
            labelNomAdversaire.TabIndex = 7;
            labelNomAdversaire.Text = "En attente d'un adversaire ...";
            // 
            // labelNumPar
            // 
            labelNumPar.AutoSize = true;
            labelNumPar.Location = new Point(12, 6);
            labelNumPar.Name = "labelNumPar";
            labelNumPar.Size = new Size(106, 15);
            labelNumPar.TabIndex = 8;
            labelNumPar.Text = "Numéro de partie :";
            // 
            // labelNumeroPartie
            // 
            labelNumeroPartie.AutoSize = true;
            labelNumeroPartie.Location = new Point(124, 6);
            labelNumeroPartie.Name = "labelNumeroPartie";
            labelNumeroPartie.Size = new Size(46, 15);
            labelNumeroPartie.TabIndex = 9;
            labelNumeroPartie.Text = "NPartie";
            // 
            // FrmJeu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 320);
            Controls.Add(labelNumeroPartie);
            Controls.Add(labelNumPar);
            Controls.Add(labelNomAdversaire);
            Controls.Add(labelAdversaire);
            Controls.Add(buttonAbandonner);
            Controls.Add(numericBatonARetirer);
            Controls.Add(labelBatonsAEnlever);
            Controls.Add(buttonEnleverBaton);
            Controls.Add(labelNombreBaton);
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
    }
}