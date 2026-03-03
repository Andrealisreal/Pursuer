using Pursuer.Scripts.Enemies;
using Pursuer.Scripts.Players;
using Pursuer.Scripts.Players.Inputs;
using UnityEngine;

namespace Pursuer.Scripts
{
    public class Bootstrapper : MonoBehaviour
    {
        [Header("Settings Player")]
        [SerializeField] private Player _player;
        [SerializeField] private PlayerStats _playerStats;
        
        [Header("Settings Enemy")]
        [SerializeField] private Enemy _enemy;
        
        private PlayerInput _playerInput;

        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerInput.Initialize();
            _player.Initialize(_playerInput, new PlayerMover(), _playerStats);
            _enemy.Initialize(new EnemyFollower(), new EnemyMover());
        }
    }
}