using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace BouncingBall
{
    public class AutoPathMovement : MonoBehaviour
    {
        [SerializeField] private Vector3[] m_Path;
        [SerializeField] private float m_PathDuration;
        [SerializeField] private bool m_Loop;
        [SerializeField] private LoopType m_LoopType;

        private void Awake()
        {
            transform.DOLocalPath(m_Path, m_PathDuration).SetLoops(m_Loop ? -1 : 0, m_LoopType).SetEase(Ease.Linear);
        }

        private void OnEnable()
        {
            transform.localPosition = m_Path[0];
        }

        private void OnDrawGizmos()
        {
            if (m_Path == null || m_Path.Length < 2)
                return;

            for(int i = 0; i < m_Path.Length - 1; i++)
            {
                Debug.DrawLine(m_Path[i], m_Path[i + 1]);
            }
        }
    }
}
