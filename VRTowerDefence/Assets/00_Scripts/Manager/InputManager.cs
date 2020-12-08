using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;
    public Action<Define.MouseAction> MouseAction = null;

    public void OnKeyboard()
    {
        if (Input.anyKey && KeyAction != null)
            KeyAction.Invoke();
    }

    public void OnMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MouseAction.Invoke(Define.MouseAction.LeftDown);
        }

        if (Input.GetMouseButton(0))
        {
            MouseAction.Invoke(Define.MouseAction.LeftPress);
        }

        if (Input.GetMouseButtonUp(0))
        {
            MouseAction.Invoke(Define.MouseAction.LeftUp);
        }
    }

}
