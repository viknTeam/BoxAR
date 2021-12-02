
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Controller : MonoBehaviour,IDragHandler, IPointerDownHandler, IPointerUpHandler
{

    private Image joystick;
    private Image stick;
    private Vector2 intputVector2;

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
        intputVector2 = Vector2.zero;
        stick.rectTransform.anchoredPosition = Vector2.zero;
    }
    public virtual void OnDrag(PointerEventData ped)
    {
        Vector2 pos;
        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(joystick.rectTransform, ped.position, ped.pressEventCamera, out pos))
        {
            pos.x = pos.x / joystick.rectTransform.sizeDelta.x;
            pos.y = pos.y / joystick.rectTransform.sizeDelta.x;
            
            intputVector2 = new Vector2(pos.x * 2 - 1, pos.y * 2 - 1);

        }
    }
}
  
