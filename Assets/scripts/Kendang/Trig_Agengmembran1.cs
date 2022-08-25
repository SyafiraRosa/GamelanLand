using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_Agengmembran1 : MonoBehaviour
{
    int pukulan = 0;
    void OnCollisionEnter(Collision col)
    {

        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Dah");
            FindObjectOfType<AudioManager>().Play("Ageng_Dah");
            Debug.Log("bunyi gendang ageng" + pukulan);
            pukulan++;
        } 
        else if (col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Dah");
            FindObjectOfType<AudioManager>().Play("Ageng_Dah");
            Debug.Log("bunyi gendang ageng" + pukulan);
            pukulan++;
        }
    }
}
