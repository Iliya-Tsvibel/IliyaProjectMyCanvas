using ConsoleApp45;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        public static void Main(string[] args)
        {

            MyCanvas.CreateNewButton(8, 8, 12, 12);
            MyCanvas.CreateNewButton(7, 7, 16, 16);
            MyCanvas.CreateNewButton(9, 9, 21, 21);

            MyCanvas.MoveButton(0, 7, 99);

            if (MyCanvas.CheckIfAnyButtonIsOverLapping() == true)
            {
                Console.WriteLine("This button is over lapping");
            }

            MyCanvas.GetMaxNumberOfNumberOfButtons();

            MyCanvas.GetCurrentNumberOfButtons();


            


            MyCanvas.Print();




        }

    }
}
