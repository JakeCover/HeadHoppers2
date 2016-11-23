using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;



public class finishScreenHider : MonoBehaviour {
    
    GameObject HealthThing;
    GameObject redTeamCanvas;
    GameObject blueTeamCanvas;
    bool player1Dead;
    bool player2Dead;


    // Use this for initialization
        void Start()
    {
        redTeamCanvas = GameObject.Find("RedTeamWin");
        blueTeamCanvas = GameObject.Find("BlueTeamWin");
        HealthThing = GameObject.Find("HealthThing");

        redTeamCanvas.SetActive(false);
        blueTeamCanvas.SetActive(false);

        player1Dead = HealthThing.GetComponent<overallHealthTracker>().player1Dead;
        player2Dead = HealthThing.GetComponent<overallHealthTracker>().player2Dead;

        if (player1Dead) //blue team won
        { //blue team won
            Debug.Log("unloading red...");
            blueTeamCanvas.SetActive(true);


        }
        else if (player2Dead)
        { //red team won
            Debug.Log("unloading blue...");
            redTeamCanvas.SetActive(true);

        }
    }
	
	// Update is called once per frame
    void Update(){

    }
}
