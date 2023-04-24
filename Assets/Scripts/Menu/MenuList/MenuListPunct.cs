using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuListPunct : MonoBehaviour
{
    [SerializeField] private Image background;
    [SerializeField] private Color unselectednColor = Color.white;
    [SerializeField] private Color selectedColor = Color.gray;
    public UnityEvent OnSelected;
    public UnityEvent OnUnselected;

    public void Select()
    {
        background.color = selectedColor;
        OnSelected?.Invoke();
    }

    public void Unselect()
    {
        background.color = unselectednColor;
        OnUnselected?.Invoke();
    }
}
