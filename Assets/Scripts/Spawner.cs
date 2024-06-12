using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

class Spawner : MonoBehaviour
{
    [SerializeField] public int _chanceToDivide = 100;
    [SerializeField] private int _minInstantiateNumber = 2;
    [SerializeField] private int _maxInstantiateNumber = 6;

    public MeshRenderer _meshRenderer;
    private Cube _cube;
    private int _randomInstantiateAmount;

    private void Awake()
    {
        _cube = GetComponent<Cube>();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SpawnObjects()
    {
        float scaleMultiplier = 0.5f;
        int divider = 2;

        _randomInstantiateAmount = Random.Range(_minInstantiateNumber, _maxInstantiateNumber + 1);
        transform.localScale *= scaleMultiplier;
        _chanceToDivide /= divider;

        for (int i = 0; i < _randomInstantiateAmount; i++)
        {
            Instantiate(_meshRenderer, transform.position, Quaternion.identity);
        }
    }
}
