using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public interface IView
    {
        string Name { get; }
        string TypeOfAnimal { get; }
        string ClassName { get; }
    }
}
