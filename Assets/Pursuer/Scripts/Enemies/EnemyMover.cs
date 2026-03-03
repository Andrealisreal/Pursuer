using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    public class EnemyMover
    {
        public void Move(Rigidbody rigidbody, Vector3 targetPosition, float speed)
        {
            var direction = (targetPosition - rigidbody.position).normalized;
            var newPosition = rigidbody.position + direction * (speed * Time.fixedDeltaTime);
            
            rigidbody.MovePosition(newPosition);
        }
    }
}