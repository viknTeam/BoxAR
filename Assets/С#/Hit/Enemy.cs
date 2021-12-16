using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHeal = 100;
    int currentHeal;
    

    void Start()
    {
        currentHeal = maxHeal;    
    }

    public void TakeDemage(int demage)
    {
        currentHeal -= demage;

        animator.SetTrigger("Hurt");
        if(currentHeal <= 0)
        {
            The();
        }
    }
    void The()
    {
        
        
       
            animator.SetBool("Rest", true);
        
        GetComponent<Collider>().enabled = false;
        GetComponent<MovemenTwo>().enabled = false;
       
        this.enabled = false;
    }
}
