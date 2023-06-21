using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project18Library
{
    public class SaveAnimal
    {
        KeeperDoc saveToDoc = new KeeperDoc("KeeperDoc");
        KeeperJson saveToJson = new KeeperJson("KeeperJson");
        KeeperTxt saveToTxt = new KeeperTxt("KeeperTxt");

        /// <summary>
        /// Метод сохранения коллекции IAnimal в формате doc
        /// </summary>
        public void SaveToDoc()
        {
            AnimalWriter ar = new AnimalWriter(saveToDoc);
            ar.Save(Presenter.animalRep.db);
        }

        /// <summary>
        /// Метод сохранения коллекции IAnimal в формате txt
        /// </summary>
        public void SaveToTxt()
        {
            AnimalWriter ar = new AnimalWriter(saveToTxt);
            ar.Save(Presenter.animalRep.db);
        }

        /// <summary>
        /// Метод сохранения коллекции IAnimal в формате json
        /// </summary>
        public void SaveToJson()
        {
            AnimalWriter ar = new AnimalWriter(saveToJson);
            ar.Save(Presenter.animalRep.db);
        }
    }
}
