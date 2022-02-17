using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
  public float speed = 0;
  public TextMeshProUGUI countText;
  public GameObject winText;
  
  private Rigidbody rb;
  private float movementX;
  private float movementY;
  private int count;

  public void Start() {
    count = 0;
    rb = GetComponent<Rigidbody>();
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
      count++;
      UpdateCountText();
    }
  }

  private void UpdateCountText() {
    countText.text = $"Count: {count}";
    if (count >= 12) {
      winText.SetActive(true);
    }
  }
}
