using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserControls : MonoBehaviour {

    private float m_forward;
    private float m_turn;

    private PlayerLocomotion m_locomotion;

	// Use this for initialization
	void Start () {
        m_locomotion = GetComponent<PlayerLocomotion>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        m_forward = Input.GetAxis("Vertical");
        m_turn = Input.GetAxis("Horizontal");
        m_locomotion.Move(m_forward, m_turn);
	}
}
