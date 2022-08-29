using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetworkSetup : MonoBehaviourPunCallbacks
{
    public GameObject LocalXRRigGameObject;
    public GameObject MainAvatarGameobject;

    // public GameObject Tangankirikendang;
    // public GameObject Tangankanankendang;

    public GameObject AvatarHeadGameObject;
    public GameObject AvatarBodyGameObject;
    public GameObject AvatarNameObject;

    //setting seing hand for PC
    public GameObject lefthandPC;
    public GameObject righthandPC;

    public GameObject[] AvatarModelPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.IsMine)
        {
            //Your Player
            LocalXRRigGameObject.SetActive(true);
            // Tangankanankendang.SetActive(true);
            // Tangankirikendang.SetActive(true);

            //getting avatar selection data for change character
            object avatarSelectionNumber;
            if (PhotonNetwork.LocalPlayer.CustomProperties.TryGetValue(MultiplayerVRConstants.AVATAR_SELECTION_NUMBER, out avatarSelectionNumber)){
                Debug.Log("Avatar selection number : "+ (int)avatarSelectionNumber);
                photonView.RPC("InitializeSelectedAvatarModel", RpcTarget.AllBuffered, (int)avatarSelectionNumber);
            }

            SetLayerRecursively(AvatarHeadGameObject,6);
            SetLayerRecursively(AvatarBodyGameObject,7);
            SetLayerRecursively(AvatarNameObject, 5);

            MainAvatarGameobject.AddComponent<AudioListener>();
        }
        else
        {
            //Other Player
            LocalXRRigGameObject.SetActive(false);
            // Tangankanankendang.SetActive(false);
            // Tangankirikendang.SetActive(false);

            SetLayerRecursively(AvatarHeadGameObject, 0);
            SetLayerRecursively(AvatarBodyGameObject, 0);
            SetLayerRecursively(AvatarNameObject, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine){
            //Setting for PC
            if(Input.GetKey(KeyCode.P)){
                GetComponent<Playergerakkeyboard>().enabled = true;
                lefthandPC.SetActive(false);
                righthandPC.SetActive(false);
                AvatarNameObject.SetActive(false);
                AvatarBodyGameObject.SetActive(false);
                AvatarHeadGameObject.SetActive(false);
            }
            if(Input.GetKey(KeyCode.O)){
                GetComponent<Playergerakkeyboard>().enabled = false;
                lefthandPC.SetActive(true);
                righthandPC.SetActive(true);
                AvatarNameObject.SetActive(true);
                AvatarBodyGameObject.SetActive(true);
                AvatarHeadGameObject.SetActive(true);
            }
        }
    }

    void SetLayerRecursively(GameObject go, int layerNumber)
    {
        if (go == null) return;
        foreach (Transform trans in go.GetComponentsInChildren<Transform>(true))
        {
            trans.gameObject.layer = layerNumber;
        }
    }

    [PunRPC]
    public void InitializeSelectedAvatarModel(int avatarSelectionNumber)
    {
        GameObject selectedAvatarGameobject = Instantiate(AvatarModelPrefabs[avatarSelectionNumber], LocalXRRigGameObject.transform);

        AvatarInputConverter avatarInputConverter = LocalXRRigGameObject.GetComponent<AvatarInputConverter>();
        AvatarHolder avatarHolder = selectedAvatarGameobject.GetComponent<AvatarHolder>();
        SetUpAvatarGameobject(avatarHolder.HeadTransform,avatarInputConverter.AvatarHead);
        SetUpAvatarGameobject(avatarHolder.BodyTransform,avatarInputConverter.AvatarBody);
        SetUpAvatarGameobject(avatarHolder.HandLeftTransform, avatarInputConverter.AvatarHand_Left);
        SetUpAvatarGameobject(avatarHolder.HandRightTransform, avatarInputConverter.AvatarHand_Right);
    }

    void SetUpAvatarGameobject(Transform avatarModelTransform, Transform mainAvatarTransform)
    {
        avatarModelTransform.SetParent(mainAvatarTransform);
        avatarModelTransform.localPosition = Vector3.zero;
        avatarModelTransform.localRotation = Quaternion.identity;
    }
}
