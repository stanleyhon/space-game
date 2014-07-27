#pragma strict


function Start () {

}

function Update () {
	
}

function OnMouseOver () {
	var gameObject = GameObject.FindGameObjectWithTag("GameController");
	var gameManager : init = gameObject.GetComponent("init");
	
	if (Input.GetMouseButton(1)) {
		var selectObj : squadMovement = gameManager.selected.GetComponent("squadMovement");
		selectObj.target = transform.position;

	}
}
