using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Pet_01 : MonoBehaviour
{

    Animator animator;                                          
    Vector3 targetPos;                                          
    public float moveSpeed;                                      
    public float rotSpeed;
    Transform target;
    float distance;

    public GameObject player; 



    void Start()
    {
        animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Monster").transform;
        
    }


    void Update()
    {
       

        if (Input.GetMouseButtonDown(0))                            
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                if (hitInfo.collider.CompareTag("Terrain"))
                {
                    targetPos = hitInfo.point;
                }
            }
        }

        Debug.Log($"{targetPos} // {transform.position}");

        distance = Vector3.Distance(target.transform.position, targetPos);
        Debug.Log(distance);

        Vector3 dis = target.transform.position - targetPos;
        Debug.Log(dis);

        //애니메이션 코드
        if (distance <= 3f)
        {
            Debug.Log("공격");
            transform.LookAt(target.transform);
            animator.SetInteger("aniIndex", 2);
        }
        else if (targetPos == transform.position)
        {
            animator.SetInteger("aniIndex", 0);
        }
        else if (targetPos != transform.position)
        {
            animator.SetInteger("aniIndex", 1);
            
        }

        //이동코드 
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * moveSpeed);          

        // 회전코드 
        Vector3 dir = targetPos - transform.position;                                       
        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir.normalized, Time.deltaTime * rotSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);                   

    }

    void FollowPlayer()
    {

    }
}
