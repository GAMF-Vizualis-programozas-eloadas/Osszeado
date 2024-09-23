using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Osszeado
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

		private void btSzámol_Click(object sender, RoutedEventArgs e)
		{
			if (!double.TryParse(tbElső.Text, out double a))
			{
				MessageBox.Show("Hibás érték az első mezőben!",
					"Hiba",MessageBoxButton.OK, MessageBoxImage.Error);
			}
			if (!double.TryParse(tbMásodik.Text, out double b))
			{
				MessageBox.Show("Hibás érték a második mezőben!",
					"Hiba", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			tbEredmény.Text = (a + b).ToString();
		}

		private void btKilép_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}