using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace JewelsExplosion.Game
{
    [Game, Event(EventTarget.Self)]
    public class ActiveGameObjectComponent : IComponent
    {
        public bool IsActive;
    }
}
