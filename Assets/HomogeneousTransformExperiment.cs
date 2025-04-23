using UnityEngine;

public class HomogeneousTransformExperiment : MonoBehaviour
{
    void Update()
    {
        // Move the parent GameObject upwards
        transform.Translate(Vector3.up * Time.deltaTime);
    }
}
