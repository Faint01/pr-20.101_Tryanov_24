using pr_20._101_Tryanov_2.Entity;
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

namespace pr_20._101_Tryanov_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities db = new Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bd_Teac_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           

        }

        private void Windows_Loaded(object sender, RoutedEventArgs e)// вывод данных на экран
        {
            var query =
                from Teachers in db.Teachers
                where Teachers.IdSpeciality == 1
                orderby Teachers.FirstName 
                select new { Teachers.IdTeachers, Teachers.LastName, Teachers.FirstName, Teachers.Patronymic, Teachers.Email, Teachers.IdStatusTeachers, Teachers.IdRole, Teachers.IdSpeciality };

            bd_Teac.ItemsSource = query.ToList();
        }
    }
}
