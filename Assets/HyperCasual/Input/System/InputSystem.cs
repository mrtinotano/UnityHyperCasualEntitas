using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;
using UnityEngine.EventSystems;

namespace HyperCasual.Input
{
    public class InputSystem : IExecuteSystem
    {
        private Contexts m_Contexts;
        private InputEntity m_InputEntity;

        public InputSystem(Contexts contexts)
        {
            m_Contexts = contexts;
            m_InputEntity = contexts.input.CreateEntity();
            m_InputEntity.AddInputState(InputStateComponent.InputState.None);
        }

        public void Execute()
        {
            if (m_Contexts.game.gameState.CurrentGameState != Game.GameStateComponent.GameState.GameRunning)
                return;

            if (UnityEngine.Input.touchCount > 0 && EventSystem.current.IsPointerOverGameObject(UnityEngine.Input.GetTouch(0).fingerId))
                return;

            if (m_Contexts.input.isDisableInput)
            {
                if (m_InputEntity.inputState.CurrentInputState != InputStateComponent.InputState.None)
                    m_InputEntity.ReplaceInputState(InputStateComponent.InputState.None);

                return;
            }

            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                SetInputInfo(InputStateComponent.InputState.Pressed);
                return;
            }

            if (UnityEngine.Input.GetMouseButton(0))
            {
                SetInputInfo(InputStateComponent.InputState.Hold);
                return;
            }

            if (UnityEngine.Input.GetMouseButtonUp(0))
            {
                SetInputInfo(InputStateComponent.InputState.Released);
                return;
            }
        }

        private void SetInputInfo(InputStateComponent.InputState state)
        {
            m_InputEntity.ReplaceInputState(state);
            m_InputEntity.ReplaceInputPosition(Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition));
        }
    }
}
