using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_Cibonmembran1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Dah");
            FindObjectOfType<AudioManager>().Play("Ciblon_Dah");
            Debug.Log("bunyi gendang ciblon");
        } 
        else if(col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Dah");
            FindObjectOfType<AudioManager>().Play("Ciblon_Dah");
            Debug.Log("bunyi gendang ciblon");
        }
    }
}
