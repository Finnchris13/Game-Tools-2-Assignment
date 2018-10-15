using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLocomotion : MonoBehaviour {

    private Animator m_anim;

    

	void Start () {
        m_anim = GetComponent<Animator>();

	}

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            m_anim.SetBool("Jump", true);
        }
        else
        {
            m_anim.SetBool("Jump", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            m_anim.SetBool("Sprinting", true);
        }
        else
        {
            m_anim.SetBool("Sprinting", false);
        }
    }

    public void Move(float forward, float turn)
    {
        m_anim.SetFloat("IsWalking", forward);
        m_anim.SetFloat("IsTurning", turn);
    }
}
