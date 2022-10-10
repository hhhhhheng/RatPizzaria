using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectables : MonoBehaviour
{
    public Transform[] waypoints;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Ingredient")) {
            int waypointIndex = Random.Range(0, waypoints.Length);
            other.gameObject.transform.position = waypoints[waypointIndex].transform.position;
        }
    }
}
