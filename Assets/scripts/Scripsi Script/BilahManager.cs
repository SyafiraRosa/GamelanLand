using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilahManager : MonoBehaviour
{
    //Array
    public GameObject[] bilah;
    public GameObject[] tempatPukul;
    public Material[] matColor;
    
    //ListMusic
    private int[] notes = {2,3,2,3,1,2,3,2,3,5,6,5,4,2,1,6};

    //Change color
    Renderer rend;

    IEnumerator startDelay(){
        for(int j = 0; j < notes.Length; j++){
            for(int i = 1; i < bilah.Length; i++){
                Collider isBilah = bilah[i].GetComponent<Collider>();
                Collider isPukul = tempatPukul[i].GetComponent<Collider>();
                rend = bilah[i].GetComponent<Renderer>();
                if(notes[j] == i+1){
                    isBilah.enabled = false;
                    isPukul.enabled = true;
                    rend.material = matColor[1];
                    yield return new WaitForSeconds(2f);
                    isBilah.enabled = true;
                    isPukul.enabled = false;
                    rend.material = matColor[0];
                }
            }
        }
        // foreach (int note in notes)
        // {
        //     for(int i = 1; i < bilah.Length; i++){
        //         Collider isBilah = bilah[i].GetComponent<Collider>();
        //         Collider isPukul = tempatPukul[i].GetComponent<Collider>();
        //         rend = bilah[i].GetComponent<Renderer>();
        //         if(note == i+1){
        //             isBilah.enabled = false;
        //             isPukul.enabled = true;
        //             rend.material = matColor[1];
        //             yield return new WaitForSeconds(2f);
        //             isBilah.enabled = true;
        //             isPukul.enabled = false;
        //             rend.material = matColor[0];
        //         }
        //     }
        // }
    }

    void Update()
    {
        StartCoroutine(startDelay());
        // foreach (int note in notes){
        //     for(int i = 1; i < bilah.Length + 1; i++){
        //         if (note == i){
        //             rend = bilah[i-1].GetComponent<Renderer>();
        //             float lerp = Mathf.PingPong(Time.time, duration) / duration;
        //             rend.material.Lerp(matColor[0], matColor[1], lerp);
        //         }
        //     }
        // }
    }       
}
