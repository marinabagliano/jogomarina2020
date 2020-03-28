﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NavGame.Core
{
     [RequireComponent(typeof(DamageableGameObject))]
    public class HealthUIController : MonoBehaviour
    {
        public GameObject healthUIPrefab;
        public Transform healthPosition;
        GameObject healthUI;
        Transform cam;

        void Awake()
        {
            Canvas canvas = FindWordCanvas();
            if(canvas == null)
            {
                throw new Exception("A WordSpace canvas was needed");
            }
            cam = Camera.main.transform;
            healthUI = Instantiate(healthUIPrefab, canvas.transform);
        }

        void LateUpdate()
        {
            if(healthUI != null)
            {
                healthUI.transform.position = healthPosition.position;
                healthUI.transform.forward = -cam.forward;
            }

        }

        Canvas FindWordCanvas()
        {
            foreach (Canvas c in FindObjectsOfType<Canvas>())
            {
                if(c.renderMode == RenderMode.WorldSpace)
                {
                    return c;
                }
            }
            return null;
        }
    }
}