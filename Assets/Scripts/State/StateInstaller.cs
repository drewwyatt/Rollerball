using Zenject;

namespace  State {
  public class StateInstaller : MonoInstaller<StateInstaller> {
    public override void InstallBindings() {
      Container.Bind<ScoreState>().AsSingle();
    }
  }
}
