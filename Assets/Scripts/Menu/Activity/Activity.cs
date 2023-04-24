using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activity : MonoBehaviour
{
    public UnityEvent OnActivate;
    public UnityEvent OnDeactivate;

    public void Activate()
    {
        ActivitiesController.CurrentActivity?.Deactivate();
        OnActivate?.Invoke();
        gameObject.SetActive(true);
        ActivitiesController.CurrentActivity = this;
    }

    public void Deactivate() 
    {
        OnDeactivate?.Invoke();
        gameObject.SetActive(false);
    }
}  
