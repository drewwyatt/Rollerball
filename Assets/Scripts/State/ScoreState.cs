namespace State {
  public class ScoreState : Reducer<int> {
    public int value {
      get;
      private set;
    }

    public void HandlePickup() {
      value++;
    }

    public override string ToString() {
      return value.ToString();
    }

    public static implicit operator int(ScoreState state) => state.value;
  }
}
