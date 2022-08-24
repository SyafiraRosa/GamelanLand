using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patet : MonoBehaviour
{
    private AudioManager audioManager;
    public AnimasiGetar animasiGetar;
    public string namaSound;

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Collider Patet")
        {
            FindObjectOfType<AudioManager>().FadeOutSound(namaSound);
            AnimasiGetar animasiGetar = gameObject.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }
    }
}
