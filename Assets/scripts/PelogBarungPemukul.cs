using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogBarungPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_barung1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High1");
            FindObjectOfType<AudioManager>().Play("Barung_High1");
        }

        else if (col.collider.name == "pelog_barung2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low2");
            FindObjectOfType<AudioManager>().Play("Barung_Low2");
        }

        else if (col.collider.name == "pelog_barung3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low3");
            FindObjectOfType<AudioManager>().Play("Barung_Low3");
        }

        else if (col.collider.name == "pelog_barung4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low4");
            FindObjectOfType<AudioManager>().Play("Barung_Low4");
        }

        else if (col.collider.name == "pelog_barung5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low5");
            FindObjectOfType<AudioManager>().Play("Barung_Low5");
        }

        else if (col.collider.name == "pelog_barung6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low6");
            FindObjectOfType<AudioManager>().Play("Barung_Low6");
        }

        else if (col.collider.name == "pelog_barung7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low7");
            FindObjectOfType<AudioManager>().Play("Barung_Low7");
        }

        else if (col.collider.name == "pelog_barung1a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_Low1");
            FindObjectOfType<AudioManager>().Play("Barung_Low1");
        }

        else if (col.collider.name == "pelog_barung2a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High2");
            FindObjectOfType<AudioManager>().Play("Barung_High2");
        }

        else if (col.collider.name == "pelog_barung3a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High3");
            FindObjectOfType<AudioManager>().Play("Barung_High3");
        }

        else if (col.collider.name == "pelog_barung4a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High4");
            FindObjectOfType<AudioManager>().Play("Barung_High4");
        }

        else if (col.collider.name == "pelog_barung5a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High5");
            FindObjectOfType<AudioManager>().Play("Barung_High5");
        }

        else if (col.collider.name == "pelog_barung6a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High6");
            FindObjectOfType<AudioManager>().Play("Barung_High6");
        }

        else if (col.collider.name == "pelog_barung7a")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Barung_High7");
            FindObjectOfType<AudioManager>().Play("Barung_High7");
        }
    }
}
