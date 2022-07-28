using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public interface IMyPizzaCrud
    {
        List<IMyPizza>? pizzaList { get; set; }

        bool DeletePizzaFromDataBase(IMyPizza pizza);
        IMyPizza GetPizzaByName(string Name);
        bool InsertANewPizzaToDatabase(IMyPizza pizza);
        bool LoadPizzaFromDataBase();
        bool UpdatePizza(IMyPizza pizza);
    }
}
