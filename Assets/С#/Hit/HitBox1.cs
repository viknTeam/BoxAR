using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox1 : MonoBehaviour
{
    public Animator anim;

    void Attac()
    {
        anim.SetBool("Hit", true);
    }
}
