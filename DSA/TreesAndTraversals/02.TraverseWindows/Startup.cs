namespace TraverseWindows
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private const string FilePath = "C:\\WINDOWS";
        static void Main()
        {
            TraverseDirectory(FilePath);
        }

        public static void TraverseDirectory(string path)
        {
            string[] allDirectories = null;

            try
            {
                allDirectories = Directory.GetDirectories(path);
            }
            catch (UnauthorizedAccessException e)
            {
                return;
            }

            var allFiles = Directory.GetFiles(path)
                    .Where(name => name.EndsWith(".exe"));

            foreach (var file in allFiles)
            {
                Console.WriteLine(file);
            }

            foreach (var dir in allDirectories)
            {
                TraverseDirectory(dir);
            }
        }
    }
}
