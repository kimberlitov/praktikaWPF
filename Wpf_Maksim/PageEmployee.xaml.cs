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

namespace Wpf_Maksim
{
    /// <summary>
    /// Логика взаимодействия для PageEmployee.xaml
    /// </summary>
    public partial class PageEmployee : Page
    {
        private bool isDirty = false;
        public PageEmployee()
        {
            InitializeComponent();
        }

        public void UndoCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отмена");
            isDirty = false;
        }
        public void NewCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Создание");
            isDirty = true;
        }
        public void SaveCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Сохранить");
            isDirty = false;
        }
        public void FindCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Найти");
            isDirty = true;
        }
        public void EditCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Редактировать");
            isDirty = true;
        }
        public void DeleteCommandBinding_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
            isDirty = true;
        }
        private void EditCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void DeleteCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void UndoCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void NewCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
        private void SaveCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isDirty;
        }
        private void FindCommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = !isDirty;
        }
    }
}
