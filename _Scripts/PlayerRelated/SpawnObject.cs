using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;

    public class SpawnObject : MonoBehaviour
    {
        public GameObject Cube;
        public Camera cam;

        private void Update() 
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mousePos = Input.mousePosition;
                mousePos.z = 2.0f;
                Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);
                Instantiate(Cube, worldPosition, Quaternion.identity);
            }
        }
    }
