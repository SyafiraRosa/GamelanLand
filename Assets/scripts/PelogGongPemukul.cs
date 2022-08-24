using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogGongPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_gong1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Gong Ageng 5");
            FindObjectOfType<AudioManager>().Play("Gong Ageng 5");
        }

        else if (col.collider.name == "pelog_gong2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Gong Ageng 6");
            FindObjectOfType<AudioManager>().Play("Gong Ageng 6");
        }
    }
}
