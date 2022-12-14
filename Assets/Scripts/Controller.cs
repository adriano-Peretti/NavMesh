using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public NavMeshSurface surface;


    void Start()
    {
        surface.BuildNavMesh();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
