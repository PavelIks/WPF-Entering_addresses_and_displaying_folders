using System.IO;
using System.Windows;

namespace AddressFolders
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*var path = @"D:\Programs";*/
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = @"" + TextBox1.Text + "";
                string[] normies = new string[Directory.GetDirectories(path).Length];
                for (int i = 0; i < normies.Length; i++)
                {
                    normies[i] = Directory.GetDirectories(path)[i]/*.Split('\\')[0]*/;
                }
                ComboBox1.ItemsSource = normies;

                Label1.Visibility = Visibility;
                Label1.Content = "Путь указан!";
            }
            catch
            {
                Label1.Visibility = Visibility;
                Label1.Content = "Неверный путь!";
            }
        }
    }
}