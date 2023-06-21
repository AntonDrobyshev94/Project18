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
using Project18Library;

namespace Project18
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IAnimal iAnimalHighlight;
        SaveAnimal saveAnimal = new SaveAnimal();
        public MainWindow()
        {
            InitializeComponent();
            
            DataGridView.ItemsSource = Presenter.animalRep.db;

            SaveButtonDoc.Click += (s, e) => saveAnimal.SaveToDoc();
            SaveButtonTxt.Click += (s, e) => saveAnimal.SaveToTxt();
            SaveButtonJson.Click += (s, e) => saveAnimal.SaveToJson();
            LoadButtonJson.Click += (s, e) => {
                try 
                {
                    Repository.loadJsonPath = TextBoxJsonLoadText.Text;
                    Presenter.animalRep.Open();
                    DataGridView.ItemsSource = Presenter.animalRep.db;
                    DataGridView.Items.Refresh();
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message);  
                } 
            };
        }

        /// <summary>
        /// Метод, инициализируемый нажатием кнопки на UI, в котором
        /// происходит создание экземпляра нового окна WPF и переключение
        /// на данное окно. По окончанию происходит обновление DataGridView.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddAnimalWindow addAnimalWindow = new AddAnimalWindow();
            addAnimalWindow.ShowDialog();
            if (addAnimalWindow.DialogResult.Value)
            {
                DataGridView.Items.Refresh();
            }
        }

        /// <summary>
        /// Метод, инициализируемый нажатием кнопки на UI, в котором
        /// происходит удаление выбранного на DataGrid экземпляра IAnimal,
        /// полученного с помощью свойства SelectedItem DataGrid. Далее
        /// происходит удаление элемента коллекции animalRep.db с помощью 
        /// метода Remove.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                iAnimalHighlight = (IAnimal)DataGridView.SelectedItem;
                Presenter.animalRep.db.Remove(iAnimalHighlight);
                DataGridView.Items.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
