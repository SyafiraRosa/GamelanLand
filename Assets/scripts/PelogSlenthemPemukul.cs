using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogSlenthemPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_slenthem1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem1");
            FindObjectOfType<AudioManager>().Play("Slenthem1");
        }

        else if (col.collider.name == "pelog_slenthem2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem2");
            FindObjectOfType<AudioManager>().Play("Slenthem2");
        }

        else if (col.collider.name == "pelog_slenthem3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem3");
            FindObjectOfType<AudioManager>().Play("Slenthem3");
        }

        else if (col.collider.name == "pelog_slenthem4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem4");
            FindObjectOfType<AudioManager>().Play("Slenthem4");
        }

        else if (col.collider.name == "pelog_slenthem5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem5");
            FindObjectOfType<AudioManager>().Play("Slenthem5");
        }

        else if (col.collider.name == "pelog_slenthem6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem6");
            FindObjectOfType<AudioManager>().Play("Slenthem6");
        }

        else if (col.collider.name == "pelog_slenthem7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Slenthem7");
            FindObjectOfType<AudioManager>().Play("Slenthem7");
        }
    }
}
