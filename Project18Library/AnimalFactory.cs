using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    static class AnimalFactory
    {
        /// <summary>
        /// Метод, который возвращает тип IAnimal. Принимает в себя класс
        /// животного, тип животного и имя животного. В зависимости от
        /// значения ClassAnimal происходит возвращение экземпляра 
        /// Mammals/Birds/Fish или NullAnimal с указанными параметрами
        /// Name, TypeOfAnimal. Значение ClassName присваивается в
        /// зависимости от ClassAnimal
        /// </summary>
        /// <param name="ClassAnimal"></param>
        /// <param name="TypeOfAnimal"></param>
        /// <param name="Name"></param>
        /// <returns></returns>
        public static IAnimal GetAnimal(string ClassAnimal,
                                        string TypeOfAnimal,
                                        string Name)
        {
            switch (ClassAnimal)
            {
                case "Млекопитающие": return new Mammals(Name, TypeOfAnimal, "Млекопитающие");
                case "Млекопитающее": return new Mammals(Name, TypeOfAnimal, "Млекопитающие");
                case "Птицы": return new Birds(Name, TypeOfAnimal, "Птицы");
                case "Птица": return new Birds(Name, TypeOfAnimal, "Птицы");
                case "Рыбы": return new Fish(Name, TypeOfAnimal, "Рыбы");
                case "Рыба": return new Fish(Name, TypeOfAnimal, "Рыбы");
                default: return new NullAnimal();
            }
        }
    }
}
