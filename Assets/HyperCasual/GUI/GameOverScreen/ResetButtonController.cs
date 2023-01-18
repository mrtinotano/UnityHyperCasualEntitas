using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.GUI
{
    public class ResetButtonController : ButtonController
    {
        protected override void OnButtonClick()
        {
            Contexts.sharedInstance.game.ReplaceGameState(Game.GameStateComponent.GameState.GameStart);
            Contexts.sharedInstance.gui.isResetScore = true;
        }
    }
}
