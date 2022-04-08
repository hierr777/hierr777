using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scopeBehavior : MonoBehaviour
{
  [Space]
  [Header("Components")]
  //public playerControlls player;
  public Transform hand;
  [Space]
  [Header("settings")]
  public bool active=false;
  [Space]
  [Header("data")]
  public Vector3 coords;
  public float degs;

  void Update()
  {
    if (active) {
      coords=transform.position;
      degs=Vector3.Angle(hand.TransformDirection(Vector3.right),Vector3.Normalize((coords-hand.position)));
      hand.Rotate(0,0,degs);
      if (Vector3.Angle(hand.TransformDirection(Vector3.right),Vector3.Normalize((coords-hand.position)))>degs) {
        degs=-Vector3.Angle(hand.TransformDirection(Vector3.right),Vector3.Normalize((coords-hand.position)));
        hand.Rotate(0,0,degs);
      }
    }
  }
}
