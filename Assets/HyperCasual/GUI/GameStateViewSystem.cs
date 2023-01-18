using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace HyperCasual.GUI
{
    public class GameStateViewSystem : ReactiveSystem<GameEntity>
    {
        private CanvasGroup m_InitialScreen;
        private CanvasGroup m_GameScreen;
        private CanvasGroup m_GameOverScreen;

        public GameStateViewSystem(Contexts contexts) : base(contexts.game)
        {
            m_InitialScreen = GameObject.FindGameObjectWithTag("InitialScreen").GetComponent<CanvasGroup>();
            m_GameScreen = GameObject.FindGameObjectWithTag("GameScreen").GetComponent<CanvasGroup>();
            m_GameOverScreen = GameObject.FindGameObjectWithTag("GameOverScreen").GetComponent<CanvasGroup>();
        }

        protected override void Execute(List<GameEntity> entities)
        {
            switch (entities[0].gameState.CurrentGameState)
            {
                case Game.GameStateComponent.GameState.GameStart:
                    HideCanvasGroup(m_GameScreen);
                    HideCanvasGroup(m_GameOverScreen);
                    ShowCanvasGroup(m_InitialScreen);
                    break;
                case Game.GameStateComponent.GameState.GameRunning:
                    HideCanvasGroup(m_InitialScreen);
                    HideCanvasGroup(m_GameOverScreen);
                    ShowCanvasGroup(m_GameScreen);
                    break;
                case Game.GameStateComponent.GameState.GameOver:
                    HideCanvasGroup(m_GameScreen);
                    ShowCanvasGroup(m_GameOverScreen);
                    break;
            }
        }

        private void ShowCanvasGroup(CanvasGroup group)
        {
            group.alpha = 1f;
            group.interactable = true;
            group.blocksRaycasts = true;
        }

        private void HideCanvasGroup(CanvasGroup group)
        {
            group.alpha = 0f;
            group.interactable = false;
            group.blocksRaycasts = false;
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector(GameMatcher.GameState);
        }
    }
}
