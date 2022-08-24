using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PatetController : MonoBehaviour
{
    private AudioManager audioManager;
    private AnimasiGetar animasiGetar;

    private GameObject pelog_demung1;
    private GameObject pelog_demung2;
    private GameObject pelog_demung3;
    private GameObject pelog_demung4;
    private GameObject pelog_demung5;
    private GameObject pelog_demung6;
    private GameObject pelog_demung7;
    private GameObject pelog_saron1;
    private GameObject pelog_saron2;
    private GameObject pelog_saron3;
    private GameObject pelog_saron4;
    private GameObject pelog_saron5;
    private GameObject pelog_saron6;
    private GameObject pelog_saron7;
    private GameObject pelog_peking1;
    private GameObject pelog_peking2;
    private GameObject pelog_peking3;
    private GameObject pelog_peking4;
    private GameObject pelog_peking5;
    private GameObject pelog_peking6;
    private GameObject pelog_peking7;


    void Start()
    {
        pelog_demung1 = GameObject.Find("pelog_demung1");
        pelog_demung2 = GameObject.Find("pelog_demung2");
        pelog_demung3 = GameObject.Find("pelog_demung3");
        pelog_demung4 = GameObject.Find("pelog_demung4");
        pelog_demung5 = GameObject.Find("pelog_demung5");
        pelog_demung6 = GameObject.Find("pelog_demung6");
        pelog_demung7 = GameObject.Find("pelog_demung7");

        pelog_saron1 = GameObject.Find("pelog_saron1");
        pelog_saron2 = GameObject.Find("pelog_saron2");
        pelog_saron3 = GameObject.Find("pelog_saron3");
        pelog_saron4 = GameObject.Find("pelog_saron4");
        pelog_saron5 = GameObject.Find("pelog_saron5");
        pelog_saron6 = GameObject.Find("pelog_saron6");
        pelog_saron7 = GameObject.Find("pelog_saron7");

        pelog_peking1 = GameObject.Find("pelog_peking1");
        pelog_peking2 = GameObject.Find("pelog_peking2");
        pelog_peking3 = GameObject.Find("pelog_peking3");
        pelog_peking4 = GameObject.Find("pelog_peking4");
        pelog_peking5 = GameObject.Find("pelog_peking5");
        pelog_peking6 = GameObject.Find("pelog_peking6");
        pelog_peking7 = GameObject.Find("pelog_peking7");


    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "pelog_demung1")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung1");
            AnimasiGetar animasiGetar = pelog_demung1.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung2")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung2");
            AnimasiGetar animasiGetar = pelog_demung2.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung3")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung3");
            AnimasiGetar animasiGetar = pelog_demung3.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung4")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung4");
            AnimasiGetar animasiGetar = pelog_demung4.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung5")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung5");
            AnimasiGetar animasiGetar = pelog_demung5.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung6")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung6");
            AnimasiGetar animasiGetar = pelog_demung6.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_demung7")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Demung7");
            AnimasiGetar animasiGetar = pelog_demung7.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }
        else if (col.gameObject.name == "pelog_peking1")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking1");
            AnimasiGetar animasiGetar = pelog_peking1.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking2")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking2");
            AnimasiGetar animasiGetar = pelog_peking2.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking3")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking3");
            AnimasiGetar animasiGetar = pelog_peking3.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking4")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking4");
            AnimasiGetar animasiGetar = pelog_peking4.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking5")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking5");
            AnimasiGetar animasiGetar = pelog_peking5.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking6")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking6");
            AnimasiGetar animasiGetar = pelog_peking6.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_peking7")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Peking7");
            AnimasiGetar animasiGetar = pelog_peking7.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }
        else if (col.gameObject.name == "pelog_saron1")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron1");
            AnimasiGetar animasiGetar = pelog_saron1.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron2")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron2");
            AnimasiGetar animasiGetar = pelog_saron2.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron3")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron3");
            AnimasiGetar animasiGetar = pelog_saron3.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron4")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron4");
            AnimasiGetar animasiGetar = pelog_saron4.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron5")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron5");
            AnimasiGetar animasiGetar = pelog_saron5.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron6")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron6");
            AnimasiGetar animasiGetar = pelog_saron6.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }

        else if (col.gameObject.name == "pelog_saron7")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Saron7");
            AnimasiGetar animasiGetar = pelog_saron7.GetComponent<AnimasiGetar>();
            animasiGetar.StopGetarPatet();
        }
        else if (col.gameObject.name == "pelog_slenthem1")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem1");
        }

        else if (col.gameObject.name == "pelog_slenthem2")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem2");
        }

        else if (col.gameObject.name == "pelog_slenthem3")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem3");
        }

        else if (col.gameObject.name == "pelog_slenthem4")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem4");
        }

        else if (col.gameObject.name == "pelog_slenthem5")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem5");
        }

        else if (col.gameObject.name == "pelog_slenthem6")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem6");
        }

        else if (col.gameObject.name == "pelog_slenthem7")
        {
            FindObjectOfType<AudioManager>().FadeOutSound("Slenthem7");
        }
        
    }
}
