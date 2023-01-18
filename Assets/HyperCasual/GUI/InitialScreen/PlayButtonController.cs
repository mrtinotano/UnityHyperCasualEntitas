using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.GUI
{
    public class PlayButtonController : ButtonController
    {
        [SerializeField] private Transform m_TextChild;

        private void OnEnable()
        {
            m_TextChild.DOPunchScale(new Vector3(0.25f, 0.25f, 0.25f), 1f, 1).SetLoops(-1);
        }

        protected override void OnButtonClick()
            => Contexts.sharedInstance.game.ReplaceGameState(Game.GameStateComponent.GameState.GameRunning);
    }
}
