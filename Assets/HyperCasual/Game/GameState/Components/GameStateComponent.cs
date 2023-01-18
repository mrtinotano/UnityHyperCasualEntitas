using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace HyperCasual.Game
{
    [Game, Unique]
    public class GameStateComponent : IComponent
    {
        public enum GameState
        {
            GameStart,
            GameRunning,
            GameOver
        }

        public GameState CurrentGameState;
    }
}
