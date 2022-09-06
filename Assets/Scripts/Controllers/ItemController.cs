using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // 플레이어 콜라이더 확인용
    Collider _playerCollider;
    // Start is called before the first frame update
    private void Start()
    {
        _playerCollider = GameManager.Obj._playerController.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger");
        // 플레이어 콜라이더와 충돌하면
        if(other == _playerCollider)
        {
            // 아이템 인벤토리에 넣기
            GameManager.Ui._inventoryController._item.Add(gameObject);
            // 아이템 인벤에 넣은 숫자 확인
            int count = GameManager.Ui._inventoryController._item.Count;
            // 인벤 숫자와 비교해서 아이템을 넣음
            GameManager.Ui._inventoryController._invenSlotArray[count - 1]._SlotItem.Add(gameObject);

            // 인벤에 숫자와 비교해서 아이템을 count번째 슬롯에 넣기
            //GameManager.Ui._inventoryController._invenSlotList[count - 1]._SlotItem.Add(gameObject);

            // 아이템 처리는 나중에 고민 해볼 문제임
            // 숫자가 적으니까 그냥 따로 해도 괜찮을 것 같음 디스트로이도 상관 없을듯
            gameObject.SetActive(false);
        }
    }
}
