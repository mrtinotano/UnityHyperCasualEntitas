using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace HyperCasual.GUI
{
    [Gui, Event(EventTarget.Self)]
    public class GameScoreComponent : IComponent
    {
        public int GameScore;
    }
}
