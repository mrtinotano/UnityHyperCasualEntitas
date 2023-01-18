using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace HyperCasual.Game
{
    [Game, Event(EventTarget.Self)]
    public class WorldPositionComponent : IComponent
    {
        public Vector3 Position;
    }
}
