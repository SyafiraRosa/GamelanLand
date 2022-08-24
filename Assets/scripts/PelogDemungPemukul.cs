using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogDemungPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_demung1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung1");
            FindObjectOfType<AudioManager>().Play("Demung1");
        }

        else if (col.collider.name == "pelog_demung2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung2");
            FindObjectOfType<AudioManager>().Play("Demung2");
        }

        else if (col.collider.name == "pelog_demung3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung3");
            FindObjectOfType<AudioManager>().Play("Demung3");
        }

        else if (col.collider.name == "pelog_demung4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung4");
            FindObjectOfType<AudioManager>().Play("Demung4");
        }

        else if (col.collider.name == "pelog_demung5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung5");
            FindObjectOfType<AudioManager>().Play("Demung5");
        }

        else if (col.collider.name == "pelog_demung6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung6");
            FindObjectOfType<AudioManager>().Play("Demung6");
        }

        else if (col.collider.name == "pelog_demung7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Demung7");
            FindObjectOfType<AudioManager>().Play("Demung7");
        }
    }
}
