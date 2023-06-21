using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public class AnimalWriter
    {
        public IAnimalSave Mode { get; set; }

        public static List<IAnimal> AnimalCollection { get; set; }

        /// <summary>
        /// Конструктор AnimalWriter, принимающий IAnimalSave
        /// </summary>
        /// <param name="Method"></param>
        public AnimalWriter(IAnimalSave Method)
        {
            this.Mode = Method;
        }

        /// <summary>
        /// Метод, принимающий коллекцию IAnimal, в котором происходит
        /// присвоение коллекции AnimalCollection свойству AnimalCollection
        /// и запуск метода SaveAnimalCollection, который сохраняет
        /// полученную коллекцию.
        /// </summary>
        /// <param name="AnimalCollectionStr"></param>
        public void Save(List<IAnimal> AnimalCollectionStr)
        {
            AnimalCollection = AnimalCollectionStr;
            Mode.SaveAnimalCollection(AnimalCollection);
        }
    }
}
