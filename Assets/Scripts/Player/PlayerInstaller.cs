using UnityEngine;
using Zenject;

namespace Player {
  public class PlayerInstaller : MonoInstaller<PlayerInstaller> {
    public override void InstallBindings() {
      Container.Bind<Rigidbody>().FromComponentOnRoot().AsSingle();
    }
  }
}
