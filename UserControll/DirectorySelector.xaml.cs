using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace UserControll
{
    
    /// <summary>
    /// Lógica de interacción para DirectorySelector.xaml
    /// </summary>
    public partial class DirectorySelector : UserControl
    {
        
        public DirectorySelector()
        {
            InitializeComponent();
            this.DataContext = this;
            rutaTextBox.DataContext = this;
        }

        public string Titulo
        {
            get { return (string)GetValue(TituloProperty); }
            set { SetValue(TituloProperty, value); }
        }
        public string Ruta
        {
            get { return (string)GetValue(RutaProperty); }
            set { SetValue(RutaProperty, value); }
        }



        public static readonly DependencyProperty TituloProperty 
            = DependencyProperty.Register("Titulo", typeof(string), typeof(DirectorySelector), new PropertyMetadata(""));
        public static readonly DependencyProperty RutaProperty
            = DependencyProperty.Register("Ruta", typeof(string), typeof(DirectorySelector), new PropertyMetadata(""));





        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            System.Windows.Forms.FolderBrowserDialog dialogo = new System.Windows.Forms.FolderBrowserDialog();
            System.Windows.Forms.DialogResult resultado = dialogo.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                string ruta = dialogo.SelectedPath;
                rutaTextBox.Text = ruta;
                Ruta = ruta;
            }
        }
    }
}
