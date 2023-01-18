//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Entitas;
//using HyperCasual.Time;
//using HyperCasual.Sound;

//namespace HyperCasual.Game
//{
//    public class GameLostSystem : ReactiveSystem<GameEntity>
//    {
//        private Contexts m_Contexts;
//        private IGroup<GameEntity> m_BoardEntities;
//        private IGroup<GameEntity> m_ExplosionEntitiesGroup;

//        private const float m_ShowGameOverDelay = 0.5f;

//        private const string AudioLibrary = "GameAudios";
//        private const string GameLostAudio = "GameLost";

//        public GameLostSystem(Contexts contexts) : base(contexts.game)
//        {
//            m_Contexts = contexts;
//            m_BoardEntities = contexts.game.GetGroup(GameMatcher.BoardPosition);
//            m_ExplosionEntitiesGroup = m_Contexts.game.GetGroup(GameMatcher.Explosion);
//        }

//        protected override void Execute(List<GameEntity> entities)
//        {
//            foreach (GameEntity entity in m_BoardEntities)
//                entity.isExplosion = true;

//            m_ExplosionEntitiesGroup.OnEntityRemoved += OnExplosionEntityRemoved;
//        }

//        private void OnExplosionEntityRemoved(IGroup<GameEntity> group, GameEntity entity, int index, IComponent component)
//        {
//            if (m_ExplosionEntitiesGroup.count == 0)
//            {
//                m_ExplosionEntitiesGroup.OnEntityRemoved -= OnExplosionEntityRemoved;
//                m_Contexts.time.CreateTimer(m_ShowGameOverDelay, () => SetGameOver());
//            }
//        }

//        private void SetGameOver()
//        {
//            m_Contexts.game.ReplaceGameState(GameStateComponent.GameState.GameOver);
//            AudioManager.Instance.PlayAudio(AudioLibrary, GameLostAudio);
//        }

//        protected override bool Filter(GameEntity entity)
//        {
//            return entity.turnState.CurrentTurnState == TurnStateComponent.TurnState.GameLost;
//        }

//        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
//        {
//            return context.CreateCollector(GameMatcher.TurnState);
//        }
//    }
//}
