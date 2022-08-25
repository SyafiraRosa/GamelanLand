using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pemukul_kendang_universal : MonoBehaviour
{
    void OnCollisionEnter(Collision col) 
    {
        if (col.collider.name == "pelog_ageng_membran1 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Dah");
            FindObjectOfType<AudioManager>().Play("Ageng_Dah");
        }

        else if (col.collider.name == "pelog_ageng_membran2 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Tak");
            FindObjectOfType<AudioManager>().Play("Ageng_Tak");
        }

        else if (col.collider.name == "pelog_ketipung_membran1 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tung");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tung");
        }

        else if (col.collider.name == "pelog_ketipung_membran2 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tak");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tak");
        }

        else if (col.collider.name == "pelog_ciblon_membran1 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Dah");
            FindObjectOfType<AudioManager>().Play("Ciblon_Dah");
        }

        else if (col.collider.name == "pelog_ciblon_membran2 (Collider)")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Tak");
            FindObjectOfType<AudioManager>().Play("Ciblon_Tak");
        }
    }
}
