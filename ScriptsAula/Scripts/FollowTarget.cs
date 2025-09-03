using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Transform target;
    public Vector3 offset = new Vector3 (0, 0, -10);
    public float suave = 5;
    void Start()
    {
       if(target == null)
        {
            target = GameObject.FindWithTag("Player").transform;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {

        Vector3 novaPose = target.position + offset;
        transform.position = Vector3.Lerp( transform.position, novaPose, suave * Time.deltaTime) ;
    }
}
