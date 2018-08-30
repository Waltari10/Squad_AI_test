
// MoveTo.cs
using UnityEngine;
using System.Collections;

public class MoveTo : MonoBehaviour {

   private UnityEngine.AI.NavMeshAgent agent;
   
   void Start () {
      agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
   }

    private void Update() {
        if (Input.GetMouseButtonDown(0))
        {
             Clicked();
        }
   }

   void Clicked()
     {
         Debug.Log(Camera.main);
         var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
 
         RaycastHit hit = new RaycastHit();
 
         if (Physics.Raycast (ray, out hit))
         {   
            agent.destination = hit.point;
         }
     }
}