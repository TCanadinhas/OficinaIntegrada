using UnityEngine;
using System.Collections;

public class instancia : MonoBehaviour {

	public GameObject empty, boeiro, saco, arvore, poste, mendigo;
	float t, x, f;
	int random;
	
	
	// Use this for initialization
	void Start () {
		
	}

	public void turnEmptyTo(int value)
	{
        switch (value)
        {
            case 0:
				empty = boeiro;
                break;

			case 1:
				empty = saco;
                break;

			case 2:
				empty = mendigo;
	            break;

			case 3:
				empty = arvore;
				break;

			case 4:
				empty = poste;
				break;
        }
	}
	
	// Update is called once per frame
	void Update () {

		if (button.stop == false) {

			if (carro.parar == false) {

				f += 0.05f;
		
				t += 0.2f + f * Time.deltaTime;

				if (t >= 50) {
					t = 0;
					random = Random.Range (0, 4);

					switch (random) {
						
					case 0:
						turnEmptyTo(0);
						x = -2.4f;
						//print("coluna 1 || " + empty);
						break;

					case 1:
						turnEmptyTo(Random.Range(0,2));
						x = -0.85f;
						//print("coluna 2 || " + empty);
						break;

					case 2:
						turnEmptyTo(Random.Range(0,5));
						x = 0.77f;
						//print("coluna 3 || " + empty);
						break;
						
					case 3:
						turnEmptyTo(Random.Range(1,4));
						x = 2.326221f;
						//print("coluna 4 || " + empty);
						break;				
					}

					Instantiate (empty, new Vector3 (x, 8f, 0f), Quaternion.identity);
				}
			}
		}
	}
}
