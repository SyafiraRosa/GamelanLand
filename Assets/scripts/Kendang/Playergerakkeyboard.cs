using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playergerakkeyboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //control player with keyboard
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.forward * 0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * 0.1f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * 0.1f);
        }

        //rotate player with keyboard
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.down * 1.5f);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.up * 1.5f);
        }
    }
}
