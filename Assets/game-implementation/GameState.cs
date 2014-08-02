
using System;

namespace Application {
    public class GameState {

        public int state_id = -1;
        private static int next_id = 0;

        public GameState () {
            state_id = next_id;
            next_id++;
        }
    }
}

