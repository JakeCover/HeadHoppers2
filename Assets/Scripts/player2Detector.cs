using UnityEngine;
using System.Collections;

public class player2Detector : MonoBehaviour
{
    public GameObject HealthThing;
    int player2HealthValue;

    // Use this for initialization
    void Start()
    {
        HealthThing = GameObject.Find("HealthThing");
        player2HealthValue = HealthThing.GetComponent<overallHealthTracker>().player2Health;
    }

    IEnumerator wait5Sec()
    {
        yield return new WaitForSeconds(8f);
    }

    void OnTriggerStay(UnityEngine.Collider other)
    {
        if (other.name == "player1")
        {
            Debug.Log(player2HealthValue);
            player2HealthValue = player2HealthValue - 1;
            HealthThing.GetComponent<overallHealthTracker>().player2Health = player2HealthValue;
            wait5Sec();
        }
        else
        {
            Debug.Log("Ya done messed up!");
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
