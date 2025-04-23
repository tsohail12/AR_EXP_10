using UnityEngine;

public class LocalTransformExperiment : MonoBehaviour
{
    void Update()
    {
        // Move the cube locally (relative to its parent, if any)
        transform.Translate(Vector3.right * Time.deltaTime, Space.Self);
    }
}
