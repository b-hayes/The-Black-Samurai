using UnityEngine;
using System.Collections;

public class OpeningScreenButtons : MonoBehaviour {

	//Used to start the game when user click the "Reclaim Your Honor" button...

	public void StartGame(){
		Application.LoadLevel("Level1");
	}

	public void ExitGame(){
		Application.Quit();
	}
}
