using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class player2Health : MonoBehaviour
{
    public GameObject HealthThing;
    float player2HealthValue = new float();
    public Slider healthSlider2;

    // Use this for initialization
    void Start()
    {
        HealthThing = GameObject.Find("HealthThing");
        player2HealthValue = HealthThing.GetComponent<overallHealthTracker>().player2Health;

    }

    // Update is called once per frame
    void Update()
    {
        player2HealthValue = HealthThing.GetComponent<overallHealthTracker>().player2Health;
        healthSlider2.value = player2HealthValue;
    }
}
