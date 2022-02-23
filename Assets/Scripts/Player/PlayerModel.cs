using State;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Player {
  public class PlayerModel : IFixedTickable {
    private Rigidbody rb;
    private Vector2 movement;
    private ScoreState score;
    public readonly Transform transform;
    private float speed = 10;

    public PlayerModel(Rigidbody rb, ScoreState score, Transform transform) {
      this.rb = rb;
      this.score = score;
      this.transform = transform;
    }

    public Vector3 position { get { return transform.position; } }

    public void HandleInput(InputValue value) {
      movement = value.Get<Vector2>();
    }

    public void HandleCollision(Collider collider) {
      if (IsPickup(collider.gameObject)) {
        collider.gameObject.SetActive(false);
        score.HandlePickup();
      }
    }

    public void FixedTick() {
      var movementVec = new Vector3(movement.x, 0, movement.y);
      rb.AddForce(movementVec * speed);
    }

    private static bool IsPickup(GameObject gameObject) => gameObject.CompareTag("Pickup");
  }
}
