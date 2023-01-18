using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using HyperCasual.View;
using Entitas;
using DG.Tweening;

namespace HyperCasual.GUI
{
    public class GameScoreView : UnityView<GuiEntity>, IGameScoreListener
    {
        [SerializeField] private TMP_Text m_Text;

        private Queue<int> m_StoredScores = new Queue<int>();
        private Tweener m_ScoreTweener;

        public override void Link(GuiEntity entity)
        {
            base.Link(entity);

            entity.AddGameScoreListener(this);
        }

        public void OnGameScore(GuiEntity entity, int gameScore)
        {
            m_StoredScores.Enqueue(gameScore);
            if (m_ScoreTweener == null)
                DoEffectPunch();
        }

        private void DoEffectPunch()
        {
            m_Text.text = m_StoredScores.Dequeue().ToString();
            m_ScoreTweener = transform.DOPunchScale(new Vector3(0.25f, 0.25f, 0.25f), 0.25f, 1).OnComplete(() =>
            {
                if (m_StoredScores.Count > 0)
                    DoEffectPunch();
                else
                    m_ScoreTweener = null;
            });
        }
    }
}
