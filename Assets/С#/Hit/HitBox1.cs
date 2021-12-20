using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox1 : MonoBehaviour
{
    public Animator anim;
    public Transform attacPoint,attacPointTwo, attacPointTr ;// Переменные точек атаки
    
    public float attacRange, attacRangeTwo, attacRangeTr = 0.5f;// Размер точки атаки
    public LayerMask enimeMask;
    

    public void Attac()
    {
        anim.SetTrigger("Hit");// Включение анимации атаки
        Collider[] hitEnim = Physics.OverlapSphere(attacPoint.position, attacRange, enimeMask);// Сравнеия позиции точки и противника
        foreach (Collider enemy in hitEnim)// Если позиция точки и противника совпадают, отнимаются очки здоровья
        {
            enemy.GetComponent<Enemy>().TakeDemage(40);// Кол-во отнимаемых очков
        }

    }
    public void AttacBk()
    {
        anim.SetTrigger("Hit2");// Включение анимации второй атаки 
        Collider[] hitEnimTwo = Physics.OverlapSphere(attacPointTwo.position, attacRangeTwo, enimeMask);// Сравнения позиции точки и противника
        foreach(Collider enemy in hitEnimTwo)// Если позиция точки и противника совпадают, отнимаются очки здоровья 
        {
            enemy.GetComponent<Enemy>().TakeDemage(60);// Кол-во отнимаемых очков
        }
    }
    public void AttacHk()
    {
        anim.SetTrigger("Hit3");// Включение анимации третий атаки
        Collider[] hitEnimTr = Physics.OverlapSphere(attacPointTr.position, attacRangeTr, enimeMask);// Сравнения позиции точки и противника 
        foreach(Collider enemy in hitEnimTr)// Если позиция точки и противника совпадают, отнимаются очки здоровья
        {
            enemy.GetComponent<Enemy>().TakeDemage(100);// Кол-во отнимаемых очков
        }
    }
    void OnDrawGizmosSelected()// Проектирование сферы, точки атаки
    {
        if (attacPoint == null)
            return;
        Gizmos.DrawWireSphere(attacPoint.position, attacRange);
        Gizmos.DrawWireSphere(attacPointTwo.position, attacRangeTwo);
        Gizmos.DrawWireSphere(attacPointTr.position, attacRangeTr);
    }
}
