using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogSaronPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_saron1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron1");
            FindObjectOfType<AudioManager>().Play("Saron1");
        }

        else if (col.collider.name == "pelog_saron2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron2");
            FindObjectOfType<AudioManager>().Play("Saron2");
        }

        else if (col.collider.name == "pelog_saron3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron3");
            FindObjectOfType<AudioManager>().Play("Saron3");
        }

        else if (col.collider.name == "pelog_saron4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron4");
            FindObjectOfType<AudioManager>().Play("Saron4");
        }

        else if (col.collider.name == "pelog_saron5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron5");
            FindObjectOfType<AudioManager>().Play("Saron5");
        }

        else if (col.collider.name == "pelog_saron6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron6");
            FindObjectOfType<AudioManager>().Play("Saron6");
        }

        else if (col.collider.name == "pelog_saron7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Saron7");
            FindObjectOfType<AudioManager>().Play("Saron7");
        }
    }
}
