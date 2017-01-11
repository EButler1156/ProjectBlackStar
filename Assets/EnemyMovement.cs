using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public float speed = 10f;

    private Transform target;
    private int wavepointIndex = 0;

    [SerializeField]
    Transform[] points;

    private int currPoint = 0;

    void Start()
    {
        target = points[currPoint];
    }

    void Update()
    {
//        Debug.Log(currPoint);

            Vector3 dir = target.position - transform.position;
            transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Mathf.Abs(target.position.x - transform.position.x) < 1f && Mathf.Abs(target.position.z - transform.position.z) < 1f)
        {

        
            if (currPoint != points.Length)
            {
                currPoint++;
                target = points[currPoint];

            }
            else
            {
                Destroy(gameObject);
                Debug.Log("Done");
            }
        }


    }

}
