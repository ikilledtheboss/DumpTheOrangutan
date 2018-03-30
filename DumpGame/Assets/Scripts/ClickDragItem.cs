using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDragItem : MonoBehaviour
{
    public int Drag;
  //  public Vector3 StartLoc;

    void Start()
    {
        Drag = 0;
    }

    void OnMouseDrag()
    {
      //  StartLoc = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Drag = 1;
        Vector3 CurrentLoc = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 9f);
        Vector3 CurrentPos = Camera.main.ScreenToWorldPoint(CurrentLoc);
        transform.position = CurrentPos;
    }

    void OnMouseUp()
    {
        Drag = 2;
    }
}
