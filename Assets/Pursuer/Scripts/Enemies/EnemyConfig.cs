using UnityEngine;

namespace Pursuer.Scripts.Enemies
{
    [CreateAssetMenu(fileName = "EnemyStats", menuName = "Scriptable Objects/EnemyStats")]
    public class EnemyConfig : CharacterConfig
    {
        [field: SerializeField] public float MinDistanceTarget { get; private set; }
        [field: SerializeField] public float DistanceRayGround { get; private set; }
        [field: SerializeField] public float DistanceRayLadder { get; private set; }
        [field: SerializeField] public Vector3 OffsetRay { get; private set; }
        [field: SerializeField] public LayerMask LadderMask { get; private set; }
        
        [Header("Step Settings")]
        [field: SerializeField] public float StepHeight { get; private set; } = 0.4f;
        [field: SerializeField] public float StepSmooth { get; private set; } = 4f;

        [Header("Slope Settings")]
        [field: SerializeField] public float MaxSlopeAngle { get; private set; } = 45f;
        [field: SerializeField] public LayerMask GroundMask { get; private set; }
    }
}