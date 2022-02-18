using State;
using UnityEngine;
using UnityEngine.InputSystem;
using Zenject;

namespace Player {
  public class PlayerController : MonoBehaviour {
    public float speed = 0;
    public GameObject winText;
  
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    private ScoreState score;

    [Inject]
    public void Initialize(ScoreState scoreState, Rigidbody rb) {
      score = scoreState;
      this.rb = rb;
    }

    public void Start() {
      winText.gameObject.SetActive(false);
      UpdateCountText();
    }

    public void OnMove(InputValue value) {
      var vec = value.Get<Vector2>();
      movementX = vec.x;
      movementY = vec.y;
    }

    public void FixedUpdate() {
      var movement = new Vector3(movementX, 0.0f, movementY);
      rb.AddForce(movement * speed);
    }

    private void OnTriggerEnter(Collider other) {
      if (other.gameObject.CompareTag("Pickup")) {
        other.gameObject.SetActive(false);
        score.HandlePickup();
        UpdateCountText();
      }
    }

    private void UpdateCountText() {
      // countText.text = $"Count: {score}";
      if (score >= 12) {
        winText.SetActive(true);
      }
    }
  }
}
