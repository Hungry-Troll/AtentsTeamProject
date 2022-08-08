using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class NpcController : MonoBehaviour, ICreature
{
    CreatureState _creatureState;
    // Start is called before the first frame update
    void Start()
    {
        _creatureState = CreatureState.Idle;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateController();
    }

    public void UpdateController()
    {
        switch(_creatureState)
        {
            case CreatureState.Idle:
                UpdateIdle();
                break;
            case CreatureState.Moving:
                UpdateMove();
                break;
            case CreatureState.Attack:
                UpdateAttack();
                break;
            case CreatureState.Skill:
                UpdateSkill();
                break;
            case CreatureState.Dead:
                UpdateDead();
                break;
        }
    }

    public void UpdateIdle()
    {
        
    }

    public void UpdateMove()
    {
        
    }

    public void UpdateAttack()
    {

    }

    public void UpdateSkill()
    {
        
    }

    public void UpdateDead()
    {

    }
}
