#define DEBUG

using System;
using System.Diagnostics;

namespace Application {
    public class Tests {
        public static void Main () {
            System.Console.WriteLine("Running tests!");
            TestGameState.run ();
            System.Console.WriteLine("Tests Finished!");
        }
    }
}
