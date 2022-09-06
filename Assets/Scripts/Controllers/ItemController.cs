using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    // �÷��̾� �ݶ��̴� Ȯ�ο�
    Collider _playerCollider;
    // Start is called before the first frame update
    private void Start()
    {
        _playerCollider = GameManager.Obj._playerController.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigger");
        // �÷��̾� �ݶ��̴��� �浹�ϸ�
        if(other == _playerCollider)
        {
            // ������ �κ��丮�� �ֱ�
            GameManager.Ui._inventoryController._item.Add(gameObject);
            // ������ �κ��� ���� ���� Ȯ��
            int count = GameManager.Ui._inventoryController._item.Count;
            // �κ� ���ڿ� ���ؼ� �������� ����
            GameManager.Ui._inventoryController._invenSlotArray[count - 1]._SlotItem.Add(gameObject);

            // �κ��� ���ڿ� ���ؼ� �������� count��° ���Կ� �ֱ�
            //GameManager.Ui._inventoryController._invenSlotList[count - 1]._SlotItem.Add(gameObject);

            // ������ ó���� ���߿� ��� �غ� ������
            // ���ڰ� �����ϱ� �׳� ���� �ص� ������ �� ���� ��Ʈ���̵� ��� ������
            gameObject.SetActive(false);
        }
    }
}
