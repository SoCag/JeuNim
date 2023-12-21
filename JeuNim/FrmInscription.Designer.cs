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
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 33);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Inscription";
            // 
            // LabelNom
            // 
            LabelNom.AutoSize = true;
            LabelNom.Font = new Font("Microsoft Sans Serif", 8.25F);
            LabelNom.Location = new Point(46, 84);
            LabelNom.Name = "LabelNom";
            LabelNom.Size = new Size(37, 17);
            LabelNom.TabIndex = 1;
            LabelNom.Text = "Nom";
            // 
            // LabelPrenom
            // 
            LabelPrenom.AutoSize = true;
            LabelPrenom.Font = new Font("Microsoft Sans Serif", 8.25F);
            LabelPrenom.Location = new Point(36, 146);
            LabelPrenom.Name = "LabelPrenom";
            LabelPrenom.Size = new Size(57, 17);
            LabelPrenom.TabIndex = 2;
            LabelPrenom.Text = "Prenom";
            // 
            // labelPseudo
            // 
            labelPseudo.AutoSize = true;
            labelPseudo.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelPseudo.Location = new Point(37, 277);
            labelPseudo.Name = "labelPseudo";
            labelPseudo.Size = new Size(56, 17);
            labelPseudo.TabIndex = 3;
            labelPseudo.Text = "Pseudo";
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Microsoft Sans Serif", 8.25F);
            labelMail.Location = new Point(46, 214);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(33, 17);
            labelMail.TabIndex = 4;
            labelMail.Text = "Mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(12, 350);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 5;
            label2.Text = "Mot de passe";
            // 
            // TxtNomInscription
            // 
            TxtNomInscription.Location = new Point(117, 79);
            TxtNomInscription.Name = "TxtNomInscription";
            TxtNomInscription.PlaceholderText = "Nom";
            TxtNomInscription.Size = new Size(262, 27);
            TxtNomInscription.TabIndex = 6;
            // 
            // TxtPrenomInscription
            // 
            TxtPrenomInscription.Location = new Point(117, 146);
            TxtPrenomInscription.Name = "TxtPrenomInscription";
            TxtPrenomInscription.PlaceholderText = "Votre Prenom...";
            TxtPrenomInscription.Size = new Size(262, 27);
            TxtPrenomInscription.TabIndex = 7;
            // 
            // TxtMailInscription
            // 
            TxtMailInscription.Location = new Point(117, 209);
            TxtMailInscription.Name = "TxtMailInscription";
            TxtMailInscription.PlaceholderText = "Votre mail : exemple@exemple.fr";
            TxtMailInscription.Size = new Size(262, 27);
            TxtMailInscription.TabIndex = 8;
            // 
            // TxtPseudo
            // 
            TxtPseudo.Location = new Point(117, 272);
            TxtPseudo.Name = "TxtPseudo";
            TxtPseudo.PlaceholderText = "Votre Pseudo";
            TxtPseudo.Size = new Size(262, 27);
            TxtPseudo.TabIndex = 9;
            // 
            // TxtMDPInscription
            // 
            TxtMDPInscription.Location = new Point(117, 345);
            TxtMDPInscription.Name = "TxtMDPInscription";
            TxtMDPInscription.PlaceholderText = "Votre mot de passe...";
            TxtMDPInscription.Size = new Size(262, 27);
            TxtMDPInscription.TabIndex = 10;
            TxtMDPInscription.TextChanged += TxtMDPInscription_TextChanged;
            // 
            // TxtConfirmationMDP
            // 
            TxtConfirmationMDP.Location = new Point(117, 392);
            TxtConfirmationMDP.Name = "TxtConfirmationMDP";
            TxtConfirmationMDP.PlaceholderText = "Confirmer votre mot de passe...";
            TxtConfirmationMDP.Size = new Size(262, 27);
            TxtConfirmationMDP.TabIndex = 11;
            TxtConfirmationMDP.TextChanged += TxtConfirmationMDP_TextChanged;
            // 
            // BtnInscription
            // 
            BtnInscription.Location = new Point(119, 453);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(226, 35);
            BtnInscription.TabIndex = 12;
            BtnInscription.Text = "S'inscrire";
            BtnInscription.UseVisualStyleBackColor = true;
            BtnInscription.Click += BtnInscription_Click;
            // 
            // BtnConnexion
            // 
            BtnConnexion.Location = new Point(117, 505);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(226, 35);
            BtnConnexion.TabIndex = 13;
            BtnConnexion.Text = "Connexion";
            BtnConnexion.UseVisualStyleBackColor = true;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(385, 345);
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
            pictureBox2.Location = new Point(385, 385);
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
            ClientSize = new Size(437, 564);
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