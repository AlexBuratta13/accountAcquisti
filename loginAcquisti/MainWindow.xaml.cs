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

namespace loginAcquisti
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtPrezzo.IsEnabled = false;
            txtQuantità.IsEnabled = false;
            btnPulisci.IsEnabled = false;
            btnStampa.IsEnabled = false;
            ltbRisultato.IsEnabled = false;
            btnRimuoviSelezione.IsEnabled = false;
            cmbProdotto.IsEnabled = false;
        }
        private const string PASSWORD = "Hello";
        private string utente;

        private void btnAccedi_Click(object sender, RoutedEventArgs e)
        {
            utente = txtUtente.Text;
            string pass = txtPassword.Text;

            if (utente != "" && utente != null && pass == PASSWORD)
            {
                txtPrezzo.IsEnabled = true;
                txtQuantità.IsEnabled = true;
                cmbProdotto.IsEnabled = true;
                btnPulisci.IsEnabled = true;
                btnStampa.IsEnabled = true;
                ltbRisultato.IsEnabled = true;
                btnRimuoviSelezione.IsEnabled = true;
                txtUtente.IsEnabled = false;
                txtPassword.IsEnabled = false;
                btnAccedi.IsEnabled = false;
            }
            else if (utente == "" || utente == null)
            {
                MessageBox.Show("Inserisci un utente valido", "", MessageBoxButton.OK, MessageBoxImage.Error);
                txtUtente.Text = "";
                txtPassword.Text = "";
                txtUtente.Focus();
            }
            else if (pass != PASSWORD)
            {
                MessageBox.Show("Password errata, Riprova", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }
    }
}
