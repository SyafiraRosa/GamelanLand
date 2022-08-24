using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogKethukPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_kempyang")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempyang");
            FindObjectOfType<AudioManager>().Play("Kempyang");
            Debug.Log("pemukul kempyang");
        }

        else if (col.collider.name == "pelog_ketuk")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kethuk");
            FindObjectOfType<AudioManager>().Play("Kethuk");
            Debug.Log("pemukul kempyang");
        }
    }
}
