using UnityEngine;
using System.Collections;

public class SquadInteraction : MonoBehaviour {

	public GameManager GM;
	public float speed = 3;
	public Vector3 target;
	
	// Use this for initialization
	void Start () {
		target = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}

	void OnMouseOver () {
		if (Input.GetMouseButton(0)) {
			GM.selected = this.gameObject;
		}
	}
}
