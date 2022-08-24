using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trig_Ciblonmembran2 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Tak");
            FindObjectOfType<AudioManager>().Play("Ciblon_Tak");
            Debug.Log("bunyi gendang ciblon");
        } 
        else if(col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ciblon_Tak");
            FindObjectOfType<AudioManager>().Play("Ciblon_Tak");
            Debug.Log("bunyi gendang ciblon");
        }
    }
}
