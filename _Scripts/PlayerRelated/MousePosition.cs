using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
   public Camera mainCamera;

   public void Update() 
   {
       Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
       if(Physics.Raycast(ray, out RaycastHit raycastHit))
       {
           transform.position = raycastHit.point;
       }
       //Debug.Log(Input.mousePosition);
       
   }
}
