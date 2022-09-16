using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BilahManager : MonoBehaviour
{
    public GameObject[] bilah;
    public GameObject[] tempatPukul;

    private bool isWait = true;
    
    private int[] notes = {2,3,2,3,1,2,3,2,3,5,6,5,4,2,1,6};


    IEnumerator startDelay(){
        isWait = true;//object now waits
        yield return new WaitForSeconds(0.8f);
        isWait = false; //object is no longer waiting
    }

    void Update()
    {
        Rythm();
    }

    private void Rythm(){
        foreach (int note in notes)
        {
            for(int i = 1; i < bilah.Length + 1; i++){
                if(note == i){
                   bilah[i-1].GetComponent<Collider>().enabled = false;
                   tempatPukul[i-1].GetComponent<Collider>().enabled = true;
                   StartCoroutine(startDelay());
                   bilah[i-1].GetComponent<Collider>().enabled = true;
                   tempatPukul[i-1].GetComponent<Collider>().enabled = false;
                }
            }
        }
    }
}
