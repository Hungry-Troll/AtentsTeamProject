using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Define
{
    public enum CreatureState
    {
        Idle,
        Moving,
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
}
