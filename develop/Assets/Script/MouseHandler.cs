using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHandler : MonoBehaviour
{

    public Texture2D cursor_default;

    void Start()
    {
        Cursor.SetCursor(cursor_default, Vector2.zero, CursorMode.ForceSoftware);
    }

    public GameObject star_1;
    public Vector3 mousePos;
    public Vector3 worldPos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (MainSystem.is_placing)
            {
                mousePos = Input.mousePosition;
                mousePos.z = Camera.main.nearClipPlane + 1;
                worldPos = Camera.main.ScreenToWorldPoint(mousePos);
                GameObject add_new = GameObject.Instantiate(star_1);
                add_new.transform.position = worldPos;
                MainSystem.is_placing = false;
            }
        }

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }
}
