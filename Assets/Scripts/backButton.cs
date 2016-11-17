using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class backButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public void onClick()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
