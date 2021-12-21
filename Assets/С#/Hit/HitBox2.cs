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
        Collider[] HitEnemTwo = Physics.OverlapSphere(attacPoint_g.position, attacRange_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in HitEnemTwo)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<EnenmyTwo>().TackDemage(40); // Кол-во отнимаемых очков
        }
        
    }
    public void AttacTwoBc()
    {
        animTwo.SetTrigger("HitTwo2");// Включение второй анимации атаки
        Collider[] HitEnemTwo_g = Physics.OverlapSphere(attacPointTwo_g.position, attacRangeTwo_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in HitEnemTwo_g)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<EnenmyTwo>().TackDemage(60);// Кол-во отимаемых очков
        }
    }
    public void AttacTwoHc()
    {
        animTwo.SetTrigger("HitTwo3");// Включения третий анимации атаки
        Collider[] HitEnemTr_g = Physics.OverlapSphere(attacPointTr_g.position, attacRangeTr_g, layerMaskTwo);// Сравнения позиции точки и противника
        foreach (Collider enimTwo in HitEnemTr_g)// Если позиция точки и противника совпадают, отнимается здоровье противника
        {
            enimTwo.GetComponent<EnenmyTwo>().TackDemage(100);// Кол-во отнимаемых очков
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
