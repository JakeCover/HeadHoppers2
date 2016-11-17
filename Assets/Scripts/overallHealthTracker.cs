using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class overallHealthTracker : MonoBehaviour {
    public int player1Health;
    public int player2Health;
    public bool player1Dead;
    public bool player2Dead;
    bool diedYet;


	void Start () {

        player1Health = 50;
        player2Health = 50;
        player1Dead = false;
        player2Dead = false;
        diedYet = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (player1Health <= 0 && !diedYet)
        { //blue team won
            Debug.Log("p1 be dead");
            player1Dead = true;
            SceneManager.LoadScene("finishScreen", LoadSceneMode.Single);
            diedYet = true;
        }
        else if (player2Health <= 0 && !diedYet) 
        { //red team won
            Debug.Log("p2 be dead");
            player2Dead = true;
            SceneManager.LoadScene("finishScreen", LoadSceneMode.Single);
            diedYet = true;
        }
	}

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
