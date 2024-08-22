using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayerMono : MonoBehaviour
{

    public Rigidbody m_rigidbodyToAffect;
    public float m_forcePower = 10;
    public Transform m_rayDirection;
    void Start()
    {
        Debug.Log("Hello");
    }


    public LayerMask m_whatToConsiderAsGround;
    public float m_distanceOfGroundToJump = 0.5f;

    public bool m_useRaycast = false;
    public  void NeedToJump()
    {
        if (m_useRaycast)
        {
            RaycastHit hit;
            Color rayColor = Color.red;
            if (Physics.Raycast(m_rayDirection.position,
                m_rayDirection.forward, out hit,
                m_distanceOfGroundToJump,
                m_whatToConsiderAsGround)
                )
            {
                AddForceToPlayerToJump(); 
                rayColor = Color.green;

            }

            Debug.DrawLine(
                m_rayDirection.position,
                m_rayDirection.position + m_rayDirection.forward
                * m_distanceOfGroundToJump,
                Color.red,
                2
                );
        }
        else
        {
            AddForceToPlayerToJump();
        }

    }

    private void AddForceToPlayerToJump()
    {
        m_rigidbodyToAffect.AddForce(Vector3.up * m_forcePower, ForceMode.Impulse);
    }
}
