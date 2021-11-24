
namespace JogoDeAdivinhacao_WF_
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.btn1 = new System.Windows.Forms.Button();
            this.txtTentativa = new System.Windows.Forms.TextBox();
            this.lblTentativa = new System.Windows.Forms.Label();
            this.btnGerarNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblVitorias = new System.Windows.Forms.Label();
            this.lblDerrotas = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.chkSoundTela2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Black;
            this.btn1.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoGo;
            this.btn1.Location = new System.Drawing.Point(446, 275);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 48);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Ir";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click_1);
            // 
            // txtTentativa
            // 
            this.txtTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentativa.Location = new System.Drawing.Point(280, 275);
            this.txtTentativa.Name = "txtTentativa";
            this.txtTentativa.Size = new System.Drawing.Size(145, 47);
            this.txtTentativa.TabIndex = 5;
            this.txtTentativa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTentativa_KeyPress);
            // 
            // lblTentativa
            // 
            this.lblTentativa.AutoSize = true;
            this.lblTentativa.BackColor = System.Drawing.Color.Black;
            this.lblTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTentativa.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTentativa.Location = new System.Drawing.Point(282, 341);
            this.lblTentativa.Name = "lblTentativa";
            this.lblTentativa.Size = new System.Drawing.Size(0, 33);
            this.lblTentativa.TabIndex = 6;
            // 
            // btnGerarNovo
            // 
            this.btnGerarNovo.BackColor = System.Drawing.Color.Black;
            this.btnGerarNovo.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoGerarNovoNumero;
            this.btnGerarNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGerarNovo.Location = new System.Drawing.Point(198, 391);
            this.btnGerarNovo.Name = "btnGerarNovo";
            this.btnGerarNovo.Size = new System.Drawing.Size(110, 48);
            this.btnGerarNovo.TabIndex = 7;
            this.btnGerarNovo.UseVisualStyleBackColor = false;
            this.btnGerarNovo.Click += new System.EventHandler(this.btnGerarNovo_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Black;
            this.btnSair.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoSair;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.Location = new System.Drawing.Point(713, 391);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 48);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.Transparent;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(19, 9);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(71, 18);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Vitórias:";
            // 
            // lblD
            // 
            this.lblD.BackColor = System.Drawing.Color.Transparent;
            this.lblD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(12, 37);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(86, 18);
            this.lblD.TabIndex = 11;
            this.lblD.Text = "Derrotas:";
            // 
            // lblR
            // 
            this.lblR.BackColor = System.Drawing.Color.Transparent;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(21, 64);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(71, 18);
            this.lblR.TabIndex = 12;
            this.lblR.Text = "Record:";
            // 
            // lblVitorias
            // 
            this.lblVitorias.BackColor = System.Drawing.Color.Transparent;
            this.lblVitorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVitorias.Location = new System.Drawing.Point(89, 9);
            this.lblVitorias.Name = "lblVitorias";
            this.lblVitorias.Size = new System.Drawing.Size(39, 18);
            this.lblVitorias.TabIndex = 13;
            // 
            // lblDerrotas
            // 
            this.lblDerrotas.BackColor = System.Drawing.Color.Transparent;
            this.lblDerrotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDerrotas.Location = new System.Drawing.Point(89, 37);
            this.lblDerrotas.Name = "lblDerrotas";
            this.lblDerrotas.Size = new System.Drawing.Size(39, 18);
            this.lblDerrotas.TabIndex = 14;
            // 
            // lblRecord
            // 
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(89, 66);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(39, 18);
            this.lblRecord.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoLimparStats;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 50);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Black;
            this.btnVoltar.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BotaoVoltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Location = new System.Drawing.Point(591, 391);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(116, 48);
            this.btnVoltar.TabIndex = 17;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // chkSoundTela2
            // 
            this.chkSoundTela2.AutoSize = true;
            this.chkSoundTela2.BackColor = System.Drawing.Color.Black;
            this.chkSoundTela2.Checked = true;
            this.chkSoundTela2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSoundTela2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSoundTela2.ForeColor = System.Drawing.Color.White;
            this.chkSoundTela2.Location = new System.Drawing.Point(591, 368);
            this.chkSoundTela2.Name = "chkSoundTela2";
            this.chkSoundTela2.Size = new System.Drawing.Size(66, 17);
            this.chkSoundTela2.TabIndex = 18;
            this.chkSoundTela2.Text = "Musica";
            this.chkSoundTela2.UseVisualStyleBackColor = false;
            this.chkSoundTela2.CheckedChanged += new System.EventHandler(this.chkSoundTela2_CheckedChanged);
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::JogoDeAdivinhacao_WF_.Properties.Resources.BackGroundTelaDoJogo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkSoundTela2);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblDerrotas);
            this.Controls.Add(this.lblVitorias);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGerarNovo);
            this.Controls.Add(this.lblTentativa);
            this.Controls.Add(this.txtTentativa);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JOGO DE ADIVINHAÇÃO";
            this.Load += new System.EventHandler(this.frmTelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtTentativa;
        private System.Windows.Forms.Label lblTentativa;
        private System.Windows.Forms.Button btnGerarNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblVitorias;
        private System.Windows.Forms.Label lblDerrotas;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.CheckBox chkSoundTela2;
    }
}

