using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Examiner : MonoBehaviour {

	public GameObject TextR;
	public Text description;

	void Update() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if ((Physics.Raycast (ray, out hit, 6)) && hit.collider.tag == "Item") {
			// print("you hit!");
			// Debug.DrawLine(ray.origin, hit.point);
			// print(hit.distance);
			// print (hit.collider.tag);

			TextR.SetActive(true);

			if (TextR){  // and clicked
				// print ("heureka!");
				description.
				// Text description = gameObject.AddComponent("Text");
				// CREATES A HOVERING TEXT THAT WILL FADE IN 30s OVER OBJECT
			}


		} else {
			TextR.SetActive(false);
		}
	}
}