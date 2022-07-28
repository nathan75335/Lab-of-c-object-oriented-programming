using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizzaClasses
{
    public class FormationOfReport
    {
        OrderCrud orderCrud = new OrderCrud();

        StreamWriter streamwriter = new StreamWriter(@"C:\Users\joyce\OneDrive\Bureau\CoursWorkEv\Report.html");

        public void BeginWritting()
        {

            streamwriter.WriteLine("<html>");
            streamwriter.WriteLine("<head>");
            streamwriter.WriteLine("    <title>HTML-Document</title>");
            streamwriter.WriteLine("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            streamwriter.WriteLine("</head>");
            streamwriter.WriteLine("<body>");
            streamwriter.Write("<h1>Report OF Pizza<h1>");

        }
        public void SumOfIncomeForThisPeriod()
        {
            orderCrud.LoadOrdersFromDatabase();

            var income = (from order in orderCrud.orders
                          select order.Price).Sum();

            streamwriter.WriteLine($"Income For the Last Period {income}<br/> ");
        }

        public void IncomeForEachPizza()
        {
            orderCrud.LoadOrdersFromDatabase();

            var results = (from order in orderCrud.orders
                           group order by order.NameOfPizza into g
                           select new { NameofPizza = g.Key, Price = g.Select(m => m.Price).Sum() });
            streamwriter.WriteLine("<h2>Income For Each Pizza<h2>");
            foreach (var result in results)
            {
                streamwriter.WriteLine($"{result.NameofPizza}    .................  {result.Price}<br/>");
            }

        }

        public void PopulatePizza()
        {
            orderCrud.LoadOrdersFromDatabase();

            var results = (from order in orderCrud.orders
                           group order by order.NameOfPizza into g
                           select new { NameOfPiza = g.Key, NumberOfCommanded = g.Count() }).OrderBy(p => p.NumberOfCommanded);
            streamwriter.WriteLine("<h2>Popularity Of Each Pizza<h2>");
            foreach (var result in results)
            {
                streamwriter.WriteLine($"{result.NameOfPiza}    .................  {result.NumberOfCommanded}<br/>");
            }

        }
        public void IncomePerDay()
        {
            orderCrud.LoadOrdersFromDatabase();
            var results = (from order in orderCrud.orders
                           group order by order.TimeOfOrder.Day into g
                           select new { Day = g.Key, Income = g.Select(m => m.Price).Sum() });
            streamwriter.WriteLine("<h2>Income Per Day <h2>");
            foreach (var result in results)
            {
                streamwriter.WriteLine($"{result.Day}    .................  {result.Income} <br/>");
            }
        }

        public void EndWritting()
        {
            streamwriter.WriteLine("</body>");
            streamwriter.WriteLine("</html>");
            streamwriter.Close();
        }
    }
}
