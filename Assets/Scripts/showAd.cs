using UnityEngine;
using UnityEngine.Advertisements;

public class showAd : MonoBehaviour
{
    public void showAdNow()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}