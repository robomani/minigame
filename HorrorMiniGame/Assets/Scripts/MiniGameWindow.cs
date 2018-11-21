using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MiniGameWindow : MonoBehaviour
{
    [SerializeField]
    [Tooltip("The Virtual Camera that look at and follow the target of the mini game")]
    private CinemachineVirtualCamera m_ActionCamera;

    [SerializeField]
    private GameObject m_MiniGameWindow;

    [SerializeField]
    private GameObject m_ActionTarget;
    public GameObject ActionTarget
    {
        get { return m_ActionTarget; }
        set
        {
            m_ActionTarget = value;
            m_ActionCamera.LookAt = m_ActionTarget.transform;
            m_ActionCamera.Follow = m_ActionTarget.transform;
        }
    }


}
