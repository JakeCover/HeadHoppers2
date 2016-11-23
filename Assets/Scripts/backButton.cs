using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;


public class backButton : MonoBehaviour {

    // Use this for initialization
    void showAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
        void Start () {
	
	}

    public void onClick()
    {
        SceneManager.LoadScene("mainMenu", LoadSceneMode.Single);
        showAd();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
