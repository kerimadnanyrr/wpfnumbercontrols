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

namespace odev1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Hesapla_Click(object sender, RoutedEventArgs e)
        {
            int sayi, kontrol=0,toplam=0;
            sayi = Convert.ToInt32(inputName.Text);
            if (sayi%2==0)
            {
                outputTek.Text = "sayı çift sayıdır";
            }
            else
            {
                outputTek.Text = "sayı tek sayıdır";

            }
            //******************************************************************
            for (int i = 2; i < sayi; i++)
            {
                if (sayi %i ==0)
                {
                    kontrol++;
                }

            }
            if (kontrol !=0)
            {
                outputAsal.Text = "sayı asal degıldır";
            }
            else
            {
                outputAsal.Text = "sayı asal ";

            }
            //******************************************************************

            for (int i = 1; i < sayi; i++)
            {
                if (sayi %i==0)
                {
                    toplam = toplam + i;
                }
            }
            if (toplam==sayi)
            {
                outputMuk.Text = "Sayı mükemmeldir";
            }
            else
            {
                outputMuk.Text = "sayı mukemmel degıldır";
            }
        }
    }
}
