using UnityEngine;
using System.Collections;

public class birthBomb : MonoBehaviour {

     public GameObject obj;
     public GameObject objHP;
     public float minPos = -7.5f;
     public float maxPos = 7.5f;
     public float timeDelay = 1.5f;
     float timer;

     public float timeDelayHP = 5f;
     float timerHP;

     // Use this for initialization
     void Start () {
          timer = timeDelay;
          timerHP = timeDelayHP;
	}
	
	// Update is called once per frame
	void Update () {
          timer = timer - Time.deltaTime;
          timerHP = timerHP - Time.deltaTime;
          if(timer<= 0)
          {
               Vector3 objPos = new Vector3(Random.Range(minPos, maxPos) , transform.position.y, transform.position.z);
               Transform.Instantiate(obj, objPos, transform.rotation);

               timer = timeDelay;
          }

          if (timerHP <= 0)
          {
               Vector3 objPos = new Vector3(Random.Range(minPos, maxPos), transform.position.y, -1);
               Transform.Instantiate(objHP, objPos, transform.rotation);

               timerHP = timeDelayHP;
          }

     }
}
