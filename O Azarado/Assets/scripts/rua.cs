using UnityEngine;
using System.Collections;

public class rua : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (button.stop == false) {
			transform.Translate (0f, -5f * Time.deltaTime, 0f);
			if (transform.localPosition.y <= -2302f)
				transform.localPosition = new Vector3 (0f, 5500f, 0f);
		}
	
	}
}
