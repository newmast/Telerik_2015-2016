﻿using System;
using Test3D;

namespace Gravity
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Test3DDemo2())
            {
                game.Run();
            }
        }
    }
#endif
}