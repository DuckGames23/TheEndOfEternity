using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuList : MonoBehaviour
{
    [SerializeField] private List<MenuListPunct> menuListPuncts = new List<MenuListPunct>();
    private int currentPunct = 0;
    private bool _isActive = true;

    private void Update()
    {
        if (_isActive)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Back();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Next();
            }
        }
    }

    public void Next()
    {
        menuListPuncts[currentPunct].Unselect();
        if(currentPunct >= menuListPuncts.Count - 1)
        {
            currentPunct = 0;
        }
        else
        {
            currentPunct++;
        }
        menuListPuncts[currentPunct].Select();
    }

    public void Back()
    {
        menuListPuncts[currentPunct].Unselect();
        if (currentPunct <= 0)
        {
            currentPunct = menuListPuncts.Count - 1;
        }
        else
        {
            currentPunct--;
        }
        menuListPuncts[currentPunct].Select();
    }
}
