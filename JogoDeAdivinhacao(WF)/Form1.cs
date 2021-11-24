using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;
using JogoDeAdivinhacao_WF_.Entities;


namespace JogoDeAdivinhacao_WF_
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();

        }

        int numeroSecreto;

        public void playApplause()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Applause);
            simpleSound.Play();
        }
        public void playAhhh()
        {
            SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Ahhhh);
            simpleSound.Play();
        }

        public int GeradorDeNumeroAleatorio()
        {
            Random numeroAleatorio = new Random();
            numeroSecreto = numeroAleatorio.Next(0, 1000);
            return numeroSecreto;
        }

        private void frmTelaPrincipal_Load(object sender, EventArgs e)
        {
            GeradorDeNumeroAleatorio();
            lblVitorias.Text = "0";
            lblDerrotas.Text = "0";
            lblRecord.Text = "0";
        }
        int iVerificador = 1;
        public string Verificador(int tentativa, string message = "")
        {

            int chute = tentativa;
            if (numeroSecreto > chute)
            {
                message = "O NÚMERO SECRETO É MAIOR!";
                txtTentativa.Focus();
            }
            else if (numeroSecreto < chute)
            {
                message = "O NÚMERO SECRETO É MENOR!";
                txtTentativa.Focus();
            }
            else if (numeroSecreto == chute)
            {
                message = "PARABÉNS! VOCÊ ACERTOU!!\n\n" +
                    $"Você utilizou {iVerificador} tentativa(s).";
                Vitorias vitorias = new Vitorias();
                vitorias.Amount += 1;
                int quant = 0;
                quant = vitorias.Amount + int.Parse(lblVitorias.Text);
                lblVitorias.Text = quant.ToString();



                if (int.Parse(lblRecord.Text) == 0)
                {
                    vitorias.TentativesAmount = iVerificador;
                    vitorias.TentativesAmount = iVerificador;
                    int record = 0;
                    record = iVerificador;
                    lblRecord.Text = record.ToString();
                }
                else if (iVerificador < int.Parse(lblRecord.Text))
                {
                    vitorias.TentativesAmount = iVerificador;
                    int record = 0;
                    record = iVerificador;
                    lblRecord.Text = record.ToString();
                }
                txtTentativa.Focus();
                iVerificador = 1;
            }
            if (numeroSecreto != chute)
            {
                iVerificador++;
            }

            return message;
        }

        //Eventos de Botões #region
        #region
        int i = 1;
        private void btn1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Vitorias vitorias = new Vitorias();
                if (int.Parse(txtTentativa.Text) > 1000 || txtTentativa.Text.Length > 8)
                {
                    MessageBox.Show("Você deve chutar um número de 0 a 1000.");
                    txtTentativa.Clear();
                    txtTentativa.Focus();
                    return;
                }
                if (txtTentativa.Text.Trim().Equals(String.Empty))
                {
                    MessageBox.Show("Você precisa digitar um número!");
                    txtTentativa.Focus();
                    return;
                }
                if (int.Parse(txtTentativa.Text) < 0)
                {
                    MessageBox.Show("Números negativos não são permitidos!");
                    txtTentativa.Clear();
                    txtTentativa.Focus();
                    return;
                }

                lblTentativa.Text = $"Tentativa {i} ";
                string mensagem = Verificador(int.Parse(txtTentativa.Text));
                if (txtTentativa.Text == numeroSecreto.ToString())
                {
                    playApplause();
                }
                MessageBox.Show(mensagem, "Jogo de Adivinhação");


                if (txtTentativa.Text == numeroSecreto.ToString())
                {
                    lblTentativa.Text = "Você acertou!!";
                    MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                    DialogResult resposta;
                    resposta = MessageBox.Show("Deseja jogar novamente?", "Jogo de Adivinhação", botoes);
                    TelaInicial tela = new TelaInicial();
                    tela.playSimpleSound();
                    if (resposta == DialogResult.Yes)
                    {
                        GeradorDeNumeroAleatorio();
                        MessageBox.Show("Um novo número secreto foi gerado.\n\n Boa sorte!!");
                        txtTentativa.Clear();
                        lblTentativa.Text = "";
                        i = 0;
                        
                    }
                    else
                    {
                        TelaInicial telaInicial = new TelaInicial();
                        telaInicial.Show();
                        this.Hide();
                    }
                }
                else
                {
                    if (i == 10)
                    {
                        playAhhh();
                        Derrotas derrotas = new Derrotas();
                        derrotas.Amount += 1;
                        int quant = 0;
                        quant = derrotas.Amount + int.Parse(lblDerrotas.Text);
                        lblDerrotas.Text = quant.ToString();
                        MessageBoxButtons botoes = MessageBoxButtons.YesNo;
                        DialogResult resposta;
                        resposta = MessageBox.Show("SUAS TENTATIVAS ACABARAM!! VOCÊ PERDEU!!\n" +
                            "O número secreto era " + numeroSecreto.ToString() +
                            "\n\nDeseja jogar novamente?", "Jogo de Adivinhação", botoes);
                        if (resposta == DialogResult.Yes)
                        {
                            TelaInicial tela = new TelaInicial();
                            tela.playSimpleSound();
                            GeradorDeNumeroAleatorio();
                            MessageBox.Show("Um novo número secreto foi gerado.\n\n Boa sorte!!");
                            i = 0;
                            txtTentativa.Clear();
                            lblTentativa.Text = "";
                            iVerificador = 1;
                            
                        }
                        else
                        {
                            TelaInicial telaInicial = new TelaInicial();
                            this.Hide();
                            telaInicial.Show();
                        }
                    }
                }
                i++;
                txtTentativa.Clear();
                txtTentativa.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Você deve digitar um número inteiro");
            }
        }

        private void btnGerarNovo_Click(object sender, EventArgs e)
        {
            MessageBoxButtons botoes = MessageBoxButtons.YesNo;
            DialogResult resposta;
            resposta = MessageBox.Show("Uma nova derrota será adicionado aos Stats!\n" + "Tem certeza??", 
                "Jogo de Adivinhção", botoes);
            if (resposta == DialogResult.Yes)
            {
                GeradorDeNumeroAleatorio();
                iVerificador = 1;
                lblTentativa.Text = "";
                i = 1;
                Derrotas derrotas = new Derrotas();
                derrotas.Amount += 1;
                int quant = 0;
                quant = derrotas.Amount + int.Parse(lblDerrotas.Text);
                lblDerrotas.Text = quant.ToString();
                MessageBox.Show("Novo número secreto foi gerado! Boa sorte!");
            }
            else
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vitorias vitorias = new Vitorias();
            Derrotas derrotas = new Derrotas();
            MessageBox.Show("Quantidade de vitórias: " + vitorias.Amount + "\n" +
                "Quantidade de derrotas: " + derrotas.Amount + "\n" +
                "Record em número de tentativas: " + vitorias.TentativesAmount);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            this.Close();
            telaInicial.Close();
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            lblVitorias.Text = "0";
            lblDerrotas.Text = "0";
            lblRecord.Text = "0";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }
        #endregion

        private void txtTentativa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                btn1_Click_1(btn1, new EventArgs());
            }
        }

        private void chkSoundTela2_CheckedChanged(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            if (chkSoundTela2.Checked)
            {
                telaInicial.playSimpleSound();
            }
            else
            {
                telaInicial.stopSimpleSound();
            }
        }
    }
}
