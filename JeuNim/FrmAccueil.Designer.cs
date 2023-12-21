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
            SuspendLayout();
            // 
            // btnCreer
            // 
            btnCreer.BackColor = Color.FromArgb(128, 64, 0);
            btnCreer.ForeColor = Color.White;
            btnCreer.Location = new Point(264, 96);
            btnCreer.Name = "btnCreer";
            btnCreer.Size = new Size(266, 39);
            btnCreer.TabIndex = 0;
            btnCreer.Text = "Créer une partie";
            btnCreer.UseVisualStyleBackColor = false;
            btnCreer.Click += btnCreer_Click;
            // 
            // btnJoin
            // 
            btnJoin.BackColor = Color.FromArgb(128, 64, 0);
            btnJoin.ForeColor = SystemColors.ButtonFace;
            btnJoin.Location = new Point(264, 158);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(266, 43);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Rejoindre une partie";
            btnJoin.UseVisualStyleBackColor = false;
            btnJoin.Click += btnJoin_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(47, 241);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(136, 27);
            txtNumero.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(73, 218);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 3;
            label1.Text = "Numéro :";
            // 
            // FrmAccueil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Jeu_de_nim_2;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtNumero);
            Controls.Add(btnJoin);
            Controls.Add(btnCreer);
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
    }
}