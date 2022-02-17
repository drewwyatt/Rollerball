using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    
    public void Start() {
        rb = GetComponent<Rigidbody>();
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
      }
    }
}
