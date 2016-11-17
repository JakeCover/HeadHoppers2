using UnityEngine;
using System.Collections;

public class player2Controller_AI : MonoBehaviour
{

    public bool p2IsDoingSomthing = new bool();
    float Rand;
    float Rand2;
    Vector3 player1Pos;
    Vector3 player2Pos;
    GameObject player1;
    Vector3 distAway;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("player1");
        p2IsDoingSomthing = false;
    }

    IEnumerator wait5Sec()
    {
        yield return new WaitForSeconds(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        player1Pos = player1.transform.position;
        player2Pos = gameObject.transform.position;
        Debug.Log(player1Pos);
        Rand = Random.value;
        Rand2 = Random.value;

        if (player1Pos.x < player2Pos.x - Rand)
        {
            transform.Translate(new Vector3(-Rand2 * 10, 0, 0) * Time.deltaTime);
            print("J key was pressed");
            wait5Sec();
        }
        else if (player1Pos.x > player2Pos.x + Rand)
        {
            transform.Translate(new Vector3(Rand2 * 10, 0, 0) * Time.deltaTime);
            print("L key was pressed");
            wait5Sec();
        }
        if (player1Pos.y > player2Pos.y - Rand)
        {
            transform.Translate(new Vector3(0, Rand2 * 20, 0) * Time.deltaTime);
            print("I key was pressed");
            wait5Sec();
        }
    }
}
   