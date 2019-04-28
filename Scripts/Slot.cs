using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
	
	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	public GameObject placmentPos;

	#region IDropHandler implementation

	public void OnDrop (PointerEventData eventData)
	{
		if (!item) {
			int otherNumber = DragHandeler.itemBeingDragged.gameObject.GetComponent<DragHandeler> ().objNumber;
			int myNumber = int.Parse (this.gameObject.name);
			if (otherNumber == myNumber) {
				DragHandeler.itemBeingDragged.transform.localPosition = placmentPos.transform.localPosition;
				DragHandeler.itemBeingDragged.transform.SetParent (transform);
				DragHandeler.itemBeingDragged.gameObject.GetComponent<DragHandeler> ().enabled = false;
				GamePlay.Instance.IncreaseSuccessRate ();

			} else {
				GamePlay.Instance.DecreaseLife ();
			}


			// DragHandeler.itemBeingDragged.transform.SetParent(DragHandeler.instance.temp.transform);
		}
	}

	#endregion
}