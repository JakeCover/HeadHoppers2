using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player1Health : MonoBehaviour {
    GameObject HealthThing;
    public float player1HealthValue = new float();
    public Slider healthSlider;
    
	// Use this for initialization
	void Start () {
        HealthThing = GameObject.Find("HealthThing");
        player1HealthValue = HealthThing.GetComponent<overallHealthTracker>().player1Health;
	}

    void onTriggerStay(Collider other)
    {

    }

	// Update is called once per frame
	void Update () {
        player1HealthValue = HealthThing.GetComponent<overallHealthTracker>().player1Health;
        healthSlider.value = player1HealthValue;
	}
}
