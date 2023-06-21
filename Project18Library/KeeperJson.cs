using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Project18Library
{
    class KeeperJson : IAnimalSave
    {
        private string nameOfFile;
        public KeeperJson(string NameOfFile)
        {
            this.nameOfFile = NameOfFile;
        }

        /// <summary>
        /// Метод сохранения коллекции IAnimal в файле формата json
        /// </summary>
        /// <param name="animalList"></param>
        public void SaveAnimalCollection(List<IAnimal> animalList)
        {
            File.WriteAllText($"{nameOfFile}.json", JsonConvert.SerializeObject(animalList));
        }
    }
}
