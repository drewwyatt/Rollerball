using TMPro;
using UnityEngine;
using Zenject;

namespace GUI {
  public class GUIInstaller : MonoInstaller<GUIInstaller> {
    [SerializeField] private TextMeshProUGUI countText;
    
    public override void InstallBindings() {
      Container.Bind<TextMeshProUGUI>().WithId("count-text").FromInstance(countText).AsSingle();
      Container.BindInterfacesTo<HUD>().AsSingle().NonLazy();
    }
  }
  
  public class Foo : MonoInstaller<GUIInstaller> {
    [SerializeField] private GameObject player;

    public override void InstallBindings() {
      Container.Bind<Transform>().FromInstance(player.transform).AsSingle();
    }
  }
}
