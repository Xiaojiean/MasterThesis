﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class RotateObject : MonoBehaviour, IInputClickHandler
{
    public GameObject elementsToRotate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void OnInputClicked(InputClickedEventData eventData)
    {
        elementsToRotate.transform.Rotate(90, 0, 0);
        this.transform.Rotate(90, 0, 0);
    }
}
