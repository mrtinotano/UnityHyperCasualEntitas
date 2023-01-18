using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace HyperCasual.View
{
    [Game]
    public class ViewComponent : IComponent
    {
        public UnityView<GameEntity> View;
    }
}
