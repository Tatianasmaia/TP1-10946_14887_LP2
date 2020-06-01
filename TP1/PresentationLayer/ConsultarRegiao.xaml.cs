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
    /// Interaction logic for ConsultarRegiao.xaml
    /// </summary>
    public partial class ConsultarRegiao : Page
    {
        public ConsultarRegiao()
        {
            InitializeComponent();
        }

        private void bt_Consultar_Click(object sender, RoutedEventArgs e)
        {
            List<Utente> listaAuxiliar = new List<Utente>();

            string regiao = tb_Regiao.Text;

            listaAuxiliar = Rules.ConsultaRegiao(regiao);


            if (listaAuxiliar.Count == 0)
            {
                MessageBox.Show("Nao existe nenhum utente com a regiao que inseriu!");
                Menu expenseReportPage = new Menu();
                this.NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                //dataGridRegiao.ItemsSource = listaAuxiliar;

            }
        }
    }
}
