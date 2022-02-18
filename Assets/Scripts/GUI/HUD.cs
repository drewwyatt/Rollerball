using State;
using TMPro;
using Zenject;

namespace GUI {
  public class HUD : ITickable {
    private TextMeshProUGUI countText;
    private ScoreState score;
    
    public HUD(ScoreState scoreState, [Inject(Id = "count-text")] TextMeshProUGUI countText) {
      score = scoreState;
      this.countText = countText;
    }

    public void Tick() {
      countText.text = $"Count: {score}";
    }
  }
}
