//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Entitas;

//namespace HyperCasual.Ads
//{
//    public class AdsInterestitialSystem : ReactiveSystem<GameEntity>
//    {
//        private int m_TurnsToShowAd = 25;
//        private int m_TurnsLeft;

//        public AdsInterestitialSystem(Contexts contexts) : base(contexts.game)
//        {
//            m_TurnsLeft = m_TurnsToShowAd;
//        }

//        protected override void Execute(List<GameEntity> entities)
//        {
//            m_TurnsLeft--;

//            if (m_TurnsLeft == 0)
//            {
//                AdsManager.Instance.ShowInterstitial();
//                m_TurnsLeft = m_TurnsToShowAd;
//            }
//        }

//        protected override bool Filter(GameEntity entity)
//        {
//            return entity.turnState.CurrentTurnState == Game.TurnStateComponent.TurnState.TurnStart;
//        }

//        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
//        {
//            return context.CreateCollector(GameMatcher.TurnState);
//        }
//    }
//}
