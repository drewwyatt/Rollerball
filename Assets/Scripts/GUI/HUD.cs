using Cysharp.Threading.Tasks.Linq;
using State;
using TMPro;
using Zenject;

namespace GUI {
  public class HUD {
    private TextMeshProUGUI countText;

    public HUD(ScoreState score, [Inject(Id = "count-text")] TextMeshProUGUI countText) {
      this.countText = countText;
      score.value.Subscribe(Update);
    }

    private void Update(int score) {
      countText.text = $"Count: {score}";
    }
  }
}
