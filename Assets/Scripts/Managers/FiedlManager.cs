using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiedlManager : MonoBehaviour
{
    private void Awake()
    {
        // ���ӸŴ������� Resource�Ŵ���/Ui�Ŵ��� Init(Awake �Լ� ��ü)
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
