using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseObject : MonoBehaviour
{
    //public Transform startPos;
    public Transform posisiPemukul;
    
    void Start()
    {
        //startPos = this.transform.position;
    }

    public void BackToPos()
    {
        this.transform.position = posisiPemukul.transform.position;
        this.transform.rotation = posisiPemukul.transform.rotation;
    }

}
