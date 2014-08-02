// In the MVC model, this class sits between the unity engine
// and the game implementation as the 'controller'.

using UnityEngine;
using System.Collections;

namespace Application {
    public class Controller : MonoBehaviour {

        // TODO: This should probably not be public
        public GameState gameState;

	    // Use this for initialization
	    void Start () {
            gs = new GameState ();
            Debug.Log ("A new game has begun with ID " + gs.state_id);
	    }
	
	    // Update is called once per frame
	    void Update () {
	        
	    }
    }
}
