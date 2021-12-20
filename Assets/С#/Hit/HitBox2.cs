using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox2 : MonoBehaviour
{
    public Animator animTwo;
    public Transform attacPoint_g, attacPointTwo_g, attacPointTr_g;// Переменные точек атаки

    public float attacRange_g, attacRangeTwo_g, attacRangeTr_g = 0.5f;// Размер точки атаки
    public LayerMask layerMaskTwo;

    public void AttacTwo()
    {
        animTwo.SetTrigger("HitTwo");// Включения анимации атаки
        Collider[] hitPoint_g = Physics.OverlapSphere(attacPoint_g.position, attacRange_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in hitPoint_g)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(20);// Кол-во отнимаемых очков
        }
    }
    public void AttacTwoBc()
    {
        animTwo.SetTrigger("HitTwo2");// Включение второй анимации атаки
        Collider[] hitPointTwo_g = Physics.OverlapSphere(attacPointTwo_g.position, attacRangeTwo_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in hitPointTwo_g)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(40);// Кол-во отимаемых очков
        }
    }
    public void AttacTwoHc()
    {
        animTwo.SetTrigger("HitTwo3");// Включения третий анимации атаки
        Collider[] hitPointTr_g = Physics.OverlapSphere(attacPointTr_g.position, attacRangeTr_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in hitPointTr_g)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<Enemy>().TakeDemage(100);// Кол-во отнимаемых очков
        }
    }
    void OnDrawGizmosSelected()// Проектирование свер точек атаки
    {
        if(attacPoint_g == null)
            return;
        Gizmos.DrawWireSphere(attacPoint_g.position, attacRange_g);
        Gizmos.DrawWireSphere(attacPointTwo_g.position, attacRangeTwo_g);
        Gizmos.DrawWireSphere(attacPointTr_g.position, attacRangeTr_g);
    }
    
        


    
}
