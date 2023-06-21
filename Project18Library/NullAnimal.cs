using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    class NullAnimal : IAnimal
    {
        /// <summary>
        /// Конструктор NullAnimal
        /// </summary>
        public NullAnimal()
        {
            this.Name = "Not Determined";
            this.TypeOfAnimal = "Not Determined";
            this.ClassName = "Not Determined";
        }
        public string Name { get; set; }
        public string TypeOfAnimal { get; set; }
        public string ClassName { get; set; }
    }
}
