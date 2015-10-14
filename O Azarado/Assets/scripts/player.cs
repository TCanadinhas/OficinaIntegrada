using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {
	public static Animator animator;
	int px = 1;
	void Start () {	

		animator = gameObject.GetComponent<Animator>();
		
	}
	void Update () {
		if (button.stop == false) {

			if (carro.parar == false) {

				if (px < 3)
				if (Input.GetKeyDown ("d") || Input.GetKeyDown (KeyCode.RightArrow))
					px ++;
		
		
				if (px > 0)
				if (Input.GetKeyDown ("a") || Input.GetKeyDown (KeyCode.LeftArrow))
					px--;
		
		
				switch (px) {
			
				case 0:

					if(transform.localPosition.x >= -2.4f)
						transform.Translate(-0.5f,0f,0f);
					break;
			
				case 1:

					if(transform.localPosition.x >= -0.85f)
						transform.Translate(-0.5f,0f,0f);

					if(transform.localPosition.x < -0.85f)
						transform.Translate(0.5f,0f,0f);
					break;
			
				case 2:

					if(transform.localPosition.x >= 0.77f)
						transform.Translate(-0.5f,0f,0f);
					
					if(transform.localPosition.x < 0.77f)
						transform.Translate(0.5f,0f,0f);
					break;
			
				case 3:

					if(transform.localPosition.x < 2.326221f)
						transform.Translate(0.5f,0f,0f);
					break;
			
				}
		
			}
		}

	}
}
