using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.classes;



namespace TestApp.classes
{
    class MainProgram
    {
        static void Main(string[] args)
        {
               DbConnection db = new DbConnection();
               Console.ReadLine();
               db.connectionClose();
               Console.ReadLine();
           

        }
    }
}
