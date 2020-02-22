using System;
using List;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class Program
    {
        static void Main(string[] args)
        {
            var igor = new Notebook(1, "Igor");
            var vasia = new Notebook(2, "vasia");
            var kurlik = new Notebook(3, "KYPJIbIK");
            var acer = new Notebook(2432, "Acer");
            var asus = new Notebook(4897, "Asus");

            var newList = new TwoLinkedCustomList<Notebook>();

            newList.Add(igor);
            newList.Add(vasia);
            newList.Add(kurlik);
            newList.Add(acer);
            newList.Add(asus);
            foreach (var notebook in newList)
                Console.WriteLine("{0} {1}", notebook.Name, notebook.SerialNumber);

            newList.Delete(newList[1]);
            newList.Delete(newList[3]);

            Console.WriteLine();
            Console.WriteLine("===================");
            Console.WriteLine();

            foreach (Notebook notebook in newList)
                Console.WriteLine("{0} {1}", notebook.Name, notebook.SerialNumber);
            Console.ReadKey();
        }
    }
}
