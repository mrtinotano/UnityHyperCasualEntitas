using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace HyperCasual.GUI
{
    [Gui, Unique]
    public class AddScoreComponent : IComponent
    {
        public int Score;
    }
}
