namespace JeuNim
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            LabelConnexion = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            TxtEmail = new TextBox();
            TxtMDP = new TextBox();
            pictureBox2 = new PictureBox();
            BtnConnexion = new Button();
            BtnInscription = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(414, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(48, 34);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LabelConnexion
            // 
            LabelConnexion.AutoSize = true;
            LabelConnexion.BackColor = Color.Transparent;
            LabelConnexion.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelConnexion.Location = new Point(552, 72);
            LabelConnexion.Name = "LabelConnexion";
            LabelConnexion.Size = new Size(94, 18);
            LabelConnexion.TabIndex = 2;
            LabelConnexion.Text = "Connexion";
            LabelConnexion.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(430, 224);
            panel2.Name = "panel2";
            panel2.Size = new Size(329, 3);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Location = new Point(-3, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(329, 3);
            panel3.TabIndex = 5;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(468, 110);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email...";
            TxtEmail.Size = new Size(264, 34);
            TxtEmail.TabIndex = 5;
            // 
            // TxtMDP
            // 
            TxtMDP.Location = new Point(468, 172);
            TxtMDP.Multiline = true;
            TxtMDP.Name = "TxtMDP";
            TxtMDP.Size = new Size(264, 34);
            TxtMDP.TabIndex = 6;
            TxtMDP.TextChanged += TxtMDP_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(414, 172);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // BtnConnexion
            // 
            BtnConnexion.BackColor = Color.FromArgb(128, 64, 0);
            BtnConnexion.ForeColor = Color.White;
            BtnConnexion.Location = new Point(488, 300);
            BtnConnexion.Name = "BtnConnexion";
            BtnConnexion.Size = new Size(226, 35);
            BtnConnexion.TabIndex = 8;
            BtnConnexion.Text = "Se Connecter";
            BtnConnexion.UseVisualStyleBackColor = false;
            BtnConnexion.Click += BtnConnexion_Click;
            // 
            // BtnInscription
            // 
            BtnInscription.BackColor = Color.FromArgb(128, 64, 0);
            BtnInscription.ForeColor = Color.White;
            BtnInscription.Location = new Point(488, 353);
            BtnInscription.Name = "BtnInscription";
            BtnInscription.Size = new Size(226, 35);
            BtnInscription.TabIndex = 9;
            BtnInscription.Text = "S'inscrire";
            BtnInscription.UseVisualStyleBackColor = false;
            BtnInscription.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(739, 177);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            pictureBox3.MouseEnter += visualiserMDP;
            pictureBox3.MouseLeave += cacherMDP;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Jeu_de_nim_2;
            ClientSize = new Size(1159, 609);
            Controls.Add(pictureBox3);
            Controls.Add(BtnInscription);
            Controls.Add(BtnConnexion);
            Controls.Add(pictureBox2);
            Controls.Add(TxtMDP);
            Controls.Add(TxtEmail);
            Controls.Add(panel2);
            Controls.Add(LabelConnexion);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FrmPrincipal";
            Text = "Page de connexion";
            Load += FrmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label LabelConnexion;
        private Panel panel2;
        private Panel panel3;
        private TextBox TxtEmail;
        private TextBox TxtMDP;
        private PictureBox pictureBox2;
        private Button BtnConnexion;
        private Button BtnInscription;
        private PictureBox pictureBox3;
    }
}
