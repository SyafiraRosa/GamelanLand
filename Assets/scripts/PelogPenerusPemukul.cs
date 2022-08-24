using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogPenerusPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_penerus1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High1");
            FindObjectOfType<AudioManager>().Play("Penerus_High1");
        }

        else if (col.collider.name == "pelog_penerus2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low2");
            FindObjectOfType<AudioManager>().Play("Penerus_Low2");
        }

        else if (col.collider.name == "pelog_penerus3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low3");
            FindObjectOfType<AudioManager>().Play("Penerus_Low3");
        }

        else if (col.collider.name == "pelog_penerus4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low4");
            FindObjectOfType<AudioManager>().Play("Penerus_Low4");
        }

        else if (col.collider.name == "pelog_penerus5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low5");
            FindObjectOfType<AudioManager>().Play("Penerus_Low5");
        }

        else if (col.collider.name == "pelog_penerus6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low6");
            FindObjectOfType<AudioManager>().Play("Penerus_Low6");
        }

        else if (col.collider.name == "pelog_penerus7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low7");
            FindObjectOfType<AudioManager>().Play("Penerus_Low7");
        }

        else if (col.collider.name == "pelog_penerus1a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_Low1");
            FindObjectOfType<AudioManager>().Play("Penerus_Low1");
        }

        else if (col.collider.name == "pelog_penerus2a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High2");
            FindObjectOfType<AudioManager>().Play("Penerus_High2");
        }

        else if (col.collider.name == "pelog_penerus3a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High3");
            FindObjectOfType<AudioManager>().Play("Penerus_High3");
        }

        else if (col.collider.name == "pelog_penerus4a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High4");
            FindObjectOfType<AudioManager>().Play("Penerus_High4");
        }

        else if (col.collider.name == "pelog_penerus5a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High5");
            FindObjectOfType<AudioManager>().Play("Penerus_High5");
        }

        else if (col.collider.name == "pelog_penerus6a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High6");
            FindObjectOfType<AudioManager>().Play("Penerus_High6");
        }

        else if (col.collider.name == "pelog_penerus7a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Penerus_High7");
            FindObjectOfType<AudioManager>().Play("Penerus_High7");
        }
    }
}
