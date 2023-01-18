using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace HyperCasual.Input
{
    [Input, Unique]
    public class InputStateComponent : IComponent
    {
        public enum InputState
        {
            None,
            Pressed,
            Hold,
            Released
        }

        public InputState CurrentInputState;
    }
}
