using UnityEngine;
using System.Collections;

public class playMusic : MonoBehaviour {

    public AudioClip[] songs;
    public int currentSong = 0;

    void Update()
    {
        if (GetComponent<AudioSource>().isPlaying == false || Input.GetKey(KeyCode.N))
        {
            if (currentSong >= songs.Length - 1)
            {
                currentSong = 0;  
            }
            else
            {
                currentSong++;
            }

            GetComponent<AudioSource>().clip = songs[currentSong];
            GetComponent<AudioSource>().Play();
        }
    }
}
