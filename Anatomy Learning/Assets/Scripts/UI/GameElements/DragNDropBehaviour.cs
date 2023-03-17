using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragNDropBehaviour : MonoBehaviour, IDragHandler
{
    [SerializeField]
    private RectTransform rectTransform;
    [SerializeField]
    private Canvas canvas;

    public void OnDrag(PointerEventData eventData)
    {
        /*
         * faz com que o transform do objeto siga o transform do mouse
         * divisão pelo canvas.scaleFacter previne que drag seja impreciso, dependendo da resolução da tela
         */
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
        //throw new System.NotImplementedException();
    }
}
