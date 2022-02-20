using UnityEngine;
using Zenject;

namespace Player {
  public class PlayerInstaller : MonoInstaller<PlayerInstaller> {
    [SerializeField] private GameObject player;
    
    public override void InstallBindings() {
      Container.BindInterfacesAndSelfTo<PlayerModel>().AsSingle();
      Container.Bind<Rigidbody>().FromInstance(player.GetComponent<Rigidbody>()).AsSingle();
    }
  }
}
