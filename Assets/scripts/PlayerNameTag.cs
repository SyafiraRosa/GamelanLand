using UnityEngine;
using Photon.Pun;
using TMPro;

public class PlayerNameTag : MonoBehaviourPun
{
    [SerializeField] TMP_Text nameText;
    [SerializeField] PhotonView playerPV;


    // Start is called before the first frame update
    void Start()
    {
        SetName();
    }

    private void SetName()
    {
        nameText.text = playerPV.Owner.NickName;
    }
}
