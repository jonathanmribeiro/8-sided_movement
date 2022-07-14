using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    void Update()
    {
        if (Target == null)
        {
            return;
        }

        var newPosition = new Vector3(Target.transform.position.x, Target.transform.position.y, transform.position.z);
        transform.position = newPosition;
    }
}
