using Cysharp.Threading.Tasks;

namespace State {
  public class ScoreState : Reducer<int> {
    public AsyncReactiveProperty<int> value {
      get;
    } = new AsyncReactiveProperty<int>(0);

    public void HandlePickup() {
      value.Value++;
    }

    public override string ToString() => value.Value.ToString();
    public static implicit operator int(ScoreState state) => state.value.Value;
  }
}
