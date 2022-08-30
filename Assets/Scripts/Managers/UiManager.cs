using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager
{
    // 조이스틱
    public JoyStickController _joyStickController;
    public GameObject _joyStick;

    // 인벤토리
    public InventoryController _inventoryController;
    public GameObject _inven;

    public void Init()
    {
        // 시작하면 조이스틱 씬에 불러옴
        GameObject joystick = GameManager.Resource.GetUi("Ui_JoystickController");
        _joyStick = GameObject.Instantiate<GameObject>(joystick);
         _joyStickController = _joyStick.GetComponentInChildren<JoyStickController>();
        // 시작하면 인벤토리버튼(가방아이콘) 씬에 불러옴
        GameObject invenButton = GameManager.Resource.GetUi("Ui_SceneInventoryButton");
        GameObject.Instantiate<GameObject>(invenButton);
        // 시작하면 인벤토리를 미리 불러와서 우선 SetActive(false)로 함
        GameObject inven = GameManager.Resource.GetUi("Ui_Inventory");
        _inven = GameObject.Instantiate<GameObject>(inven);
        _inventoryController = _inven.GetComponentInChildren<InventoryController>();
        InventoryClose();
    }

    public void InventoryOpen()
    {
        _inventoryController.gameObject.SetActive(true);
    }

    public void InventoryClose()
    {
        _inventoryController.gameObject.SetActive(false);
    }
}
