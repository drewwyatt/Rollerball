using UnityEngine;
namespace State {
  public class ScoreState : Reducer<int> {
    public int value {
      get;
      private set;
    }

    public void HandlePickup() {
      value++;
    }
  }
}
