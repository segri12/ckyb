using UnityEngine;

[RequireComponent(typeof(Rigidbody))] // Û· 
public class ExplosiveCube : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public Rigidbody GetRigidbody()
    {
        return _rigidbody;
    }
}