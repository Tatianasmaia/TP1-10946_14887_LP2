using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BO;
using BR;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for EditarInformacao.xaml
    /// </summary>
    public partial class EditarInformacao : Page
    {
        public EditarInformacao()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Editar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tb_numU.Text)){

                MessageBox.Show("Tem que inserir um número de utente!");
                //Voltar ao menuEditar / EditarInformacao
            }

            int numU = Int32.Parse(tb_numU.Text);

            int aux = Rules.EditarInformacao(tb_Nome.Text, tb_Idade.Text, tb_Nif.Text, tb_Regiao.Text, tb_Sexo.Text, numU);

            if (aux == 0)
            {
                MessageBox.Show("Não preencheu nenhum campo!");
            }
            else if (aux == 1)
            {
                MessageBox.Show("A idade que inseriu não é válida!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("O nif que inseriu não têm o número de dígitos correto!");
            }
            else if (aux == 3)
            {
                MessageBox.Show("O nif que inseriu já foi registado por outro utente!");
            }
            else if (aux == 4)
            {
                MessageBox.Show("O utente foi alterado com sucesso!");
            }
            else if (aux == 5)
            {
                MessageBox.Show("O número de utente que inseriu não existe!");
            }

            //Sempre que há alterações na lista temos que atualizar o ficheiro
            Rules.Save("listaUtentes");
            //Dar Clear
            Rules.Load("listaUtentes");

        }

        //private void Sair_Click(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
