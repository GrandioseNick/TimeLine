using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChanger : MonoBehaviour
{

    public Texture2D cursorarrow;
    public Vector3 worldPosition;
    void Start()
    {
        //Cursor.visible = false;
        Cursor.SetCursor(cursorarrow, Vector2.zero, CursorMode.ForceSoftware);
    }
    private void Update()
    {
        Plane plane = new Plane(Vector3.up, 0);
        float distance;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (plane.Raycast(ray, out distance))
        {
            worldPosition = ray.GetPoint(distance);
        }
    }
    
}
