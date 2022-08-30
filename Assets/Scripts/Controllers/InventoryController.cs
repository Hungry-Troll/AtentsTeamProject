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
        // 인벤토리 닫기 Ui는 Ui매니저에서 관리함
        GameManager.Ui.InventoryClose();
    }

    public void OpenInventory()
    {
        // 인벤토리 열기 Ui는 Ui매니저에서 관리함
        GameManager.Ui.InventoryOpen();
    }

}
