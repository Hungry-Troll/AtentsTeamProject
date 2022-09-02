using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Define;

public class PlayerController : MonoBehaviour
{
    Vector2 _inputDir;
    public float _moveSpeed;
    // Start is called before the first frame update
    private void Start()
    {
        _moveSpeed = 2.5f;
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _inputDir = GameManager.Ui._joyStickController.inputDirection;
        //Debug.Log("플레이어 : " + _inputDir);
        bool isMove = _inputDir.magnitude != 0;
        //if (GameManager.Ui._joyStickController._joystickState == JoystickState.InputTrue)
        if(isMove)
        {
            //이동
            float x = _inputDir.x;
            float y =_inputDir.y;
            Vector3 tempVector = new Vector3(x, 0, y);
            tempVector = tempVector * Time.deltaTime * _moveSpeed;
            transform.position += tempVector;
            //회전
            Vector3 tempDir = new Vector3(x, 0, y);
            tempDir = Vector3.RotateTowards(transform.forward, tempDir, Time.deltaTime * _moveSpeed,0);
            transform.rotation = Quaternion.LookRotation(tempDir.normalized);
        }
    }

    private float PlayerYposCheck()
    {
        float temp = 0.0f;
        Vector3 origin = transform.position;
        origin.y += 100f;
        RaycastHit hit;
        if (Physics.Raycast(origin, -Vector3.up, out hit, Mathf.Infinity))
        {
            temp = hit.point.y;
            return temp;
        }
        return temp;
    }
}
