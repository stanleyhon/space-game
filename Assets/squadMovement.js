#pragma strict

var speed : float = 3;
var target : Vector3;

function Start () {
	target = transform.position;
}

function Update () {
	transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
}

function OnMouseOver () {
	var gameObject = GameObject.FindGameObjectWithTag("GameController");
	var gameManager : init = gameObject.GetComponent("init");
	if (Input.GetMouseButton(0)) {
		gameManager.selected = this.gameObject;
	}
}
