using UnityEngine;

public class GlobalTransformExperiment : MonoBehaviour
{
    void Update()
    {
        // Move the cube globally (ignores parent-child relationships)
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
    }
}
