using UnityEngine;
using UnityEngine.Advertisements;

public class showAd : MonoBehaviour
{
    void Start()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}