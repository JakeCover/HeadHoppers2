using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class player1Controller : MonoBehaviour {

    public bool p1IsDoingSomthing = new bool();
 


	// Use this for initialization
	void Start () {
        p1IsDoingSomthing = false;

	}


/*** BACKUP
    void OnTriggerStay (UnityEngine.Collider other)
    {
        if (other.name == "player2")
        {
            Debug.Log(player1HealthValue);
            player1HealthValue = player1HealthValue - 1;
            HealthThing.GetComponent<overallHealthTracker>().player1Health = player1HealthValue;
            wait5Sec();
        }
        else
        {
            Debug.Log("Ya done messed up!");
        }
    }
***/
	// Update is called once per frame
	void Update () {

        
        
        //movement
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
            print("A key was pressed");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
            print("D key was pressed");
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
            print("W key was pressed");
        }
	}
}
