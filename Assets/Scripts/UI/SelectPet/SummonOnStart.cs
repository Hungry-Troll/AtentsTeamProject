using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonOnStart : MonoBehaviour
{
    private int _charactors;
    public GameObject[] _sHero = new GameObject[3];
    private GameObject _respawn = null;

    void Start()
    {
        _charactors = TurnOnTheStage.charactorNum;
        _respawn = GameObject.FindGameObjectWithTag("Respawn");
        
        // 위치를 위한 오브젝트
        // 수정 4 -> 3
        for(int i = 0; i < 3; i++)
        {
            if(_charactors == i)
            {
                Instantiate(_sHero[i], _respawn.transform.position, Quaternion.identity);
            }
        }
    }

    void Update()
    {

    }
}
