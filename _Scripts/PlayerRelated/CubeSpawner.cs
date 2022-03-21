using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    public Camera cam;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseScreenPosition = Input.mousePosition; //this is a vector with the mouse position ON SCREEN 
            Ray ray = cam.ScreenPointToRay(mouseScreenPosition);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                SpawnObjectAtPosition(hitInfo.point);
            }

        }
    }

    private void SpawnObjectAtPosition(Vector3 spawnPosition)
    {
        GameObject cube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
    }
}
