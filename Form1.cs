using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5_RA6322501
{
    public partial class Frm_Jogador : Form
    {
        public Frm_Jogador()
        {
            InitializeComponent();
        }

        private void Frm_Jogador_Load(object sender, EventArgs e)
        {

        }
        Jogador player;
        Jogador[] vetorJogador = new Jogador[3];
        int i = 0;

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                player = new Jogador();
                player.Nome = Txt_Nome.Text;
                player.Peso = Convert.ToDouble (Txt_Peso.Text);
                player.Altura = Convert.ToDouble(Txt_Altura.Text);
                player.Idade = Convert.ToInt32(Txt_Idade.Text);
                player.Camisa = Convert.ToInt32(Txt_Camisa.Text);
                player.Time = Txt_Time.Text;
                vetorJogador[i] = player;
                MessageBox.Show("Jogador Salvo.");
                Txt_Nome.Text = "";
                Txt_Peso.Text = "";
                Txt_Altura.Text = "";
                Txt_Idade.Text = "";
                Txt_Camisa.Text = "";
                Txt_Time.Text = "";
                i++;
            }
            else
            {
                MessageBox.Show("Não é possível salvar esses dados.");
            }
        }

        private void Btn_Pesquisa_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 3; j++)
            {
                if (vetorJogador[j].Nome.Equals(Txt_Pesquisar.Text))
                {
                    Txt_Nome.Text = vetorJogador[j].Nome;
                    Txt_Peso.Text = vetorJogador[j].Peso.ToString();
                    Txt_Altura.Text = vetorJogador[j].Altura.ToString();
                    Txt_Idade.Text = vetorJogador[j].Idade.ToString();
                    Txt_Camisa.Text = vetorJogador[j].Camisa.ToString();
                    Txt_Time.Text = vetorJogador[j].Time;
                    j = 2;
                    Btn_Pesquisa.Text = "Outra pesquisa?";
                    Txt_Pesquisar.Text = "";
                }
                else
                {
                    if (j == 2)
                    {
                        MessageBox.Show("Jogador não encontrado!");
                        Btn_Pesquisa.Text = "Outra pesquisa?";
                        Txt_Pesquisar.Text = "";
                    }
                }
            }
        }
    }
}
