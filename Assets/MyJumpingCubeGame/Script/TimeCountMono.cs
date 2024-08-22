using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimeCountMono : MonoBehaviour
{

    public float m_secondsPast;
    //0.265464

    public UnityEvent<string> m_onSecondsChanged;


    void Update()
    {
        m_secondsPast += Time.deltaTime;
        int seconds =(int) m_secondsPast;
        //1 5 8 1565 
        m_onSecondsChanged.Invoke(seconds.ToString());
    }


    [ContextMenu("Reset time to zero")]
    public void ResetTimeToZero() { 
    
        m_secondsPast = 0;
    }

}
