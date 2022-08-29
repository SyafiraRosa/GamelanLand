using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playergerakkeyboard : MonoBehaviour
{
    public float speed;
    public float speedrotate;
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
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }


        //rotate player with keyboard
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.down * speedrotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.up * speedrotate * Time.deltaTime);
        }

        //setting floating
        if(Input.GetKey(KeyCode.I))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.K))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        //setting speed
        if(Input.GetKey(KeyCode.N))
        {
            speed = speed + 0.5f;
        }
        if(Input.GetKey(KeyCode.M) && speed > 0.5f)
        {
            speed = speed - 0.5f;
        }

        //setting speedrotate
        if(Input.GetKey(KeyCode.Z))
        {
            speedrotate = speedrotate + 1f;
        }
        if(Input.GetKey(KeyCode.X) && speedrotate > 1f)
        {
            speedrotate = speedrotate - 1f;
        }
    }
}
