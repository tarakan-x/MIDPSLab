using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

     public Text hpText;
     public int hp;

     public Text pText;
     public int points;

     public Button[] buttons;

     public soundMenager sm;

     public Text gameOverText;
     bool gameOver;

     public moveBomb mb;

	// Use this for initialization
	void Start () {
          hp = 100;
          points = 0;
	}
	
	// Update is called once per frame
	void Update () {

          if (hp < 0)
          {
               hp = 0;
               gameOver = true;
          }
          hpText.text = "HP: " + hp + " %";
          pText.text = "Score: " + points;

          if (gameOver)
          {
               setButtonActive(true);
               gameOverText.gameObject.SetActive(true);
               Time.timeScale = 0;
          }

          //destroy bomb
#if UNITY_STANDALONE
          if (Input.GetMouseButtonDown(0))
          {
               Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
               RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
               if( hit.collider != null)
               {
                    // Debug.Log(hit.collider.tag);
                    if (hit.collider.tag == "bomb")
                    {
                         Destroy(hit.collider.gameObject);
                         addPoints();
                         sm.bombSound.Play();
                    }else if(hit.collider.tag == "HP")
                    {
                         Destroy(hit.collider.gameObject);
                         addHP();
                         sm.addHpSound.Play();
                    }
               }
          }
#endif

#if UNITY_ANDROID
          for (var i = 0; i < Input.touchCount; i++)
          {
               if (Input.GetTouch(i).phase == TouchPhase.Began)
               {
                         Vector2 pos = Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position);
                         RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
                    if (hit.collider != null)
                    {
                         // Debug.Log(hit.collider.tag);
                         if (hit.collider.tag == "bomb")
                         {
                              Destroy(hit.collider.gameObject);
                              addPoints();
                              sm.bombSound.Play();
                         }else if(hit.collider.tag == "HP")
                    {
                         Destroy(hit.collider.gameObject);
                         addHP();         
                                sm.addHpSound.Play();
                         }
                       }                
                    }
                 }
#endif
     }






     public void pauseGame()
     {
          if(Time.timeScale == 1)
          {
               Time.timeScale = 0;
               setButtonActive(true);

          }  else if(Time.timeScale == 0)
          {
               Time.timeScale = 1;
               setButtonActive(false);
          }
     }


     public void loseHP()
     {
          hp = hp - 25;
     }

     public void addHP()
     {
          if(hp + 20 > 100)
          {
               hp = 100;
          } else
          {
               hp = hp + 20;
          }
     }

     public  int addPoints()
     {
          points = points + 10;
          return points;
     }

     public void setButtonActive(bool active)
     {
          foreach(Button btn in buttons)
          {
               btn.gameObject.SetActive(active);
          }
     }


     public void restartGame()
     {
          SceneManager.LoadScene(1);
     }
     public void goToMenu()
     {
          SceneManager.LoadScene(0);
     }
}
