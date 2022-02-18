using TMPro;
using UnityEngine;
using Zenject;

namespace GUI {
  public class GUIInstaller : MonoInstaller<GUIInstaller> {
    [SerializeField] private TextMeshProUGUI countText;
    [SerializeField] private GameObject winText;
    
    public override void InstallBindings() {
      Container.Bind<TextMeshProUGUI>().FromInstance(countText).AsSingle();
      Container.Bind<GameObject>().FromInstance(winText).AsSingle();
      
      Container.Bind<HUD>().AsSingle().NonLazy();
      Container.Bind<GameEnd>().AsSingle().NonLazy();
    }
  }
}
