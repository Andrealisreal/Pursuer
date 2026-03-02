using Pursuer.Scripts.Players.Inputs;
using UnityEngine;

namespace Pursuer.Scripts.Players
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(CapsuleCollider))]
    public class Player : MonoBehaviour
    {
        private PlayerInput _input;
        private PlayerMover _playerMover;

        private void OnEnable()
        {
            _input.Enable();
        }

        private void OnDisable()
        {
            _input.Disable();
        }

        public void Initialize(PlayerInput input, PlayerMover playerMover)
        {
            _input = input;
            _playerMover = playerMover;
        }
    }
}