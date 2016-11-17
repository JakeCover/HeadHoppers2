using UnityEngine;
using System.Collections;

public class player2Controller : MonoBehaviour
{

    public bool p2IsDoingSomthing = new bool();

    // Use this for initialization
    void Start()
    {
        p2IsDoingSomthing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(new Vector3(-8, 0, 0) * Time.deltaTime);
            print("J key was pressed");
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
            print("L key was pressed");
        }
        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
            print("I key was pressed");
        }
    }
}
