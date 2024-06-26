using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorRandomer : MonoBehaviour  //цвет сука
{
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        Change();
    }

    private void Change()
    {
        _renderer.material.color = Random.ColorHSV();
    }
}
