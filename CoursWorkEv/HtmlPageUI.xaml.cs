using MyPizzaClasses;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CoursWorkEv
{
    /// <summary>
    /// Interaction logic for HtmlPageUI.xaml
    /// </summary>
    public partial class HtmlPageUI : Page
    {
        FormationOfReport formationOfReport = new FormationOfReport();
        public HtmlPageUI()
        {
            formationOfReport.BeginWritting();
            formationOfReport.SumOfIncomeForThisPeriod();
            formationOfReport.IncomeForEachPizza();
            formationOfReport.PopulatePizza();
            formationOfReport.IncomePerDay();
            formationOfReport.EndWritting();
            InitializeComponent();
            FileStream fs = new FileStream(@"C:\Users\joyce\OneDrive\Bureau\CoursWorkEv\Report.html", FileMode.OpenOrCreate, FileAccess.Read);

            webBrowser.NavigateToStream(fs);
        }
    }
}
