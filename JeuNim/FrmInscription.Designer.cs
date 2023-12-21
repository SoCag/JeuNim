namespace JeuNim
{
    partial class FrmInscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscription));
            label1 = new Label();
            LabelNom = new Label();
            LabelPrenom = new Label();
            labelPseudo = new Label();
            labelMail = new Label();
            label2 = new Label();
            TxtNomInscription = new TextBox();
            TxtPrenomInscription = new TextBox();
            TxtMailInscription = new TextBox();
            TxtPseudo = new TextBox();
            TxtMDPInscription = new TextBox();
            TxtConfirmationMDP = new TextBox();
            BtnInscription = new Button();
            BtnConnexion = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(569, 26);
            label1.Name = "label1";
            label1.Size = new Size(120, 23);
            label1.TabIndex = 0;
            label1.Text = "Inscription";
            // 
            // LabelNom
            // 
            LabelNom.AutoSize = true;
            LabelNom.BackColor = Color.Transparent;
            LabelNom.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelNom.Location = new Point(454, 77);
            LabelNom.Name = "LabelNom";
            LabelNom.Size = new Size(50, 17);
            LabelNom.TabIndex = 1;
            LabelNom.Text = "Nom :";
            // 
            // LabelPrenom
            // 
            LabelPrenom.AutoSize = true;
            LabelPrenom.BackColor = Color.Transparent;
            LabelPrenom.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelPrenom.Location = new Point(426, 126);
            LabelPrenom.Name = "LabelPrenom";
            LabelPrenom.Size = new Size(78, 17);
            LabelPrenom.TabIndex = 2;
            LabelPrenom.Text = "Prenom :";
            // 
            // labelPseudo
            // 
            labelPseudo.AutoSize = true;
            labelPseudo.BackColor = Color.Transparent;
            labelPseudo.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelPseudo.Location = new Point(428, 227);
            labelPseudo.Name = "labelPseudo";
            labelPseudo.Size = new Size(76, 17);
            labelPseudo.TabIndex = 3;
            labelPseudo.Text = "Pseudo :";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.BackColor = Color.Transparent;
            labelMail.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelMail.Location = new Point(452, 177);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(52, 17);
            labelMail.TabIndex = 4;
            labelMail.Text = "Mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(384, 288);
            label2.Name = "label2";
            label2.Size = new Size(120, 17);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe :";
            // 
            // TxtNomInscription
            // 
            TxtNomInscription.Location = new Point(505, 72);
            TxtNomInscription.Name = "TxtNomInscription";
            TxtNomInscription.PlaceholderText = "Nom";
            TxtNomInscription.Size = new Size(262, 27);
            TxtNomInscription.TabIndex = 6;
            // 
            // TxtPrenomInscription
            // 
            TxtPrenomInscription.Location = new Point(505, 121);
            TxtPrenomInscription.Name = "TxtPrenomInscription";
            TxtPrenomInscription.PlaceholderText = "Votre Prenom...";
            TxtPrenomInscription.Size = new Size(262, 27);
            TxtPrenomInscription.TabIndex = 7;
            // 
            // TxtMailInscription
            // 
            TxtMailInscription.Location = new Point(505, 172);
            TxtMailInscription.Name = "TxtMailInscription";
            TxtMailInscription.PlaceholderText = "Votre mail : exemple@exemple.fr";
            TxtMailInscription.Size = new Size(262, 27);
            TxtMailInscription.TabIndex = 8;
            // 
            // TxtPseudo
            // 
            TxtPseudo.Location = new Point(505, 222);
            TxtPseudo.Name = "TxtPseudo";
            TxtPseudo.PlaceholderText = "Votre Pseudo";
            TxtPseudo.Size = new Size(262, 27);
            TxtPseudo.TabIndex = 9;
            // 
            // TxtMDPInscription
            // 
            TxtMDPInscription.Location = new Point(505, 283);
            TxtMDPInscription.Name = "TxtMDPInscription";
            TxtMDPInscription.PlaceholderText = "Votre mot de passe...";
            TxtMDPInscription.Size = new Size(262, 27);
            TxtMDPInscription.TabIndex = 10;
            TxtMDPInscription.TextChanged += TxtMDPInscription_TextChanged;
            // 
            // TxtConfirmationMDP
            // 
            TxtConfirmationMDP.Location = new Point(505, 338);
            TxtConfirmationMDP.Name = "TxtConfirmationMDP";
            TxtConfirmationMDP.PlaceholderText = "Confirmer votre mot de passe...";
            TxtConfirmationMDP.Size = new Size(262, 27);
            TxtConfirmationMDP.TabIndex = 11;
            TxtConfirmationMDP.TextChanged += TxtConfirmationMDP_TextChanged;
            // 
            // BtnInscription
            // 
            BtnInscription.BackColor = Color.FromArgb(128, 64, 0);
            BtnInscription.ForeColor = Color.White;
            BtnInscription.Location = new Point(517, 454);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(226, 35);
            BtnInscription.TabIndex = 12;
            BtnInscription.Text = "S'inscrire";
            BtnInscription.UseVisualStyleBackColor = false;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // BtnConnexion
            // 
            BtnConnexion.BackColor = Color.FromArgb(128, 64, 0);
            BtnConnexion.ForeColor = Color.White;
            BtnConnexion.Location = new Point(517, 504);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(226, 35);
            BtnConnexion.TabIndex = 13;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = false;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(773, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += voirMDP;
            pictureBox1.MouseLeave += cacherMDP;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(773, 334);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.MouseEnter += voirConfirmationMDP;
            pictureBox2.MouseLeave += cacherConfirmationMDP;
            // 
            // FrmInscription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Jeu_de_nim_2;
            ClientSize = new Size(1165, 605);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnConnexion);
            Controls.Add(BtnInscription);
            Controls.Add(TxtConfirmationMDP);
            Controls.Add(TxtMDPInscription);
            Controls.Add(TxtPseudo);
            Controls.Add(TxtMailInscription);
            Controls.Add(TxtPrenomInscription);
            Controls.Add(TxtNomInscription);
            Controls.Add(label2);
            Controls.Add(labelMail);
            Controls.Add(labelPseudo);
            Controls.Add(LabelPrenom);
            Controls.Add(LabelNom);
            Controls.Add(label1);
            Name = "FrmInscription";
            Text = "Inscription";
            Load += FrmInscription_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label LabelNom;
        private Label LabelPrenom;
        private Label labelPseudo;
        private Label labelMail;
        private Label label2;
        private TextBox TxtNomInscription;
        private TextBox TxtPrenomInscription;
        private TextBox TxtMailInscription;
        private TextBox TxtPseudo;
        private TextBox TxtMDPInscription;
        private TextBox TxtConfirmationMDP;
        private Button BtnInscription;
        private Button BtnConnexion;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}