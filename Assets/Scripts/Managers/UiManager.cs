using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager
{
    // ���̽�ƽ
    public JoyStickController _joyStickController;
    public GameObject _joyStick;

    // �κ��丮
    public InventoryController _inventoryController;
    public GameObject _inven;

    public void Init()
    {
        // �����ϸ� ���̽�ƽ ���� �ҷ���
        GameObject joystick = GameManager.Resource.GetUi("Ui_JoystickController");
        _joyStick = GameObject.Instantiate<GameObject>(joystick);
         _joyStickController = _joyStick.GetComponentInChildren<JoyStickController>();
        // �����ϸ� �κ��丮��ư(���������) ���� �ҷ���
        GameObject invenButton = GameManager.Resource.GetUi("Ui_SceneInventoryButton");
        GameObject.Instantiate<GameObject>(invenButton);
        // �����ϸ� �κ��丮�� �̸� �ҷ��ͼ� �켱 SetActive(false)�� ��
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
