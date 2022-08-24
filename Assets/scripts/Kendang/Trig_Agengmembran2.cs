using UnityEngine;

public class Trig_Agengmembran2 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "Pemukul kendang kiri")
        {
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Tak");
            FindObjectOfType<AudioManager>().Play("Ageng_Tak");
            Debug.Log("bunyi gendang ageng");
        }
        else if(col.collider.name == "Pemukul Kendang kanan"){
            FindObjectOfType<AudioManager>().SetNormalVolume("Ageng_Tak");
            FindObjectOfType<AudioManager>().Play("Ageng_Tak");
            Debug.Log("bunyi gendang ageng");
        }
    }
}
