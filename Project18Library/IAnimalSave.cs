using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public interface IAnimalSave
    {
        /// <summary>
        /// Метод сохранения коллекции животных, который принимает
        /// коллекцию IAnimal
        /// </summary>
        /// <param name="AnimalCollection"></param>
        void SaveAnimalCollection(List<IAnimal> AnimalCollection);
    }
}
