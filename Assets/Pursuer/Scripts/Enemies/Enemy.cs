using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(CapsuleCollider))]
    public class Enemy : MonoBehaviour
    {
        private EnemyFollower _follower;
        private EnemyMover _mover;

        public void Initialize(EnemyFollower follower, EnemyMover mover)
        {
            _follower = follower;
            _mover = mover;
        }
    }
}
