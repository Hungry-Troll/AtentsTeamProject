using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 게임 매니저 싱글톤 생성
    static GameManager _instance;
    public static GameManager Instance { get{ return _instance; } }
    /// 매니저 생성
    ResourceManager _resource = new ResourceManager();
    SceneManagerEX _scene = new SceneManagerEX();
    UiManager _ui = new UiManager();

    public static ResourceManager Resource { get { return _instance._resource; } }
    public static SceneManagerEX Scene { get { return _instance._scene; } }
    public static UiManager Ui { get { return _instance._ui; } }

    // Start is called before the first frame update
    void Awake()
    {
        if(_instance == null)
        {
           _instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

}

