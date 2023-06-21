using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    class Fish : IAnimal
    {
        /// <summary>
        /// Конструктор Fish
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="TypeOfAnimal"></param>
        /// <param name="ClassName"></param>
        public Fish(string Name, string TypeOfAnimal, string ClassName)
        {
            this.Name = Name;
            this.TypeOfAnimal = TypeOfAnimal;
            this.ClassName = ClassName;
        }

        //public string Name { get; set; }

        //public string TypeOfAnimal { get; set; }
        //public string ClassName { get; }
    }
}
