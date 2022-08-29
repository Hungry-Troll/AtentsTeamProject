using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager 
{
    public List<GameObject> _player;
    public List<GameObject> _monster;
    public List<GameObject> _npc;
    public List<GameObject> _ui;

    // Start is called before the first frame update
    public void Init()
    {
        _player = new List<GameObject>();
        _monster = new List<GameObject>();
        _npc = new List<GameObject>();
        _ui = new List<GameObject>();

        GameObject[] player = Resources.LoadAll<GameObject>("Prefabs/Character_Prefab/");
        GameObject[] monster = Resources.LoadAll<GameObject>("Prefabs/Monster_Prefab/");
        GameObject[] npc = Resources.LoadAll<GameObject>("Prefabs/Npc_Prefab/");
        GameObject[] ui = Resources.LoadAll<GameObject>("Prefabs/Ui_Prefab/");

        ListAdd(_player, player);
        ListAdd(_monster, monster);
        ListAdd(_npc, npc);
        ListAdd(_ui, ui);
    }

    public void ListAdd(List<GameObject> go, GameObject[] loadList)
    {
        foreach (GameObject one in loadList)
        {
            go.Add(one);
        }
    }

    public GameObject GetCharacter(string playerName)
    {
        foreach (GameObject one in _player)
        {
            if (one.name.Equals(playerName))
            {
                return one;
            }
        }
        return null;
    }

    public GameObject GetNpc(string monsterName)
    {
        foreach (GameObject one in _monster)
        {
            if (one.name.Equals(monsterName))
            {
                return one;
            }
        }
        return null;
    }
    public GameObject GetMonster(string npcName)
    {
        foreach (GameObject one in _monster)
        {
            if (one.name.Equals(npcName))
            {
                return one;
            }
        }
        return null;
    }

    public GameObject GetUi(string uiName)
    {
        foreach (GameObject one in _ui)
        {
            if (one.name.Equals(uiName))
            {
                return one;
            }
        }
        return null;
    }
}
