using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(CapsuleCollider))]
    public class Enemy : MonoBehaviour
    {
        private EnemyMover _mover;
        private EnemyConfig _config;
        private EnemyNavigator _navigator;
        private Transform _target;
        private Rigidbody _rigidbody;

        private void Awake() =>
            _rigidbody = GetComponent<Rigidbody>();

        private void Start() =>
            _rigidbody.freezeRotation = true;

        private void FixedUpdate()
        {
            if (_navigator.IsTargetReached(_target.position, _rigidbody.position, _config.MinDistanceTarget))
                return;
            
            _mover.Move(_rigidbody, _target.position, _config, _navigator);
        }

        public void Initialize(EnemyMover mover, EnemyConfig config, Transform target, EnemyNavigator navigator)
        {
            _mover = mover;
            _target = target;
            _config = config;
            _navigator = navigator;
        }
    }
}