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
        // 게임매니저에서 Ui매니저 Init(Awake 함수 대체)
        // Ui 불러옴
        GameManager.Ui.Init();
        // 플레이어 캐릭터 생성
        // 추후 플레이어 선택창에서 string 으로 이름만 받아오면 됨
        // 시작위치는 맵마다 다르게 해야 됨
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
        // 위에서 레이를 쏴서 지형 높이에 따른 캐릭터 생성 코드
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
