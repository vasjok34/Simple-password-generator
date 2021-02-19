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

namespace Generator
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


        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeneratorPASS pas = new GeneratorPASS();
            pas.GenerateNew(Convert.ToInt32(Tlengtx.Text));
            readyP.Text = pas.sd;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddingPass PA = new AddingPass();
            //PA.write(string.Join ("---------------",readyP.Text,NAme.Text));
            PA.write(readyP.Text, NAme.Text);
        }
    }
}
