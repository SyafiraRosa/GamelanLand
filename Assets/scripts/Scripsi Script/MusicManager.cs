using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public Transform[] tempatMuncul;
    public GameObject objectMuncul;

    public float beat = (60/130)*2;
    private float timer;
    //Note musik
    int[] noteGambang = {2,3,2,3,1,2,3,2,3,5,6,5,4,2,1,6};

    bool isWait = false;

    void Start()
    {
        for(int i = 0; i < noteGambang.Length; i++){
            if(isWait == false) {
                GameObject cube = Instantiate(objectMuncul, tempatMuncul[noteGambang[i]-1]);
                cube.transform.localPosition = Vector3.zero;
                StartCoroutine(delay());
                Debug.Log(noteGambang[i]-1);
            }
    }
    }

    void Update()
    {
        // for(int i = 0; i < noteGambang.Length; i++){
        //     if(isWait == false) {
        //         GameObject cube = Instantiate(objectMuncul, tempatMuncul[noteGambang[i]-1]);
        //         cube.transform.localPosition = Vector3.zero;
        //         StartCoroutine(delay());
        //         Debug.Log(noteGambang[i]-1);
        //     }
            
            // timer += Time.deltaTime;
            // StartCoroutine(delay());
        
    }
    

    IEnumerator delay(){
            isWait = true;
            yield return new WaitForSeconds(2f);
            isWait = false;
        
    }
}
