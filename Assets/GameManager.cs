using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	/* --- Hardcoded Attr --- */
	/* Nodes */
	public Transform node1;
	public Transform node2;
	public Transform node3;
	/* Prefab selector */
	public GameObject selector_prefab;


	/* --- Dynamic Attr --- */
	public LineRenderer lineRenderer;
	/* Actual Selector Object*/
	public GameObject selector;
	/* Selected Squad + Ordered Node */
	public GameObject selected;

	void Start () {
		lineRenderer = (LineRenderer) gameObject.AddComponent("LineRenderer");
		lineRenderer.sortingLayerName = "Foreground";
		lineRenderer.SetVertexCount(4);
		lineRenderer.SetWidth(0.1f,0.1f);
	}

	void Update () {
		lineRenderer.SetPosition(0,node1.position);
		lineRenderer.SetPosition(1,node2.position);
		lineRenderer.SetPosition(2,node3.position);
		lineRenderer.SetPosition(3,node1.position);

		/* Left Click */
		if (Input.GetMouseButton (0)) {
			GameObject objClicked= getObjectFromMouse ();
			if (objClicked != null) {
				if (objClicked.tag == "Squad") {
					/* Select Squad */
					selected = objClicked;
				}
			} else {
				/* Deselect Squad */
				selected = null;
			}
		/* Right Click */
		} else if (Input.GetMouseButton (1)) {
			GameObject objClicked = getObjectFromMouse ();
			if (objClicked != null) {
				if (selected != null && objClicked.tag == "Node") {
					SquadInteraction selSquad = selected.GetComponent<SquadInteraction>(); 
					selSquad.target = objClicked;
				}
			}
		}

		/* Manages green selector outline */
		if (selected != null) {
			if(selector == null){
				selector = Instantiate (selector_prefab, selected.transform.position, Quaternion.identity) as GameObject;
			}
			selector.transform.position = selected.transform.position;
		} else {
			Destroy (selector);
		}
	}

	/* Gets game object under mouse */
	GameObject getObjectFromMouse () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit2D hit = Physics2D.Raycast(
			new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
		            Camera.main.ScreenToWorldPoint(Input.mousePosition).y),
			Vector2.zero, 0);

		if (hit.collider == null) {
			return null;
		}

		return hit.collider.gameObject;
	}

}
