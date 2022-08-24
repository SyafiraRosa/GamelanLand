using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AnimasiGetar : MonoBehaviourPun
{
    public Animator _animator;
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if(base.photonView.IsMine)
        {
            _animator.SetBool("Stop", false);
            if (collision.gameObject.layer == 8)
            {
                _animator.SetBool("Hit", true);
            }
            else if (collision.gameObject.layer == 9)
            {
                _animator.SetBool("Hit", true);
            }
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if(base.photonView.IsMine)
        {
            if (collision.gameObject.layer == 8)
            {
                _animator.SetBool("Hit", false);
            }
            else if (collision.gameObject.layer == 9)
            {
                _animator.SetBool("Hit", false);
            }
        }
    }

    public void StopGetarPatet()
    {
        _animator.SetBool("Stop", true);
    }
}
