using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum CreatureState
    {
        Idle,
        Move,
        AutoMove,
        Skill,
        Attack,
        Dead,
        None,
    }
    public enum JoystickState
    {
        InputFalse,
        InputTrue,
    }

    public enum SceneAttackButton
    {
        Attack,
        Skill1,
        Skill2,
        Skill3,
        Rolling,
    }

    public enum Info
    {
        Hp,
        Mp,
    }
}
