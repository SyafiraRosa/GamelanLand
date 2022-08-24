using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPemukulKendang : MonoBehaviour
{
    public GameObject pemukulKanan;
    public GameObject pemukulKiri;

    void Start()
    {
        pemukulKanan.gameObject.SetActive(false);
        pemukulKiri.gameObject.SetActive(false);
    }

    public void ShowPemukul()
    {
        pemukulKanan.gameObject.SetActive(true);
        pemukulKiri.gameObject.SetActive(true);
    }
}
