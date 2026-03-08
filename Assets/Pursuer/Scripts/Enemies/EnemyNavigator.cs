using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    public class EnemyNavigator
    {
        public bool IsTargetReached(Vector3 targetPosition, Vector3 position, float minDistanceTarget) =>
            (position - targetPosition).sqrMagnitude < minDistanceTarget * minDistanceTarget;

        public bool IsSlope(Rigidbody rigidbody, EnemyConfig config)
        {
            if (Physics.Raycast(rigidbody.position, Vector3.down,
                    out var hit, config.DistanceRayGround, config.GroundMask) == false)
                return false;
            
            return Vector3.Angle(hit.normal, Vector3.up) > config.MaxSlopeAngle;
        }

        public bool IsStep(Rigidbody rigidbody, EnemyConfig config)
        {
            var origin = rigidbody.position + config.OffsetRay;
            var stepOrigin = origin + Vector3.up * config.StepHeight;
            var forward = rigidbody.transform.forward;
            
            var hasObstacle = Physics.Raycast(origin, forward, config.DistanceRayGround, config.LadderMask);
            var hasSpaceAbove = Physics.Raycast(stepOrigin, forward, config.DistanceRayLadder, config.LadderMask) == false;

            return hasObstacle && hasSpaceAbove;
        }

        public bool HasObstacle(Rigidbody rigidbody, EnemyConfig config)
        {
            var origin = rigidbody.position + config.OffsetRay;
            var forward = rigidbody.transform.forward;
            
            return Physics.Raycast(origin, forward, config.DistanceRayGround, config.LadderMask);
        }
    }
}