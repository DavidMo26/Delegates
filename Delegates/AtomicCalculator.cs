using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class AtomicCalculator
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public AtomicCalculator()
        {
            GetNumberFromUser = SimpleCalculator.NumberGetter;
            MenuPrinter = SimpleCalculator.PrintMenu;
            GetUserChoise = SimpleCalculator.GetUserChoice;
            Calculate = SimpleCalculator.Calculate;
            ResultPrinter = SimpleCalculator.PrintResultNicely;
        }

        public Func<int> GetNumberFromUser { get; set; }
        public Action MenuPrinter { get; set; }
        public Func<int> GetUserChoise { get; set; }
        public Func<int,int,int,double> Calculate { get; set; }
        public Action<double> ResultPrinter { get; set; }
        public void Run()
        {
            X = GetNumberFromUser.Invoke();
            Y = GetNumberFromUser.Invoke();
            MenuPrinter.Invoke();
            int oper = GetUserChoise.Invoke();
            double result = Calculate.Invoke(X, Y, oper);
            ResultPrinter.Invoke(result);
        }

    }
}
