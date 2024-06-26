using UnityEngine;

public class InputHandler : MonoBehaviour//Чтение  мышки или вода  
{
    [SerializeField] private ExplosiveCube _explosiveCube;
    [SerializeField] private Explosion _explosion;
    [SerializeField] private CubeSpawner _cubeSpawner;
    [SerializeField] private int _currentSplitChance = 1;
    [SerializeField] private int _chanceReductionFactor = 2;

    private void OnMouseDown()
    {
        if (Random.Range(0, _currentSplitChance) == 0)
        {
            _explosion.BlowUp(_cubeSpawner.GetExplodableObjects());
            _currentSplitChance *= _chanceReductionFactor;
        }

        Destroy(_explosiveCube.gameObject);
    }
}