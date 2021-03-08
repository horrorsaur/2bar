using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] private Transform waypoint;

    private void OnTriggerEnter2D(Collider2D _target)
    {
        if(waypoint != null)
        {
            Debug.Log(_target.gameObject.name + " : " + gameObject.name + " : " + Time.time);
            PlayerController player = _target.gameObject.GetComponent<PlayerController>();
            player.SetCanMove(false);
            player.gameObject.transform.position = waypoint.position;
            player.SetCanMove(true);
        } else
        {
            Debug.LogError("No waypoint has been set. Exiting.");
            return;
        }
    }
}
