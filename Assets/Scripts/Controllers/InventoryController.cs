using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InventoryController : MonoBehaviour, IDragHandler, IBeginDragHandler
{
    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
        Debug.Log("OnDrag");
    }


    public void CloseInventory()
    {
        // �κ��丮 �ݱ� Ui�� Ui�Ŵ������� ������
        GameManager.Ui.InventoryClose();
    }

    public void OpenInventory()
    {
        // �κ��丮 ���� Ui�� Ui�Ŵ������� ������
        GameManager.Ui.InventoryOpen();
    }

}
