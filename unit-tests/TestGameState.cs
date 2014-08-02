#define DEBUG

using System;
using System.Diagnostics;

namespace Application {
    public class TestGameState {
        
        public static bool run () {
            test_state_id ();
            test_something ();
            System.Console.WriteLine ("TestGameState: DONE");
            return true;
        }

        public static void test_state_id () {
            GameState gs = new GameState ();
            Debug.Assert (gs.state_id != -1);
        }

        public static void test_something () {
            Debug.Assert (true);
        }
    }
}
