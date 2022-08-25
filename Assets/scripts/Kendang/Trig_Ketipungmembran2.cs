using UnityEngine;

public class Trig_Ketipungmembran2 : MonoBehaviour
{
    int pukulan = 0;
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tung");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tung");
            Debug.Log("bunyi gendang ketipung" + pukulan);
            pukulan++;
        }
        else if(col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ketipung_Tung");
            FindObjectOfType<AudioManager>().Play("Ketipung_Tung");
            Debug.Log("bunyi gendang ketipung"+pukulan);
            pukulan++;
        }
    }
}
