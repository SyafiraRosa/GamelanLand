using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelog_kempul_pemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_kempul1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Gong_Suwukan2");
            FindObjectOfType<AudioManager>().Play("Gong_Suwukan2");
        }

        else if (col.collider.name == "pelog_kempul2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempul_Low5");
            FindObjectOfType<AudioManager>().Play("Kempul_Low5");
        }

        else if (col.collider.name == "pelog_kempul3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempul_Low6");
            FindObjectOfType<AudioManager>().Play("Kempul_Low6");
        }

        else if (col.collider.name == "pelog_kempul4")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Gong_Suwukan1");
            FindObjectOfType<AudioManager>().Play("Gong_Suwukan1");
        }

        else if (col.collider.name == "pelog_kempul5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempul_High1");
            FindObjectOfType<AudioManager>().Play("Kempul_High1");
        }

        else if (col.collider.name == "pelog_kempul6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempul_Low3");
            FindObjectOfType<AudioManager>().Play("Kempul_Low3");
        }

        else if (col.collider.name == "pelog_kempul7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kempul_Low7");
            FindObjectOfType<AudioManager>().Play("Kempul_Low7");
        }
    }
}
