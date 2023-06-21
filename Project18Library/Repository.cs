using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public class Repository
    {
        public List<IAnimal> db;
        /// <summary>
        /// Конструктор, инициализирующий коллекцию IAnimal
        /// </summary>
        public Repository()
        {
            db = new List<IAnimal>();
        }

        public static string loadJsonPath;

        /// <summary>
        /// Конструктор, принимающий набор экземпляров IAnimal, в котором
        /// происходит их перевод в коллекцию List
        /// </summary>
        /// <param name="Args"></param>
        public Repository(IEnumerable<IAnimal> Args)
        {
            db = Args.ToList<IAnimal>();
        }

        /// <summary>
        /// Метод добавления животного, принимающий экземпляр IAnimal
        /// </summary>
        /// <param name="Animal"></param>
        public void Add(IAnimal Animal)
        {
            db.Add(Animal);
        }

        /// <summary>
        /// Метод загрузки информации из json файла
        /// </summary>
        /// <param name="jsonPath"></param>
        public void Open()
        {
            db = JsonConvert.DeserializeObject<List<IAnimal>>(File.ReadAllText($"{loadJsonPath}.json"));
        }
    }
}
