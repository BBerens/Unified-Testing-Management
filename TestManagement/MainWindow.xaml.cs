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



namespace TestManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Test newTest;
        string testType;
        DataClasses1DataContext testDB = new DataClasses1DataContext("TestDB");
        public MainWindow()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            newTest = new Test(Convert.ToInt32(IdTextBox.Text), NameTestBox.Text, testType, DateTime.Now, DateTime.Now);
            testDB.Tests.InsertOnSubmit(newTest);
            testDB.SubmitChanges();
        }

        private void KayakRadio_Checked(object sender, RoutedEventArgs e)
        {
            testType = KayakRadio.Content.ToString();
            //FilenameTextBox.IsEnabled = true;
            BrowseButton.IsEnabled = true;
        }

        private void QTPRadio_Checked(object sender, RoutedEventArgs e)
        {
            testType = QTPRadio.Content.ToString();
            //FilenameTextBox.IsEnabled = true;
            BrowseButton.IsEnabled = true;
        }

        private void ManualRadio_Checked(object sender, RoutedEventArgs e)
        {
            testType = ManualRadio.Content.ToString();
            //FilenameTextBox.IsEnabled = false;
            BrowseButton.IsEnabled = false;
        }
    }
}
