using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameCursor : MonoBehaviour
{
    public float sensitivity=0.1f;
    public Vector3 offset;

    void Start(){
      Cursor.lockState=CursorLockMode.Locked;
    }
    void Update()
    {
        offset=new Vector3((Input.GetAxis("Mouse X")*sensitivity),Input.GetAxis("Mouse Y")*sensitivity,0);
        transform.Translate(offset);
    }
}
