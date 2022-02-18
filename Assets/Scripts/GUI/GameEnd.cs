using Cysharp.Threading.Tasks.Linq;
using State;
using UnityEngine;

namespace GUI {
  public class GameEnd {
    private GameObject winText;

    public GameEnd(ScoreState score, GameObject winText) {
      this.winText = winText;
      winText.SetActive(false);
      
      score.value.Subscribe(Update);
    }

    private void Update(int score) {
      if (score >= 12) {
        winText.SetActive(true);
      }
    }
  }
}
