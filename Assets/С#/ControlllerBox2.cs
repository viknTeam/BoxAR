
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlllerBox2 : MonoBehaviour, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    private Image joysticktwo; //Переменая задника джостика
    private Image sticktwo; // Переменая джостика
    private Vector2 intputVector2; // Переменая Вектора направления

    private void Start()
    {
        joysticktwo = GetComponent<Image>();
        sticktwo = transform.GetChild(0).GetComponent<Image>();
    }
    public virtual void OnPointerDown(PointerEventData ped)
    {
        OnDrag(ped);
    }
    public virtual void OnPointerUp(PointerEventData ped)
    {
        // Возврат джостика на середину задника джостика
        intputVector2 = Vector2.zero;
        sticktwo.rectTransform.anchoredPosition = Vector2.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(joysticktwo.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = (pos.x / joysticktwo.rectTransform.sizeDelta.x);
            pos.y = (pos.y / joysticktwo.rectTransform.sizeDelta.y);

            // Нахождения координат касания на джостика
            intputVector2 = new Vector2(pos.x, pos.y);
            intputVector2 = (intputVector2.magnitude > 1.0f) ? intputVector2.normalized : intputVector2;

            sticktwo.rectTransform.anchoredPosition = new Vector2(intputVector2.x * (joysticktwo.rectTransform.sizeDelta.x / 2), intputVector2.y * (joysticktwo.rectTransform.sizeDelta.y / 2));


        }
    }
    public float Horizontal()
    {
        if (intputVector2.x != 0) return intputVector2.x;
        else return Input.GetAxis("Horizontal");
    }
    public float Vertical()
    {
        if (intputVector2.y != 0) return intputVector2.y;
        else return Input.GetAxis("Vertical");
    }
}
