using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderAlatMusik : MonoBehaviour
{
    public GameObject namaAlat;
    public bool isExit = false;

    public NetworkGrabbing networkGrabbing;

    // Start is called before the first frame update
    void Start()
    {
        
        namaAlat.gameObject.SetActive(false);
    }

    public void ShowName()
    {
        if(networkGrabbing.isBeingHeld)
        {
            namaAlat.gameObject.SetActive(false);
        }
        else{
            if(namaAlat.gameObject.layer == 8)
            {
                if(isExit == false)
                {
                    namaAlat.gameObject.SetActive(true);
                }

                else if(isExit == true)
                {
                    namaAlat.gameObject.SetActive(false);
                }
            }
            else if(namaAlat.gameObject.layer == 9)
            {
                if(isExit == false)
                {
                    namaAlat.gameObject.SetActive(true);
                }

                else if(isExit == true)
                {
                    namaAlat.gameObject.SetActive(false);
                }
            }
        }
        
        
    }

    public void HideName()
    {
        namaAlat.gameObject.SetActive(false);
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            isExit = false;
            ShowName();
        }
    }

    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            isExit = true;
            HideName();
        }
    }
}
