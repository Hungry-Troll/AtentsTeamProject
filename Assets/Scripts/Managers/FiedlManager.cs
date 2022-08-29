using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiedlManager : MonoBehaviour
{
    private void Awake()
    {
        // 게임매니저에서 Resource매니저/Ui매니저 Init(Awake 함수 대체)
        GameManager.Resource.Init();
        GameManager.Ui.Init();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
