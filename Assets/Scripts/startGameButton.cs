using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class startGameButton : MonoBehaviour {


    GameObject healthThing;

	// Use this for initialization
	void Start () {
        healthThing = GameObject.Find("HealthThing");

	}

    public void Click ()
    {
        Destroy(healthThing);
        SceneManager.LoadScene("mainArena", LoadSceneMode.Single);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
