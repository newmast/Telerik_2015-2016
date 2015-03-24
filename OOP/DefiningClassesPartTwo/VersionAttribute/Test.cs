namespace VersionAttribute
{
    using System;
    using System.Linq;
    using System.Reflection;

    [Attributes("2.11")]
    class Test
    {
        static void Main(string[] args)
        {
            var attribs = typeof(Test).GetCustomAttributes<Attributes>();

            foreach (var attribute in attribs)
            {
                Console.WriteLine("Version: " + attribute.Version);
            }
        }
    }
}