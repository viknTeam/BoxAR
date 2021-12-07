using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControllerTwo : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Image joystickTwo; // Перемеая задника джостика
    private Image stickTwo; // Переменая джостика
    private Vector2 intputVector2Two; // переменая велечены направления

    private void Start()
    {
        joystickTwo = GetComponent<Image>();
        stickTwo = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        // возврат джостика на середину задника джостика
        intputVector2Two = Vector2.zero;
        stickTwo.rectTransform.anchoredPosition = Vector2.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joystickTwo.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joystickTwo.rectTransform.sizeDelta.x);
            pos.y = (pos.y / joystickTwo.rectTransform.sizeDelta.y);

            intputVector2Two = new Vector2(pos.x, pos.y); // Нахождения координат касания на джостик
            intputVector2Two = (intputVector2Two.magnitude > 1.0f) ? intputVector2Two.normalized : intputVector2Two;

            stickTwo.rectTransform.anchoredPosition = new Vector2(intputVector2Two.x * (joystickTwo.rectTransform.sizeDelta.x / 2), intputVector2Two.y * (joystickTwo.rectTransform.sizeDelta.y / 2));


        }
    }
    public float Horizontal()
    {
        if (intputVector2Two.x != 0) return intputVector2Two.x;
        else return -Input.GetAxis("Horizontal");
    }
    public float Vertical()
    {
        if (intputVector2Two.y != 0) return intputVector2Two.y;
        else return -Input.GetAxis("Vertical");
    }
}
