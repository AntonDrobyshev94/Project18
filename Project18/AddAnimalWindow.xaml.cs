using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project18Library;

namespace Project18
{
    /// <summary>
    /// Логика взаимодействия для AddAnimalWindow.xaml
    /// </summary>
    public partial class AddAnimalWindow : Window, IView
    {
        Presenter presenter;
        public AddAnimalWindow()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            AddAnimal();
        }

        /// <summary>
        /// Метод добавления животного в коллекцию IAnimal, в котором
        /// происходит проверка на нажатие кнопок на UI. При нажатии
        /// CancelButton происходит событие, при котором DialogResult
        /// присваивается значение false. При нажатии CreateButton
        /// происходит событие, в котором в блоке try catch производится
        /// попытка добавления животного в коллекцию IAnimal с помощью
        /// метода Add, описанного в библиотеке Project18Library, класса
        /// Presenter. При успехе DialogResult возвращается значение true. 
        /// </summary>
        private void AddAnimal()
        {
            CancelButton.Click += delegate { this.DialogResult = false; };
            CreateButton.Click += delegate
            {
                try
                { 
                    presenter.Add();
                    this.DialogResult = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.DialogResult = false;
                }
            };
        }

        public string TypeOfAnimal { get => this.TxtTypeOfAnimal.Text; }
        new public string Name { get => this.TxtName.Text; }
        public string ClassName { get => this.TxtClassAnimal.Text; }
        

    }
}
