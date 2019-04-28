using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragHandeler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public static DragHandeler instance;
	public static GameObject itemBeingDragged;
	Vector3 startPosition;
	public GameObject temp;
	Transform startParent;
	public int objNumber;

	void Awake ()
	{
		if (instance == null)
			instance = this;
	}

	#region IBeginDragHandler implementation

	public void OnBeginDrag (PointerEventData eventData)
	{
		itemBeingDragged = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	#endregion

	#region IDragHandler implementation

	public void OnDrag (PointerEventData eventData)
	{
		transform.position = eventData.position;
	}

	#endregion

	#region IEndDragHandler implementation

	public void OnEndDrag (PointerEventData eventData)
	{
		itemBeingDragged = null;
		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		if (transform.parent == startParent) {
			transform.position = startPosition;
			//transform.position = temp.transform.position;

			Debug.Log ("setting the value");
		}
	}

	#endregion

	private void OnTriggerEnter2D (Collider2D other)
	{
		Debug.Log ("OnTriggerEnter2D");
		if (other.gameObject.tag == "1" && this.gameObject.tag == "1") {
			Debug.Log ("The Value of Tag = " + tag);
			transform.position = temp.transform.position;
		} else if (other.gameObject.tag == "2" && this.gameObject.tag == "2") {
			Debug.Log ("The Value of Tag = " + tag);
			transform.position = temp.transform.position;
		}
	}

}
