using UnityEngine;

[RequireComponent(typeof(Spawner), typeof(Exploder))]

public class Cube : MonoBehaviour
{
    [SerializeField] public MeshRenderer renderer;
    [SerializeField] private Color[] _colors;

    private Spawner _spawner;
    private Exploder _exploder;

    private void Awake()
    {
        _exploder = GetComponent<Exploder>();
        _spawner = GetComponent<Spawner>();
        SetRandomColor(renderer);
    }

    private void OnMouseDown()
    {
        SpawnDividedObjects();
    }

    private void SetRandomColor(MeshRenderer meshRenderer)
    {
        int minColorNumber = 0;
        int randomColor = Random.Range(minColorNumber, _colors.Length);
        meshRenderer.material.color = _colors[randomColor];
    }

    private void SpawnDividedObjects()
    {
        int minDivideChance = 0;
        int maxDivideChance = 100;

        int randomChanceToDivide = Random.Range(minDivideChance, maxDivideChance);

        if (randomChanceToDivide <= _spawner.chanceToDivide)
        {
            _spawner.SpawnObjects();
        }
        else
        {
            _exploder.Explode();
        }

        Destroy(gameObject);
    }
}
