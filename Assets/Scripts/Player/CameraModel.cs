using UnityEngine;

namespace Player {
  public class CameraModel {
    private readonly GameObject camera;
    private readonly Vector3 offset;
    private Vector3 position {
      get {
        return camera.transform.position;
      }
      set {
        camera.transform.position = value;
      }
    }

    public CameraModel(GameObject camera, Vector3 playerPosition) {
      this.camera = camera;
      offset = position - playerPosition;
    }

    public void UpdatePosition(Vector3 playerPosition) {
      position = playerPosition + offset;
    }
  }
}
