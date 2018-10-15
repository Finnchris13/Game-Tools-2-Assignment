using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingScript : MonoBehaviour
{

    private Animator m_anim;



    void Start()
    {
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
}
