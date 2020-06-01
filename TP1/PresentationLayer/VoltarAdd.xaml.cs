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
    /// Interaction logic for VoltarAdd.xaml
    /// </summary>
    public partial class VoltarAdd : Page
    {
        public VoltarAdd()
        {
            InitializeComponent();
        }

        private void bt_VoltarAdd_Click(object sender, RoutedEventArgs e)
        {
            int num;

            if (string.IsNullOrEmpty(tb_num.Text))
            {
                MessageBox.Show("É necessário inserir um número!");
                Menu voltar = new Menu();
                this.NavigationService.Navigate(voltar);
            }
            
            try
            {
                num = Int32.Parse(tb_num.Text);
            }
            catch
            {
                throw new Exception("Cadeia de caracteres invalida");
            }
            

            int aux = Rules.EditaUtente2(num);

            if (aux == 0)
            {
                MessageBox.Show("Não existe nenhum utente registado!");
               
            }
            else if (aux == 1)
            {
                MessageBox.Show("Não existe nenhum utente com esse número de utente!");
            }
            else if (aux == 2)
            {
                MessageBox.Show("Utente Adicionado com sucesso aos utentes infetados!");
            }

            //Sempre que há alterações nas listas temos que atualizar os ficheiros
            Rules.Save("listaUtentes");
            //Dar Clear
            Rules.Load("listaUtentes");

            Rules.SaveHistoricoU("historicoUtentes");
            //Dar Clear
            Rules.LoadHistoricoU("historicoUtentes");

            //Voltar ao menu
            Menu expenseReportPage = new Menu();
            this.NavigationService.Navigate(expenseReportPage);

        }
    }
}
