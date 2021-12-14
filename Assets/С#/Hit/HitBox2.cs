using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox2 : MonoBehaviour
{
    public Animator animTwo;

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
