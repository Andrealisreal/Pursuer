using UnityEngine;

namespace Pursuer.Scripts.Players
{
    public class PlayerMover
    {
        public void Move(CharacterController controller, Vector2 direction, float speed, float gravity)
        {
            direction.Normalize();
            controller.Move(new Vector3(direction.x, gravity, direction.y) * (speed * Time.fixedDeltaTime));
        }
    }
}