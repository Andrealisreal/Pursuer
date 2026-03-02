using Pursuer.Scripts.Enemies;
using Pursuer.Scripts.Players;
using Pursuer.Scripts.Players.Inputs;
using UnityEngine;

namespace Pursuer.Scripts
{
    public class Bootstrapper : MonoBehaviour
    {
        [SerializeField] private Player _player;
        [SerializeField] private Enemy _enemy;
        
        private PlayerInput _playerInput;

        private void Awake()
        {
            _playerInput.Initialize();
            _player.Initialize(_playerInput, new PlayerMover());
            _enemy.Initialize(new EnemyFollower(), new EnemyMover());
        }
    }
}