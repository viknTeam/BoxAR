using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox1 : MonoBehaviour
{
    public Animator anim;
    public Transform attacPoint;

    public float attacRange = 0.5f;
    public LayerMask enimeMask;
    public int attacDemage = 40;

    public void Attac()
    {
        anim.SetTrigger("Hit");
        Collider[] hitEnim = Physics.OverlapSphere(attacPoint.position, attacRange, enimeMask);
        foreach (Collider enemy in hitEnim)
        {
            enemy.GetComponent<Enemy>().TakeDemage(attacDemage);
        }

    }
    void OnDrawGizmosSelected()
    {
        if (attacPoint == null)
            return;
        Gizmos.DrawWireSphere(attacPoint.position, attacRange);
    }
    public void AttacBk()
    {
        anim.SetTrigger("Hit2");
    }
    public void AttacHk()
    {
        anim.SetTrigger("Hit3");
    }
}
