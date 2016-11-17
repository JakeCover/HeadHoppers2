using UnityEngine;
using System.Collections;

public class player1Detector : MonoBehaviour 
{
    public GameObject HealthThing;
    int player1HealthValue;

	// Use this for initialization
	void Start () {
        HealthThing = GameObject.Find("HealthThing");
        player1HealthValue = HealthThing.GetComponent<overallHealthTracker>().player1Health;
	}

    IEnumerator wait5Sec()
    {
        yield return new WaitForSeconds(8f);
    }

    void OnTriggerStay(UnityEngine.Collider other)
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
	// Update is called once per frame
	void Update () {
	
	}
}
