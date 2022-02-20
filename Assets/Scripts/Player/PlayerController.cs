using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Player {
  public class PlayerController : MonoBehaviour {
    private PlayerModel model;

    [Inject]
    public void Initialize(PlayerModel model) {
      this.model = model;
    }

    public void OnMove(InputValue value) {
      model.HandleInput(value);
    }

    private void OnTriggerEnter(Collider collider) {
      model.HandleCollision(collider);
    }
  }
}
