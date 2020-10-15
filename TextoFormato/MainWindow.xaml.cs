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

namespace TextoFormato
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void textoEntranteTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Text = textoEntranteTextBox.Text;
        }

        private void negritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontWeight= FontWeights.Bold;
        }

        private void cursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontStyle = FontStyles.Italic;
        }

        private void negritaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontWeight = FontWeights.Normal;
        }

        private void cursivaCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.FontStyle = FontStyles.Normal;
        }

        private void azulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(textoFinalTextBlock!=null)
                textoFinalTextBlock.Foreground = Brushes.Blue;
        }

        private void rojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Foreground = Brushes.Red;
        }

        private void verdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            textoFinalTextBlock.Foreground = Brushes.Green;
        }
    }
}
