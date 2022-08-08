using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager 
{
    public T Load<T>(string path) where T : Object
    {
        return Resources.Load<T>(path);
    }

    public GameObject Instantiate(string path, Transform parent = null)
    {
        // 메모리상 로드
        GameObject prefab = Load<GameObject>($"Prefabs/{path}");
        if(prefab == null)
        {
            Debug.Log($"Failed to load prefab : {path}");
            return null;
        }
        // 메모리에 로드된 프리팹을 씬에 불러옴
        GameObject go = Object.Instantiate(prefab, parent);
        int index = go.name.IndexOf("(Clone)");
        if(index > 0)
            go.name = go.name.Substring(0, index);
        return go;
    }

    public void Destroy(GameObject go)
    {
        if(go == null)
            return;
        Object.Destroy(go);
    }

    //몇초후 파괴
    public void Destroy(GameObject go, float time)
    {
        if(go == null)
            return;
        Object.Destroy(go, time);
    }
}
