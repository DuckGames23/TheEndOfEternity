using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryInputManager : MonoBehaviour
{
    private string _numbers = "123456";
    public void Update()
    {
        if (Input.anyKeyDown && _numbers.Contains(Input.inputString) && !Input.GetMouseButton(0) && !Input.GetMouseButton(1))
        {
            GetComponent<InventoryController>().CurrentItemNumber = Convert.ToInt32(Input.inputString);
        }
    }
}
