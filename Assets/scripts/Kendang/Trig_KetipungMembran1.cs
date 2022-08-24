using UnityEngine;

public class Trig_KetipungMembran1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tak");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tak");
            Debug.Log("bunyi gendang ketipung");
        } 
        else if(col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tak");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tak");
            Debug.Log("bunyi gendang ketipung");
        }
    }
}
