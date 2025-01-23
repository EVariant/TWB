using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoveringEffects : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject obj_HoveringImg;

    public void OnPointerEnter(PointerEventData eventData)
    {
        obj_HoveringImg.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        obj_HoveringImg.gameObject.SetActive(false);
    }
}
