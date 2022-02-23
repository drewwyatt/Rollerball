using UnityEngine;
using Zenject;

namespace Player {
  public class PlayerInstaller : MonoInstaller<PlayerInstaller> {
    [SerializeField] private GameObject camera;
    [SerializeField] private GameObject player;
    
    public override void InstallBindings() {
      Container.BindInterfacesAndSelfTo<PlayerModel>().AsSingle();
      Container.Bind<Rigidbody>().FromInstance(player.GetComponent<Rigidbody>()).AsSingle();
      Container.Bind<Transform>().FromInstance(player.transform).AsSingle();

      Container.Bind<CameraModel>().FromInstance(new CameraModel(camera, player.transform.position)).AsSingle();
      Container.BindInterfacesTo<CameraController>().AsSingle();
    }
  }
}
