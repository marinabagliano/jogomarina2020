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

        void Awake()
        {
            Canvas canvas = FindWordCanvas();
        }
        
        Canvas FindWordCanvas()
        {
            foreach (Canvas c in FindObjectOfType<Canvas>())
            {
                
            }
        }
    }
}