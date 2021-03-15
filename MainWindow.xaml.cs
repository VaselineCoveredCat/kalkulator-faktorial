using System.Windows;

namespace Kalkulator_Faktorial
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Hitung_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(TeksAngka.Text, out int angka))
            {
                int hasil = 1;

                if (angka == 0) angka = hasil;

                for (int i = 1; i <= angka; i++) hasil *= i;

                TeksAngka.Clear();
                TeksHasil.Text = hasil.ToString();
            }

            else
            {
                TeksAngka.Clear();
                TeksAngka.Focus();
            }
        }

        private void Keluar_Click(object sender, RoutedEventArgs e) => Close();
    }
}
