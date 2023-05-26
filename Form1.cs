using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ticTacToe
{
    public partial class Form1 : Form
    {
        private enum Escolha { pedra, papel, tesoura }
        private Escolha escolhaUsuario;
        private Escolha escolhaComputador;
        private readonly Image pedraImg = Image.FromFile((Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "pedra.png")));
        private readonly Image papelImg = Image.FromFile((Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "papel.png")));
        private readonly Image tesouraImg = Image.FromFile((Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "img", "tesoura.png")));
        public Form1()
        {
            
            InitializeComponent();
          }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            pbPapel.Image = papelImg;
            pbPedra.Image = pedraImg;
            pbTesoura.Image = tesouraImg;

        }

        private void pbPedra_Click(object sender, EventArgs e)
        {
            Escolha escolhaComputador = gerarApostaComputador();
            Escolha escolhaHumano = Escolha.pedra;
            bool humanoGanhou = VerificaHumanoGanhou(escolhaHumano,escolhaComputador);
            MessageBox.Show(humanoGanhou ? "Você Ganhou" : "Você Perdeu");

        }


    
        private bool VerificaHumanoGanhou(Escolha escolhaHumano, Escolha escolhaComputador)
        {
            switch (escolhaComputador)
            {
                case Escolha.papel:
                    switch (escolhaHumano)
                    {
                        case Escolha.papel:
                            return false;
                        case Escolha.pedra:
                            return false;
                        case Escolha.tesoura:
                            return true;
                    }
                    break; 
                case Escolha.pedra:
                    switch (escolhaHumano)
                    {
                        case Escolha.papel:
                            return true;
                        case Escolha.pedra:
                            return false;
                        case Escolha.tesoura:
                            return false;
                    }
                    break; 
                case Escolha.tesoura:
                    switch (escolhaHumano)
                    {
                        case Escolha.papel:
                            return false;
                        case Escolha.pedra:
                            return true;
                        case Escolha.tesoura:
                            return false;
                    }
                    break;
            }

            return false; 
        }
        private Escolha gerarApostaComputador()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(3);
            switch (numeroAleatorio)
            {
                case 1:
                    {
                        MessageBox.Show("O computador Escolhe Pedra");
                        return Escolha.pedra;
                    }
                     
                case 2:
                    {
                        MessageBox.Show("O computador Escolheu Papel");
                        return Escolha.papel;
                    }
                case 0:
                    {
                        MessageBox.Show("O computador Escolheu Tesoura");
                        return Escolha.tesoura;
                    }
                default: return Escolha.papel;
            }
        }

        private void pbPapel_Click(object sender, EventArgs e)
        {
            Escolha escolhaComputador = gerarApostaComputador();
            Escolha escolhaHumano = Escolha.papel;
            bool humanoGanhou = VerificaHumanoGanhou(escolhaHumano, escolhaComputador);
            MessageBox.Show(humanoGanhou ? "Você Ganhou" : "Você Perdeu");
        }

        private void pbTesoura_Click(object sender, EventArgs e)
        {
            Escolha escolhaComputador = gerarApostaComputador();
            Escolha escolhaHumano = Escolha.tesoura;
            bool humanoGanhou = VerificaHumanoGanhou(escolhaHumano, escolhaComputador);
            MessageBox.Show(humanoGanhou ? "Você Ganhou" : "Você Perdeu");
        }
    }
}
