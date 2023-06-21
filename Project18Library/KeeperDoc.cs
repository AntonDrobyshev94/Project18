using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    class KeeperDoc : IAnimalSave
    {
        private string nameOfFile;
        public KeeperDoc(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        /// <summary>
        /// Метод сохранения коллекции IAnimal в doc файле, в котором
        /// происходит преебор коллекции в цикле foreach с записью полей
        /// Name,ClassName,TypeOfAnimal в строковую переменную с последующим
        /// открытием потока StreamWriter и записью переменных в файл.
        /// Название файла передается при инициализации сохранения в MainWindow. 
        /// </summary>
        /// <param name="AnimalCollections"></param>
        public void SaveAnimalCollection(List<IAnimal> AnimalCollections)
        {
            string animalColText = string.Empty;
            foreach (var item in AnimalCollections)
            {
                if (item.GetType() == typeof(Mammals))
                {
                    var mammals = (Mammals)item;
                    animalColText += $"Название вида: {mammals.Name}\nКлассовая принадлежность:{mammals.ClassName}\nТип питания: {mammals.TypeOfAnimal}\n";
                }
                else if (item.GetType() == typeof(Fish))
                {
                    var fish = (Fish)item;
                    animalColText += $"Название вида: {fish.Name}\nКлассовая принадлежность:{fish.ClassName}\nТип питания: {fish.TypeOfAnimal}\n";
                }
                else if (item.GetType() == typeof(Birds))
                {
                    var bird = (Birds)item;
                    animalColText += $"Название вида: {bird.Name}\nКлассовая принадлежность:{bird.ClassName}\nТип питания: {bird.TypeOfAnimal}\n";
                }
                else
                {
                    var nullAnimal = (NullAnimal)item;
                    animalColText += $"Название вида: {nullAnimal.Name}\nКлассовая принадлежность:{nullAnimal.ClassName}\nТип питания: {nullAnimal.TypeOfAnimal}\n";
                }
            }
            using (StreamWriter sw = new StreamWriter($"{nameOfFile}.doc"))
            {
                sw.WriteLine(animalColText);
            }
        }
    }
}
