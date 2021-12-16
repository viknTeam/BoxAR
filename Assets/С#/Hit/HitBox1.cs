using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox1 : MonoBehaviour
{
    public Animator anim;
    public Transform attacPoint,attacPointTwo, attacPointTr ;
    
    

    public float attacRange, attacRangeTwo, attacRangeTr = 0.5f;
    public LayerMask enimeMask;
    

    public void Attac()
    {
        anim.SetTrigger("Hit");
        Collider[] hitEnim = Physics.OverlapSphere(attacPoint.position, attacRange, enimeMask);
        foreach (Collider enemy in hitEnim)
        {
            enemy.GetComponent<Enemy>().TakeDemage(40);
        }

    }
    public void AttacBk()
    {
        anim.SetTrigger("Hit2");
        Collider[] hitEnimTwo = Physics.OverlapSphere(attacPointTwo.position, attacRangeTwo, enimeMask);
        foreach(Collider enemy in hitEnimTwo)
        {
            enemy.GetComponent<Enemy>().TakeDemage(60);
        }
    }
    public void AttacHk()
    {
        anim.SetTrigger("Hit3");
        Collider[] hitEnimTr = Physics.OverlapSphere(attacPointTr.position, attacRangeTr, enimeMask);
        foreach(Collider enemy in hitEnimTr)
        {
            enemy.GetComponent<Enemy>().TakeDemage(100);
        }
    }
    void OnDrawGizmosSelected()
    {
        if (attacPoint == null)
            return;
        Gizmos.DrawWireSphere(attacPoint.position, attacRange);
        Gizmos.DrawWireSphere(attacPointTwo.position, attacRangeTwo);
        Gizmos.DrawWireSphere(attacPointTr.position, attacRangeTr);
    }
}
