using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHeal = 100;
    int currentHeal;
    

    void Start()
    {
        currentHeal = maxHeal;    
    }

    public void TakeDemage(int demage)
    {
        currentHeal -= demage;

        if(currentHeal <= 0)
        {
            The();
        }
    }
    void The()
    {
        Debug.Log("xana");
    }
}
