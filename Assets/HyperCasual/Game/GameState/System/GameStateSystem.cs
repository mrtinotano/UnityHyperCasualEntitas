using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

namespace HyperCasual.Game
{
    public class GameStateSystem : IInitializeSystem
    {
        private Contexts m_Contexts;

        public GameStateSystem(Contexts contexts) => m_Contexts = contexts;

        public void Initialize() =>
            m_Contexts.game.CreateEntity().AddGameState(GameStateComponent.GameState.GameStart);
    }
}
