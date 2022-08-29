using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Define;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// ���ӸŴ��� ��� �ڵ� ���� :
    /// Resource �Ŵ��� ���
    /// GameManager.Resource.(  )   ( )�� public ���� �Լ� ��� �ڵ� ���ٰ���
    /// UI �Ŵ��� ���
    /// GameManager.Ui.(  )   ( )�� public ���� �Լ� ��� �ڵ� ���ٰ���
    /// </summary>
    // ���� �Ŵ��� �̱��� ����
    static GameManager _instance;
    public static GameManager Instance 
    { 
        get{ return _instance; } 
    }
    /// �Ŵ��� ����
    ResourceManager _resource = new ResourceManager();
    SceneManagerEX _scene = new SceneManagerEX();
    UiManager _ui = new UiManager();
    // 
    List<MonsterController> mobList;
    public Transform mobParent;
    public static ResourceManager Resource 
    { 
        get{ return _instance._resource; } 
    }
    public static SceneManagerEX Scene 
    { 
        get { return _instance._scene; } 
    }
    public static UiManager Ui 
    { 
        get { return _instance._ui; } 
    }

    float currTime;
    // Start is called before the first frame update
    private void Awake()
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
<<<<<<< HEAD
        // ���ӸŴ������� Resource�Ŵ���/Ui�Ŵ��� Init(Awake �Լ� ��ü)
        GameManager.Resource.Init();
        GameManager.Ui.Init();
        mobList = new List<MonsterController>();
    }
    void Start()
    {
        Mobspwan();
    }

    void Update()
    {
    }
    public void Mobspwan()
    {
        for (int i = 0; i < 4; i++)
        {
            Vector3 rayPos = Vector3.zero;
            float x = Random.Range(-15, 15);
            float z = Random.Range(-20, 0);
            rayPos.Set(x, 0, z);
            CreateMonster(rayPos, "Velociraptor");
        }
    }
    public MonsterController CreateMonster(Vector3 _origin, string _name) 
    {
        Vector3? terrainPos = GetTerrainPosition(_origin);
        if(terrainPos.HasValue)
        {
            GameObject rcCha = _instance._resource.GetMonster(_name);
            GameObject obj = GameObject.Instantiate<GameObject>(rcCha, terrainPos.Value, Quaternion.identity);
            obj.transform.SetParent(mobParent); 
            MonsterController script = obj.AddComponent <MonsterController> ();
            mobList.Add(script);
            return script;
        }
        return null;
    }
    public Vector3? GetTerrainPosition(Vector3 _origin) //������ ���� ��ġ�� ��ȯ
    {
        _origin.y += 100f;
        RaycastHit hit;
        if(Physics.Raycast(_origin, -Vector3.up, out hit, Mathf.Infinity))
        {
            return hit.point;
        }
        return null;
=======
>>>>>>> origin/master
    }
}

