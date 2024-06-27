using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour //взрыв
{
    [SerializeField] private float _explodeRadius = 10f;
    [SerializeField] private float _explodeForce = 100;

    public void BlowUp(List<Rigidbody> explodableObjects)
    {
        foreach (var explodableObject in explodableObjects)
        {
            explodableObject.AddExplosionForce(_explodeForce, transform.position, _explodeRadius);
        }
    }
}