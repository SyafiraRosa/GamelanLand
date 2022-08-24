using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelogKenongPemukul : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "pelog_kenong1")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_High1");
            FindObjectOfType<AudioManager>().Play("Kenong_High1");
        }

        else if (col.collider.name == "pelog_kenong2")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_Low2");
            FindObjectOfType<AudioManager>().Play("Kenong_Low2");
        }

        else if (col.collider.name == "pelog_kenong3")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_Low3");
            FindObjectOfType<AudioManager>().Play("Kenong_Low3");
        }

        // else if (col.collider.name == "pelog_kenong4")
        // {
        //     FindObjectOfType<AudioManager>().SetNormalVolume("Demung4");
        //     FindObjectOfType<AudioManager>().Play("Demung4");
        // }

        else if (col.collider.name == "pelog_kenong5")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_Low5");
            FindObjectOfType<AudioManager>().Play("Kenong_Low5");
        }

        else if (col.collider.name == "pelog_kenong6")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_Low6");
            FindObjectOfType<AudioManager>().Play("Kenong_Low6");
        }

        else if (col.collider.name == "pelog_kenong7")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Kenong_Low7");
            FindObjectOfType<AudioManager>().Play("Kenong_Low7");
        }
    }
}
