using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class dist : MonoBehaviour {

	public static Image d;
	
	void Start () {
		
		d = GetComponent<Image>();
		
	}
	
	
	void Update () {
		
		if(button.stop == false) {
			d.fillAmount -= 0.014f * Time.deltaTime;
			
			if(d.fillAmount == 0)
				Application.LoadLevel("inicial");
		}
		
	}
}