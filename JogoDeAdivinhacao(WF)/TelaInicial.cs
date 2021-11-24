using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDeAdivinhacao_WF_;

namespace JogoDeAdivinhacao_WF_
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        public void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer
                (Properties.Resources.BlueThursday);
            simpleSound.PlayLooping();
        }
        public void stopSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer();
            simpleSound.Stop();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            playSimpleSound();
        }

        private void btnRegras_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você deve chutar um número de 0 a 1000\n" +
                "Você tem apenas 10 tentativas!\n\n" +
                "Não é permitido:\n" +
                " - Números negativos;\n" +
                " - Letras;\n" +
                " - Espaço vazio.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTelaPrincipal telaDoJogo = new frmTelaPrincipal();
            telaDoJogo.Show();
            this.Hide();
        }

        private void btnSair2_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Close();
            telaInicial.Close();
            Application.Exit();
        }

        private void chkSound_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSound.Checked)
            {
                playSimpleSound();
            }
            else
            {
                stopSimpleSound();
            }
        }
    }
}
