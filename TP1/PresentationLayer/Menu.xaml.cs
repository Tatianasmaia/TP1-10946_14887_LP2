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

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão Registar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Registar_Click(object sender, RoutedEventArgs e)
        {
            RegistarUtente expenseReportPage = new RegistarUtente();
            this.NavigationService.Navigate(expenseReportPage);
        }

        /// <summary>
        /// Botão Editar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Editar_Click(object sender, RoutedEventArgs e)
        {
            MenuEditar expenseReportPage = new MenuEditar();
            this.NavigationService.Navigate(expenseReportPage);
        }

        /// <summary>
        /// Botão Remover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remover_Click(object sender, RoutedEventArgs e)
        {
            RemoverUtente expenseReportPage = new RemoverUtente();
            this.NavigationService.Navigate(expenseReportPage);
        }

        /// <summary>
        /// Botão Consultar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consultar_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Botão Sair
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sair_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
