using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager
{
    public JoyStickController _joyStickController;
    public GameObject _joyStick;

    public void Init()
    {
        GameObject temp = GameManager.Resource.GetUi("Ui_JoystickController");
        _joyStick = GameObject.Instantiate<GameObject>(temp);
         _joyStickController = _joyStick.GetComponentInChildren<JoyStickController>();
    }
}
