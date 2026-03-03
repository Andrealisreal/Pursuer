using UnityEngine;

namespace Pursuer.Scripts.Players
{
    [CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/PlayerStats")]
    public class PlayerConfig : CharacterConfig
    {
        public float Gravity = -9.81f;
    }
}