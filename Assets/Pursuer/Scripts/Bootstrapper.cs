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
        [SerializeField] private PlayerConfig playerConfig;

        [Header("Settings Enemy")]
        [SerializeField] private Enemy _enemy;
        [SerializeField] private EnemyConfig enemyConfig;

        private PlayerInput _playerInput;

        private void Awake()
        {
            _playerInput = new PlayerInput();
            _playerInput.Initialize();
            _player.Initialize(_playerInput, new PlayerMover(), playerConfig);
            _enemy.Initialize(new EnemyMover(), enemyConfig, _player.transform, new EnemyNavigator());
        }
    }
}