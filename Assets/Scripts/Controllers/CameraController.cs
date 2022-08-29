using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject _player;
    Vector3 _oldPos;
    Vector3 _cameraPos;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 delta = _player.transform.position - _oldPos;
        transform.position = transform.position + delta;
        _oldPos = _player.transform.position;
    }
}
