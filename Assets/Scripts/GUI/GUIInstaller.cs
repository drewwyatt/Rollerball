using TMPro;
using UnityEngine;
using Zenject;

namespace GUI {
  public class GUIInstaller : MonoInstaller<GUIInstaller> {
    [SerializeField] private TextMeshProUGUI countText;
    
    public override void InstallBindings() {
      Container.Bind<TextMeshProUGUI>().WithId("count-text").FromInstance(countText).AsSingle();
      Container.Bind<HUD>().AsSingle().NonLazy();
    }
  }
}
