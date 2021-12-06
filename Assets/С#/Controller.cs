
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour,IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private Image joystick; // Перемеая задника джостика
    private Image stick; // Переменая джостика
    private Vector2 intputVector2; // переменая велечены направления

    private void Start()
    {
        joystick = GetComponent<Image>();
        stick = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
       OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        // возврат джостика на середину задника джостика
        intputVector2 = Vector2.zero;
        stick.rectTransform.anchoredPosition = Vector2.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(joystick.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joystick.rectTransform.sizeDelta.x);
            pos.y = (pos.y / joystick.rectTransform.sizeDelta.y);
            
            intputVector2 = new Vector2(pos.x , pos.y ); // Нахождения координат касания на джостик
            intputVector2 = (intputVector2.magnitude > 1.0f) ? intputVector2.normalized : intputVector2;

            stick.rectTransform.anchoredPosition = new Vector2(intputVector2.x * (joystick.rectTransform.sizeDelta.x / 2), intputVector2.y * (joystick.rectTransform.sizeDelta.y / 2));


        }
    }
    public float Horizontal()
    {
        if (intputVector2.x != 0) return intputVector2.x;
            else return -Input.GetAxis("Horizontal");
    }
    public float Vertical()
    {
        if (intputVector2.y != 0) return intputVector2.y;
        else return -Input.GetAxis("Vertical");
    }
}
  
