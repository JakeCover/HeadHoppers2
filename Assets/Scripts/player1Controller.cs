using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using CnControls;



public class player1Controller : MonoBehaviour {

    public bool p1IsDoingSomthing = new bool();
    Vector3 movement;


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
        movement = new Vector3(CnInputManager.GetAxis("Horizontal1"), CnInputManager.GetAxis("Vertical1"), 0f);
        transform.Translate(movement * Time.deltaTime * 15);


    }
}

