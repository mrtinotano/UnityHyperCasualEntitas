using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;
using System;

namespace JewelsExplosion.Game
{
    [Game, Event(EventTarget.Self)]
    public class MovePathComponent : IComponent
    {
        public Vector3[] PathWorldPositions;
        public float MoveSpeed;
        public Action OnPathFinish;
    }
}