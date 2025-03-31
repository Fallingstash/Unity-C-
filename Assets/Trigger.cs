using UnityEngine;

public class Trigger : MonoBehaviour
{
  private void OnTriggerExit(Collider other) {
    Debug.Log($"В тригер вошел {other.name}");
  }
}
