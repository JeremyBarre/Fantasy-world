using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{
    Animator playerAnimator;
    NavMeshAgent navmeshAgent;
    bool pRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        navmeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Input.GetButton("Fire1")||Input.GetButtonDown("Fire2"))
        {
            if (Physics.Raycast(ray, out hit, 1000f))
            {
                navmeshAgent.destination = hit.point;
                pRunning = false;
            }
        }
        else
        {
            pRunning = true;
        }
        playerAnimator.SetBool("Scene", pRunning);
    }
}
