using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
    public void StartBtn()
    {
        //SceneManager.LoadScene("LoadingScene");
        GameManager.Scene.LoadScene("CharacterSelectScene");
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
