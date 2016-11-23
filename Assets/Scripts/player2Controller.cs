using UnityEngine;
using System.Collections;
using CnControls;


public class player2Controller : MonoBehaviour
{

    public bool p2IsDoingSomthing = new bool();
    Vector3 movement;


    // Use this for initialization
    void Start()
    {
        p2IsDoingSomthing = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(CnInputManager.GetAxis("Horizontal2"), CnInputManager.GetAxis("Vertical2"), 0f);
        transform.Translate(movement * Time.deltaTime * 15);
    }
}
