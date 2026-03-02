using UnityEngine;

namespace Pursuer.Scripts.Players.Inputs
{
    public class PlayerInput
    {
        public Vector2 Movement => _inputAction.Player.Movement.ReadValue<Vector2>();

        private InputActions _inputAction;

        public void Initialize() =>
            _inputAction = new InputActions();

        public void Enable() =>
            _inputAction.Enable();

        public void Disable() =>
            _inputAction.Disable();
    }
}