namespace JeuNim
{
    partial class FrmAccueil
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
            btnCreer = new Button();
            btnJoin = new Button();
            txtNumero = new TextBox();
            label1 = new Label();
            checkPrivate = new CheckBox();
            SuspendLayout();
            // 
            // btnCreer
            // 
            btnCreer.BackColor = Color.FromArgb(128, 64, 0);
            btnCreer.ForeColor = Color.White;
            btnCreer.Location = new Point(480, 173);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(233, 29);
            btnCreer.TabIndex = 0;
            btnCreer.Text = "Créer une partie";
            btnCreer.UseVisualStyleBackColor = false;
            btnCreer.Click += btnCreer_Click;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.FromArgb(128, 64, 0);
            btnJoin.ForeColor = SystemColors.ButtonFace;
            btnJoin.Location = new Point(480, 245);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(233, 32);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Rejoindre une partie";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(928, 185);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(170, 23);
            txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(915, 157);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 3;
            label1.Text = "Numéro de partie :";
            // 
            // checkPrivate
            // 
            checkPrivate.AutoSize = true;
            checkPrivate.Location = new Point(381, 48);
            checkPrivate.Name = "checkPrivate";
            checkPrivate.Size = new Size(58, 19);
            checkPrivate.TabIndex = 4;
            checkPrivate.Text = "Privée";
            checkPrivate.UseVisualStyleBackColor = true;
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Jeu_de_nim_2;
            ClientSize = new Size(1166, 604);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnJoin);
            Controls.Add(btnCreer);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmAccueil";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreer;
        private Button btnJoin;
        private TextBox txtNumero;
        private Label label1;
        private CheckBox checkPrivate;
    }
}