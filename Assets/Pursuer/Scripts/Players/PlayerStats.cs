using UnityEngine;

namespace Pursuer.Scripts.Players
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/PlayerStats")]
    public class PlayerStats : ScriptableObject
    {
        public float Gravity = -9.81f;
        public float Speed;
    }
}
