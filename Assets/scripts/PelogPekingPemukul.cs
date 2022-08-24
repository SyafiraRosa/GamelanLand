using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogPekingPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_peking1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking1");
            FindObjectOfType<AudioManager>().Play("Peking1");
        }

        else if (col.collider.name == "pelog_peking2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking2");
            FindObjectOfType<AudioManager>().Play("Peking2");
        }

        else if (col.collider.name == "pelog_peking3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking3");
            FindObjectOfType<AudioManager>().Play("Peking3");
        }

        else if (col.collider.name == "pelog_peking4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking4");
            FindObjectOfType<AudioManager>().Play("Peking4");
        }

        else if (col.collider.name == "pelog_peking5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking5");
            FindObjectOfType<AudioManager>().Play("Peking5");
        }

        else if (col.collider.name == "pelog_peking6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking6");
            FindObjectOfType<AudioManager>().Play("Peking6");
        }

        else if (col.collider.name == "pelog_peking7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Peking7");
            FindObjectOfType<AudioManager>().Play("Peking7");
        }
    }
}
