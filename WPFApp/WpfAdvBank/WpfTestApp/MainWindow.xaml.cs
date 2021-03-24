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

namespace WpfTestApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //List<Person> list = new List<Person>();
            //list.Add(new Person("da", "dasd"));
            //list.Add(new Person("daa", "sddasd"));
            //list.Add(new Person("das", "dasdassd"));
            //list.Add(new Person("dada", "dasddasd"));
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            //PersonList people = new PersonList();
            //this.DataContext = people;
        }

        private void lstbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var temp = lstbox.SelectedItem as Person;
                TxtNormal.Text = $"{temp.FirstName} {temp.LastName}";
                TxtLastFirst.Text = $"{temp.LastName}, {temp.FirstName}";
            }
            catch (Exception)
            {

            }
            
        }
    }
}
