using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldManager : MonoBehaviour
{
    PlayerController _player;
    public GameObject _startPosObject;
    public Vector3 _startPos;

    private void Awake()
    {
        // ���ӸŴ������� Ui�Ŵ��� Init(Awake �Լ� ��ü)
        // Ui �ҷ���
        GameManager.Ui.Init();
        // �÷��̾� ĳ���� ����
        // ���� �÷��̾� ����â���� string ���� �̸��� �޾ƿ��� ��
        // ������ġ�� �ʸ��� �ٸ��� �ؾ� ��
        _startPos = _startPosObject.transform.position;
        CreatePlayerCharacter(_startPos, "player");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreatePlayerCharacter(Vector3 origin , string playerName)
    {
        // ������ ���̸� ���� ���� ���̿� ���� ĳ���� ���� �ڵ�
        origin.y += 100f;
        RaycastHit hit;
        if (Physics.Raycast(origin, -Vector3.up, out hit, Mathf.Infinity))
        {
            GameObject temPlayerChar = GameManager.Resource.GetCharacter(playerName);
            if (temPlayerChar != null)
            {
                GameObject player = GameObject.Instantiate<GameObject>(temPlayerChar,hit.point,Quaternion.identity);
                _player = player.AddComponent<PlayerController>();
            }
        }
    }
}
