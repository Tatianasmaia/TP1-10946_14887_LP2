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
            //int aux = Rules.EditarInformacao(tb_Nome.Text, tb_Idade.Text, tb_Nif.Text, tb_Regiao.Text, tb_Sexo.Text);

            //if (aux==0)

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
