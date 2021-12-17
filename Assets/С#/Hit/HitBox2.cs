using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox2 : MonoBehaviour
{
    public Animator animTwo;
    public Transform attacPoint_g, attacPointTwo_g, attacPointTr_g;

    public float attacRange_g, attacRangeTwo_g, attacRangeTr_g;


    public void AttacTwo()
    {
        animTwo.SetTrigger("HitTwo");
    }
    public void AttacTwoBc()
    {
        animTwo.SetTrigger("HitTwo2");
    }
    public void AttacTwoHc()
    {
        animTwo.SetTrigger("HitTwo3");
    }

    
}
