using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Pet_01 : MonoBehaviour
{

    Animator animator;                                          
    Vector3 targetPos;                                          
    public float moveSpeed;                                      
    public float rotSpeed;           
    
    void Start()
    {
        animator = GetComponent<Animator>();                   
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
        
        if (targetPos != transform.position)     
        {
            animator.SetInteger("aniIndex", 1);
        }
        else if (targetPos == transform.position)
        {
            animator.SetInteger("aniIndex", 0);
        }




        //이동코드 
        transform.position = Vector3.MoveTowards(transform.position, targetPos, Time.deltaTime * moveSpeed);          

        // 회전코드 
        Vector3 dir = targetPos - transform.position;                                       
        Vector3 newDir = Vector3.RotateTowards(transform.forward, dir.normalized, Time.deltaTime * rotSpeed, 0);
        transform.rotation = Quaternion.LookRotation(newDir.normalized);                   


    }
}
