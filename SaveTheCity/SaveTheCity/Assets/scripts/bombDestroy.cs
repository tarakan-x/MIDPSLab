using UnityEngine;
using System.Collections;

public class bombDestroy : MonoBehaviour {
    public  gameManager gm;
     public soundMenager sm;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
     void OnCollisionEnter2D(Collision2D coll)
     {
          if( coll.gameObject.tag == "bomb")
          {
               Destroy(coll.gameObject);
               gm.loseHP();
               sm.groundSound.Play();
          }else if(coll.gameObject.tag == "HP")
          {
               Destroy(coll.gameObject);
        
          }
     }
          
          
   }
