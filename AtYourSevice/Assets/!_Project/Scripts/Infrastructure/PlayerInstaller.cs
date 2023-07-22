using PlayerComponents;
using UnityEngine;
using Zenject;

namespace Infrastructure
{
    public class PlayerInstaller : MonoInstaller
    {
        public Player Player;
        public Transform SpawnPoint;
        public Transform LevelParent;
        
        public override void InstallBindings()
        {
            Player playerInstance = Container.InstantiatePrefabForComponent<Player>(
                    Player, SpawnPoint.position, Quaternion.identity, LevelParent);

            Container.Bind<Player>().FromInstance(playerInstance).AsSingle();
        }
    }
}
