using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace BouncingBall
{
    [Config, Unique]
    public interface IGameConfig
    {
        public int StairsAmount { get; }
        public int MaxConsecutiveEnemies { get; }
    }
}
