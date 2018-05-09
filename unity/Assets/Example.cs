using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GreeterServer.Program.Main(null);
      
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 100, 40), "send"))
        {
            GreeterClient.Program.Main(null);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
