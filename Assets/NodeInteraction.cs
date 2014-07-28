using UnityEngine;
using System.Collections;

public class NodeInteraction : MonoBehaviour {

	public GameManager GM;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseOver () {	
		if (Input.GetMouseButton(1)) {
			SquadInteraction squad = GM.selected.GetComponent<SquadInteraction>(); 
			squad.target = transform.position;
		}
	}
}
