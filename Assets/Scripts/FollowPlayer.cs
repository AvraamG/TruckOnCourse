using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField]
    float distanceThreshold;

    [SerializeField]
    Transform playerTransform;

    Vector3 currentOffset = new Vector3(0, 5, -7);

    //TODO 

    // Update is called once per frame
    void LateUpdate()
    {
        Follow();
    }


    private void Follow()
    {
        float distance = Vector3.Distance(this.transform.position, playerTransform.position);
        if (distance > distanceThreshold)
        {
          transform.position = playerTransform.transform.position + currentOffset;
          transform.rotation = playerTransform.rotation;
        }
    }
}
