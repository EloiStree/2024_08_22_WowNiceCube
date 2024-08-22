using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionActionMono : MonoBehaviour
{

    public UnityEvent m_onEnterCollision;

    public void OnCollisionEnter(Collision collision)
    {
        m_onEnterCollision.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        m_onEnterCollision.Invoke();

    }

}
