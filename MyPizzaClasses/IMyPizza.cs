using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public interface IMyPizza
    {
        string Description { get; set; }
        string Name { get; set; }
        string Picture { get; set; }
        int PizzaId { get; set; }
        decimal Price { get; set; }
    }
}
