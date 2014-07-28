using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public GameObject selected;
	
	public Transform node1;
	public Transform node2;
	public Transform node3;
	
	public LineRenderer lineRenderer;
	
	// Use this for initialization
	void Start () {
		lineRenderer = (LineRenderer) gameObject.AddComponent("LineRenderer");
		lineRenderer.sortingLayerName = "Foreground";
		lineRenderer.SetVertexCount(4);
		lineRenderer.SetWidth(0.1f,0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		lineRenderer.SetPosition(0,node1.position);
		lineRenderer.SetPosition(1,node2.position);
		lineRenderer.SetPosition(2,node3.position);
		lineRenderer.SetPosition(3,node1.position);
	}
}
