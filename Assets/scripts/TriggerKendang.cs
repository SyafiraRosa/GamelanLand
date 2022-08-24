using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerKendang : MonoBehaviour
{
    public GameObject currentGameObject;
    public float alpha = 0.0f;
    public float alphab = 0.0f;
    public GameObject ketipung1;
    public GameObject ketipung2;
    public GameObject ciblon1;
    public GameObject ciblon2;
    public GameObject ageng1;
    public GameObject ageng2;
    //public GameObject outer;


    void Start()
    {
        currentGameObject = gameObject;
        //outer.gameObject.SetActive(false);
        ketipung1.gameObject.SetActive(false);
        ketipung2.gameObject.SetActive(false);
        ciblon1.gameObject.SetActive(false);
        ciblon2.gameObject.SetActive(false);
        ageng1.gameObject.SetActive(false);
        ageng2.gameObject.SetActive(false);
        

    }

    void ChangeAlpha(Material mat, float alphaVal)
    {
        Color oldColor = mat.color;
        Color newColor = new Color(oldColor.r, oldColor.g, oldColor.b, alphaVal);
        mat.SetColor("_Color", newColor);
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            ketipung1.gameObject.SetActive(true);
            ketipung2.gameObject.SetActive(true);
            ciblon1.gameObject.SetActive(true);
            ciblon2.gameObject.SetActive(true);
            ageng1.gameObject.SetActive(true);
            ageng2.gameObject.SetActive(true);
            //outer.gameObject.SetActive(true);

            ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alpha);
        }
        
    }
    public void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            ketipung1.gameObject.SetActive(false);
            ketipung2.gameObject.SetActive(false);
            ciblon1.gameObject.SetActive(false);
            ciblon2.gameObject.SetActive(false);
            ageng1.gameObject.SetActive(false);
            ageng2.gameObject.SetActive(false);
            //outer.gameObject.SetActive(false);

            ChangeAlpha(currentGameObject.GetComponent<Renderer>().material, alphab);
        }
        
    }
}
