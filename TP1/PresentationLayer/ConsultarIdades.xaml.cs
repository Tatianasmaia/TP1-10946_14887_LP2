using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BO;
using BR;

namespace PresentationLayer
{
    /// <summary>
    /// Interaction logic for ConsultarIdades.xaml
    /// </summary>
    public partial class ConsultarIdades : Page
    {
        public ConsultarIdades()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Botão consultar utentes através da idade introduzida pelo utilizador
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Consultar_Click(object sender, RoutedEventArgs e)
        {
            List<Utente> listaAuxiliar = new List<Utente>();

            int idade = Int32.Parse(tb_Idade.Text);

            listaAuxiliar = Rules.ConsultaIdades(idade);


            if (listaAuxiliar.Count == 0)
            {
                MessageBox.Show("Nao existe nenhum utente com a idade que inseriu!");
                Menu expenseReportPage = new Menu();
                this.NavigationService.Navigate(expenseReportPage);
            }
            else
            {
                dataGridIdades.ItemsSource = listaAuxiliar;
               
            }

        }
    }
}
