using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batasMusik : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other) {
        Debug.Log("object detect");
        if (other.tag == "Notes"){
            Destroy(other.gameObject);
        }
    }

}
