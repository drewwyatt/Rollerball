using System;
using Zenject;

namespace State {
  public class StateInstaller : MonoInstaller {
    public override void InstallBindings() {
      Container.Bind<ScoreState>().AsSingle().NonLazy();
    }
  }
}
