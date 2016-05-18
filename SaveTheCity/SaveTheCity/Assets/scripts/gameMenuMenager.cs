using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameMenuMenager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

     public void startGame()
     {
          SceneManager.LoadScene(1);

     }

     public void exitMenu()
     {
          Application.Quit();
     }
}
