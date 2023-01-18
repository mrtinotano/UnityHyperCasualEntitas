using DesperateDevs.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BouncingBall
{
    [CreateAssetMenu(fileName = "Game Config", menuName = "Bouncing Ball/Configs/Game Config")]
    public class GameConfigSO : ScriptableObject, IGameConfig
    {
        [SerializeField] private int m_StairsAmount;
        [SerializeField] private int m_MaxConsecutiveEnemies;

        public int StairsAmount => m_StairsAmount;
        public int MaxConsecutiveEnemies => m_MaxConsecutiveEnemies;
    }
}
