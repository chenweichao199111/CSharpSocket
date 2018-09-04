using UnityEngine;
using System.Collections;

public class Scenes : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnGUI()
    {
        //5回应
        if (GUI.Button(new Rect(0, Screen.height - 50, 100, 50), "5echo"))
        {
            Application.LoadLevel("5echo");
        }
        //6异步socket
        if (GUI.Button(new Rect(100, Screen.height - 50, 100, 50), "6asyn"))
        {
            Application.LoadLevel("6asyn");
        }
        //11行走
        if (GUI.Button(new Rect(200, Screen.height - 50, 100, 50), "11walk"))
        {
            Application.LoadLevel("11walk");
        }
    }
}
