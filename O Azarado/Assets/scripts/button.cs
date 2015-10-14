using UnityEngine;
using System.Collections;

public class button : MonoBehaviour {

	public static bool stop = false;

	void Start () {
	
	}

	void Update () {
		if(Input.GetKeyDown("p")){
		if (stop == false) {
			stop = true;
		}
		else
			
			stop = false;
		}

		if (Input.GetKeyDown ("r")) {
			Application.LoadLevel (Application.loadedLevel);
			dist.d.fillAmount = 1;
		}

		if(Input.GetKeyDown("b"))
			Application.LoadLevel ("inicial");

	}

	public void Creditos(){

		Application.LoadLevel ("Creditos");

	}

	public void sair(){
		
		Application.Quit();
		
	}

	public void voltar(){
		
		Application.LoadLevel ("inicial");
		
	}

	public void jogo(){
		//dist.d.fillAmount = 1;
		//time.tempo.fillAmount = 1;
		Application.LoadLevel ("Jogo");
		
	}

	public void fases(){
		
		Application.LoadLevel ("Fases");
		
	}

	public void reset(){
		
		Application.LoadLevel (Application.loadedLevel);
		dist.d.fillAmount = 1;
		time.tempo.fillAmount = 1;
		
	}

	public void fase2(){
		
		Application.LoadLevel ("Fase2");
		
	}

	public void pause(){
		if (stop == false) {
			stop = true;
		}
		else

			stop = false;

	}

}
