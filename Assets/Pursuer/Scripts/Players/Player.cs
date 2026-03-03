using Pursuer.Scripts.Players.Inputs;
using UnityEngine;

namespace Pursuer.Scripts.Players
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(CapsuleCollider))]
    public class Player : MonoBehaviour
    {
        private PlayerStats _stats;
        private PlayerInput _input;
        private PlayerMover _mover;
        private CharacterController _controller;

        private void Awake() =>
            _controller = GetComponent<CharacterController>();

        private void FixedUpdate() =>
            _mover.Move(_controller, _input.Movement, _stats.Speed, _stats.Gravity);

        private void OnEnable() =>
            _input.Enable();

        private void OnDisable() =>
            _input.Disable();

        public void Initialize(PlayerInput input, PlayerMover playerMover, PlayerStats stats)
        {
            _stats = stats;
            _input = input;
            _mover = playerMover;
        }
    }
}