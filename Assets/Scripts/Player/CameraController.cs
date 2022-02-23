using Zenject;

namespace Player {
  public class CameraController : ILateTickable {
    private readonly CameraModel model;
    private readonly PlayerModel player;

    public CameraController(CameraModel model, PlayerModel player) {
      this.model = model;
      this.player = player;
    }
  
    public void LateTick() {
      model.UpdatePosition(player.position);
    }
  }
}
