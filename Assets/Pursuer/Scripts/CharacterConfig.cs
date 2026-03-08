using UnityEngine;

namespace Pursuer.Scripts
{
    public abstract class CharacterConfig : ScriptableObject
    {
        [field: SerializeField] public float Speed { get; private set; }
    }
}