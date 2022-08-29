using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI : UI ��� ����� ���� ��
using UnityEngine.UI;
// SceneManagement : �� ��ȯ�� ���� ��
using UnityEngine.SceneManagement;

public class TurnOnTheStage : MonoBehaviour
{
    private List<Animator> _animatorList;
    public Animator _pet1Ani;
    public Animator _pet2Ani;
    public Animator _pet3Ani;
    private bool _bTurnLeft = false;
    private bool _bTurnRight = false;
    private Quaternion _turn = Quaternion.identity;
    
    // ����
    public static int charactorNum = 0;
    int value = 0;

    private void Awake()
    {
        _animatorList = new List<Animator>();

        // �ִϸ����� ����Ʈ�� �� �ִϸ����� ���� �߰�
        _animatorList.Add(_pet1Ani);
        _animatorList.Add(_pet2Ani);
        _animatorList.Add(_pet3Ani);
    }

    private void Start()
    {
        // ���� �ʱ�ȭ�մϴ�.
        _turn.eulerAngles = new Vector3(0, value, 0);
    }

    // Update is called once per frame
    private void Update()
    {
        if(_bTurnLeft)
        {
            Debug.Log("Left");
            charactorNum++;

            // ���� 4 -> 3
            if(charactorNum == 3)
            {
                charactorNum = 0;
            }

            // ������ �길 �����̵��� �������� �ִϸ��̼� off
            for(int i = 0; i < _animatorList.Count; i++)
            {
                if(i == charactorNum)
                {
                    continue;
                }
                // todo
            }

            // ���� -> 120
            // ������ 90�� ���ϴ�.
            value -= 120;

            // �ο� ������ ����մϴ�.
            _bTurnLeft = false;
        }

        if(_bTurnRight)
        {
            Debug.Log("Right");
            charactorNum--;

            if(charactorNum == -1)
            {
                // ���� 3 -> 2
                charactorNum = 2;
            }
            
            // ���� -> 120
            // ������ 90�� ���մϴ�.
            value += 120;

            // �ο� ������ ����մϴ�.
            _bTurnRight = false;
        }
        
        // ������ ��ϴ�.
        _turn.eulerAngles = new Vector3(0, value, 0);
        
        // �����ϴ�.
        transform.rotation = Quaternion.Slerp(transform.rotation, _turn, Time.deltaTime * 5.0f);
    }

    public void TurnLeft()
    {
        // �ٸ� ��ư�� �������� ��Ʈ��
        _bTurnLeft = true;
        _bTurnRight = false;
    }

    public void TurnRight()
    {
        // �ٸ� ��ư�� �������� ��Ʈ��
        _bTurnRight = true;
        _bTurnLeft = false;
    }

    public void TurnStage()
    {
        // �������� ��ȯ�� ���� �Լ�
        SceneManager.LoadScene("OnTheStage");
    }
}
