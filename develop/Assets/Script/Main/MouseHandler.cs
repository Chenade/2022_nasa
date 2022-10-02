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
        if (MainSystem.is_placing)
        {
            if (!MainSystem.moving_target)
                MainSystem.moving_target = GameObject.Instantiate(star_1);
            mousePos = Input.mousePosition;
            mousePos.z = Camera.main.nearClipPlane + 1;
            worldPos = Camera.main.ScreenToWorldPoint(mousePos);
            MainSystem.moving_target.transform.position = worldPos;
            if (Input.GetMouseButtonDown(0))
            {
                MainSystem.is_placing = false;
                MainSystem.moving_target = null;
            }
        }

        if (Input.GetMouseButtonDown(1))
            Debug.Log("Pressed secondary button.");

        if (Input.GetMouseButtonDown(2))
            Debug.Log("Pressed middle click.");
    }
}
