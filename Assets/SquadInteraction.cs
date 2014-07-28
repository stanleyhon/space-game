using UnityEngine;
using System.Collections;

public class SquadInteraction : MonoBehaviour {

	/* --- Hardcoded Attr --- */
	public GameManager GM;
	public float speed = 3;

	/* --- Dynamic Attr --- */
	public GameObject target;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (target != null) {
			transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);

			/* Squad has arrived */
			if (transform.position == target.transform.position) {
				target = null;
			}
		}
	}
	
}
