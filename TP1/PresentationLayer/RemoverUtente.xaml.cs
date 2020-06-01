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
    /// Interaction logic for RemoverUtente.xaml
    /// </summary>
    public partial class RemoverUtente : Page
    {
        public RemoverUtente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Remover Utente de Infetados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remover_Click(object sender, RoutedEventArgs e)
        {

            int num;

            try
            {
                num = Int32.Parse(tb_Num.Text);
            }
            catch
            {
                throw new Exception("Cadeia de caracteres invalida!");
            }


            int aux = Rules.RemoveUtente(num);

            if (aux == 0)
            {
                MessageBox.Show("Não existe nenhum utente registado!");
                Menu registar = new Menu();
            }
            else if (aux == 1)
            {
                MessageBox.Show("Não existe nenhum utente com esse número de utente!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("Utente removido com sucesso!");
            }

            //Voltar ao menu
            Menu expenseReportPage = new Menu();
            this.NavigationService.Navigate(expenseReportPage);

            //Sempre que há alterações nas listas temos que atualizar os ficheiros
            Rules.Save("listaUtentes");
            //Dar Clear
            Rules.Load("listaUtentes");

            Rules.SaveHistoricoU("historicoUtentes");
            //Dar Clear
            Rules.LoadHistoricoU("historicoUtentes");
        }
    }
}
