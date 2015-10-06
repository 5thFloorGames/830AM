using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Examiner : MonoBehaviour {

	public GameObject TextExamine;
	public List<string> CollectedAttributes = new List<string>();
	// public string[] CollectedAttributes;

	void Update() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if ((Physics.Raycast (ray, out hit, 6)) && hit.collider.tag == "Item") {
			// print(hit.distance) // print (hit.collider.tag);

			TextExamine.SetActive (true);

			if (TextExamine && Input.GetMouseButtonDown (0)) {

				// ITEMI EI OLE VIELÄ TUTKITTU
				if (hit.collider.gameObject.GetComponent<Information>().inspected == true) {
					foreach (string s in hit.collider.gameObject.GetComponent<Information>().attributes) {
						CollectedAttributes.Add (s);
						print ("mitä jäi jäljel:" + hit.collider.gameObject.GetComponent<Information> ().attributes);
						print ("here:" + CollectedAttributes);
					}
					hit.collider.gameObject.GetComponent<Information>().inspected = false;
				}
				// description.
				// Text description = gameObject.AddComponent("Text");
				// CREATES A HOVERING TEXT THAT WILL FADE IN 30s OVER OBJECT

				// GOES THRU ALL element attributes and logs them into the variable
				// foreach (hit.attribute){
				//	print(hit.collider.);
			}
		}
		else {
			TextExamine.SetActive(false);
		}
	}
}