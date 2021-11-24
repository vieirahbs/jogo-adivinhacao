
namespace JogoDeAdivinhacao_WF_
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnRegras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair2 = new System.Windows.Forms.Button();
            this.chkSound = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnRegras
            // 
            this.btnRegras.BackColor = System.Drawing.Color.Black;
            this.btnRegras.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoRegras;
            this.btnRegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegras.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRegras.Location = new System.Drawing.Point(12, 12);
            this.btnRegras.Name = "btnRegras";
            this.btnRegras.Size = new System.Drawing.Size(176, 63);
            this.btnRegras.TabIndex = 5;
            this.btnRegras.UseVisualStyleBackColor = false;
            this.btnRegras.Click += new System.EventHandler(this.btnRegras_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoComecar;
            this.button1.Location = new System.Drawing.Point(356, 307);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 99);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair2
            // 
            this.btnSair2.BackColor = System.Drawing.Color.Black;
            this.btnSair2.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoSair;
            this.btnSair2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair2.Location = new System.Drawing.Point(713, 390);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(75, 48);
            this.btnSair2.TabIndex = 10;
            this.btnSair2.UseVisualStyleBackColor = false;
            this.btnSair2.Click += new System.EventHandler(this.btnSair2_Click);
            // 
            // chkSound
            // 
            this.chkSound.AutoSize = true;
            this.chkSound.BackColor = System.Drawing.Color.Black;
            this.chkSound.Checked = true;
            this.chkSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSound.ForeColor = System.Drawing.Color.White;
            this.chkSound.Location = new System.Drawing.Point(12, 81);
            this.chkSound.Name = "chkSound";
            this.chkSound.Size = new System.Drawing.Size(59, 17);
            this.chkSound.TabIndex = 11;
            this.chkSound.Text = "Music";
            this.chkSound.UseVisualStyleBackColor = false;
            this.chkSound.CheckedChanged += new System.EventHandler(this.chkSound_CheckedChanged);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BackgroundAdivinhacao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSound);
            this.Controls.Add(this.btnSair2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegras);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DE ADIVINHAÇÃO";
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.CheckBox chkSound;
    }
}