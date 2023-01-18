using HyperCasual.Game;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BouncingBall
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] GameConfigSO m_GameConfig;

        private Contexts m_Contexts;
        private GameSystems m_GameSystems;

        protected virtual void Awake()
        {
            m_Contexts = Contexts.sharedInstance;
            m_Contexts.config.SetIGameConfig(m_GameConfig);

            m_GameSystems = new GameSystems(m_Contexts);

            Application.targetFrameRate = 60;
        }

        private void Start() => m_GameSystems.Initialize();

        private void Update()
        {
            m_GameSystems.Execute();
            m_GameSystems.Cleanup();
        }
    }
}
