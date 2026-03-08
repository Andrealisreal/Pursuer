using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    public class EnemyMover
    {
        public void Move(Rigidbody rigidbody, Vector3 targetPosition, EnemyConfig config, EnemyNavigator navigator)
        {
            var direction = (targetPosition - rigidbody.position).normalized;
            var velocity = direction * config.Speed;

            rigidbody.MoveRotation(Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z)));

            if (navigator.IsSlope(rigidbody, config))
                return;

            if (navigator.HasObstacle(rigidbody, config))
            {
                if (navigator.IsStep(rigidbody, config))
                {
                    rigidbody.linearVelocity = new Vector3(rigidbody.linearVelocity.x,
                        config.StepHeight * config.StepSmooth, rigidbody.linearVelocity.z);
                }
                else
                {
                    rigidbody.linearVelocity = new Vector3(0, rigidbody.linearVelocity.y, 0);

                    return;
                }
            }

            rigidbody.linearVelocity = new Vector3(velocity.x, rigidbody.linearVelocity.y, velocity.z);
        }
    }
}