using UnityEngine;

public class UiDesign3 : MonoBehaviour
{
    public GameObject warriorB;
    public GameObject ArcherB;
    public GameObject ScientistB;

    SpriteRenderer sr;

    bool WButtom = false;
    bool AButtom = false;
    bool SButtom = false;

    GameObject job;
    GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        sr = warriorB.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(WButtom)
        {
            Debug.Log("Warrior");
            job = Resources.Load<GameObject>("PeoplePrefabs/man-viking");
            playerObject = GameObject.Instantiate<GameObject>(job);
            playerObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            WButtom = false;
        }

        if(AButtom)
        {
            Debug.Log("Archer");
            job = Resources.Load<GameObject>("PeoplePrefabs/man-soldier");
            playerObject = GameObject.Instantiate<GameObject>(job);
            playerObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            AButtom = false;
        }

        if(SButtom)
        {
            Debug.Log("Scientist");
            job = Resources.Load<GameObject>("PeoplePrefabs/man-doctor");
            playerObject = GameObject.Instantiate<GameObject>(job);
            playerObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
            SButtom = false;
        }


    }

    public void WarriorButtom()
    {
        WButtom = true;
        AButtom = false;
        SButtom = false;
    }

    public void ArcherButtom()
    {
        WButtom = false;
        AButtom = true;
        SButtom = false;
    }

    public void ScientistButtom()
    {
        WButtom = false;
        AButtom = false;
        SButtom = true;
    }


}
