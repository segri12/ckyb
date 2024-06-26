using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ExplosiveCube : MonoBehaviour
{
    private int _minCreateValue = 2;
    private int _maxCreateValue = 6;
    private int _currentSplitChance = 1;
    private int _chanceReductionFactor = 2;

    private float _newScale = 0.5f;
    private float _explodeRadius = 10f;
    private float _explodeForce = 100;

    private void OnMouseDown()
    {
        if (Random.Range(0, _currentSplitChance) == 0)
        {
            BlowUp(GetExplodableObjects());
        }

        Destroy(gameObject);
    }

    private void BlowUp(List<Rigidbody> explodableObjects)
    {
        foreach (var explodableObject in explodableObjects)
        {
            explodableObject.AddExplosionForce(_explodeForce, transform.position, _explodeRadius);
        }
    }

    private List<Rigidbody> GetExplodableObjects()
    {
        List<Rigidbody> explodableObjects = new List<Rigidbody>();

        int count = Random.Range(_minCreateValue, _maxCreateValue);

        for (int i = 0; i < count; i++)
        {
            explodableObjects.Add(InitializeScaledObject().GetComponent<Rigidbody>());
        }

        return explodableObjects;
    }

    private ExplosiveCube InitializeScaledObject()
    {
        ExplosiveCube scaledObject = Instantiate(this);

        scaledObject.transform.localScale *= _newScale;
        scaledObject.DecreaseChance(_currentSplitChance);

        return scaledObject;
    }

    private void DecreaseChance(int chanceCount)
    {
        _currentSplitChance = chanceCount * _chanceReductionFactor;
    }
}