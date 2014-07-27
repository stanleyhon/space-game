var selected : GameObject;

var node1 : Transform;
var node2 : Transform;
var node3 : Transform;

var lineRenderer : LineRenderer ;

function Start () {
	lineRenderer = gameObject.AddComponent("LineRenderer");
	lineRenderer.sortingLayerName = "Foreground";
	lineRenderer.SetVertexCount(4);
	lineRenderer.SetWidth(0.1f,0.1f);
}

function Update () {
	lineRenderer.SetPosition(0,node1.position);
	lineRenderer.SetPosition(1,node2.position);
	lineRenderer.SetPosition(2,node3.position);
	lineRenderer.SetPosition(3,node1.position);
}