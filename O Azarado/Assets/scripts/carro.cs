using UnityEngine;
using System.Collections;

public class carro : MonoBehaviour {

	public static float p;
	private GameObject boeiro;
	public static bool parar = false;
	float vel;

	// Use this for initialization
	void Start () 
	{
		boeiro = GameObject.Find ("boeiro");
	}
	
	// Update is called once per frame
	void Update () {
		if (button.stop == false) 
		{
			vel = -5f * Time.deltaTime;
		
				p = transform.localPosition.y;
		
				transform.Translate (0f, vel, 0f);

				if (p <= -10) { 
					Destroy (gameObject);
			}
		}
	}
	void OnTriggerEnter2D(Collider2D coll){
		
		if (coll.gameObject.tag == "Player")
		{
			time.tempo.fillAmount -= 0.03f;
			Destroy (gameObject);
		}
	}

}
