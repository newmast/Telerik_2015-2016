namespace PersonClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EntryPoint
    {
        static void Main()
        {
            Person rado = new Person("Rado", 16);
            Person radorado = new Person("RadoRado", null);

            Console.WriteLine(rado.ToString());
            Console.WriteLine(radorado.ToString());
        }
    }
}
