using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NPCPatrol : MonoBehaviour
{
    public List<Transform> waypoints;
    public float speed = 2f;
    public float waitTime = 2f;
    private int idx = 0;

    private void Start()
    {
        StartCoroutine(Patrol());
    }

    private IEnumerator Patrol()
    {
        while (true)
        {
            Transform target = waypoints[idx];
            while (Vector3.Distance(transform.position, target.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(waitTime);
            idx = (idx + 1) % waypoints.Count;
        }
    }
}
