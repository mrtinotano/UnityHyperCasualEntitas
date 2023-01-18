using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace HyperCasual.GUI
{
    public class ScoreSystem : ReactiveSystem<GuiEntity>, IInitializeSystem
    {
        private Contexts m_Contexts;
        private GuiEntity m_ScoreEntity;

        private int m_Score;

        public ScoreSystem(Contexts contexts) :base(contexts.gui) => m_Contexts = contexts;

        public void Initialize()
        {
            m_ScoreEntity = m_Contexts.gui.CreateEntity();
            Object.FindObjectOfType<GameScoreView>(true).Link(m_ScoreEntity);
            m_ScoreEntity.AddGameScore(0);
        }

        protected override void Execute(List<GuiEntity> entities)
        {
            foreach (GuiEntity entity in entities)
            {
                if (entity.hasAddScore)
                    m_Score += entities[0].addScore.Score;
                else if (entity.isResetScore)
                    m_Score = 0;
            }

            m_ScoreEntity.ReplaceGameScore(m_Score);
        }

        protected override bool Filter(GuiEntity entity) => true;

        protected override ICollector<GuiEntity> GetTrigger(IContext<GuiEntity> context)
        {
            return context.CreateCollector(new TriggerOnEvent<GuiEntity>[]
            {
                new TriggerOnEvent<GuiEntity>(GuiMatcher.AddScore, GroupEvent.Added),
                new TriggerOnEvent<GuiEntity>(GuiMatcher.ResetScore, GroupEvent.Added)
            });
        }
    }
}
