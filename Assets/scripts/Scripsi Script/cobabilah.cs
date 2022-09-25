using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cobabilah : MonoBehaviour
{
    public GameObject[] bilah;
    public GameObject[] tempatPukul;
    int[] gambang = {1,2,3,4,5};

    IEnumerator delay(){
        yield return new WaitForSeconds(1);
    }
    void coba(GameObject[] Bilah)
    {
        for (int i = 0; i < Bilah.Length; i++)
        {
            Bilah[i].SetActive(false);
        }
    }

    
}
