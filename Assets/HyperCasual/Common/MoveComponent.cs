using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using System;

namespace JewelsExplosion.Game
{
    [Game, Event(EventTarget.Self)]
    public class MoveComponent : IComponent
    {
        public Vector3 MoveWorldPosition;
        public float MoveSpeed;
        public Action OnMoveFinish;
    }
}
