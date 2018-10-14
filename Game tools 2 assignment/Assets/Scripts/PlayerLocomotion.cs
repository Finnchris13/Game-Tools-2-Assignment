using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour {

    private Animator m_anim;

    

	// Use this for initialization
	void Start () {
        m_anim = GetComponent<Animator>();

	}

    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            m_anim.SetBool("isAiming", true);
        }
        else
        {
            m_anim.SetBool("isAiming", false);
        }
    }

    public void Move(float forward, float turn)
    {
        m_anim.SetFloat("IsWalking", forward);
        m_anim.SetFloat("IsTurning", turn);
    }
}
