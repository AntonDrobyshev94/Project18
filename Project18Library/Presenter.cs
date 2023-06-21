using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public class Presenter
    {
        IView view;

        public static Repository animalRep = new Repository();

        /// <summary>
        /// Конструктор Presenter, который принимает IView
        /// </summary>
        /// <param name="View"></param>
        public Presenter(IView View)
        {
            this.view = View;
        }

        /// <summary>
        /// Метод добавления животного в коллекцию IAnimal, который
        /// с помощью метода GetAnimal возвращает экземпляр IAnimal
        /// с присвоенными значениями ClassName, TypeOfAnimal, Name,
        /// передающимися через View модель. Далее, с помощью метода
        /// Add, принимающего данный экземпляр IAnimal происходит
        /// добавление экземпляра в коллекцию IAnimal.
        /// </summary>
        public void Add()
        {
            animalRep.Add(AnimalFactory.GetAnimal(view.ClassName,view.TypeOfAnimal, view.Name));
        }
    }
}
