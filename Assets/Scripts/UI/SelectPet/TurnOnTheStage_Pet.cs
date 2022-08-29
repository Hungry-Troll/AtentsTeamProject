using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI : UI 기능 사용을 위한 것
using UnityEngine.UI;
// SceneManagement : 씬 전환을 위한 것
using UnityEngine.SceneManagement;

public class TurnOnTheStage_Pet : MonoBehaviour
{
    private List<Animator> _animatorList;
    public Animator _pet1Ani;
    public Animator _pet2Ani;
    public Animator _pet3Ani;
    private bool _bTurnLeft = false;
    private bool _bTurnRight = false;
    private Quaternion _turn = Quaternion.identity;
    
    // 정의
    public static int _characterNum = 0;
    int _value = 0;

    private void Awake()
    {
        _animatorList = new List<Animator>();

        // 애니메이터 리스트에 펫 애니메이터 각각 추가
        _animatorList.Add(_pet1Ani);
        _animatorList.Add(_pet2Ani);
        _animatorList.Add(_pet3Ani);
    }

    private void Start()
    {
        // 각을 초기화합니다.
        _turn.eulerAngles = new Vector3(0, _value, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if(_bTurnLeft)
        {
            Debug.Log("Left");
            _characterNum++;

            // 수정 4 -> 3
            if(_characterNum == 3)
            {
                _characterNum = 0;
            }

            // 선택한 펫만 움직이도록 나머지는 애니메이션 off
            for(int i = 0; i < _animatorList.Count; i++)
            {
                if(i == _characterNum)
                {
                    continue;
                }
                // todo
            }

            // 수정 -> 120
            // 각도를 90도 뺍니다.
            _value -= 120;

            // 부울 변수를 취소합니다.
            _bTurnLeft = false;
        }

        if(_bTurnRight)
        {
            Debug.Log("Right");
            _characterNum--;

            if(_characterNum == -1)
            {
                // 수정 3 -> 2
                _characterNum = 2;
            }
            
            // 수정 -> 120
            // 각도를 90도 더합니다.
            _value += 120;

            // 부울 변수를 취소합니다.
            _bTurnRight = false;
        }
        
        // 각도를 잽니다.
        _turn.eulerAngles = new Vector3(0, _value, 0);
        
        // 돌립니다.
        transform.rotation = Quaternion.Slerp(transform.rotation, _turn, Time.deltaTime * 5.0f);
    }

    public void TurnLeft()
    {
        // 다른 버튼을 누를때의 컨트롤
        _bTurnLeft = true;
        _bTurnRight = false;
    }

    public void TurnRight()
    {
        // 다른 버튼을 누를때의 컨트롤
        _bTurnRight = true;
        _bTurnLeft = false;
    }

    public void TurnStage()
    {
        // 스테이지 전환을 위한 함수
        SceneManager.LoadScene("OnTheStage");
    }
}
