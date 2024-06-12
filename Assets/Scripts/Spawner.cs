using UnityEngine;

[RequireComponent(typeof(Cube))]

class Spawner : MonoBehaviour
{
    [SerializeField] public int chanceToDivide = 100;
    [SerializeField] private int _minInstantiateNumber = 2;
    [SerializeField] private int _maxInstantiateNumber = 6;

    private Cube _cube;
    private int _randomInstantiateAmount;

    private void Awake()
    {
        _cube = GetComponent<Cube>();
    }

    public void SpawnObjects()
    {
        float scaleMultiplier = 0.5f;
        int divider = 2;

        _randomInstantiateAmount = Random.Range(_minInstantiateNumber, _maxInstantiateNumber + 1);
        transform.localScale *= scaleMultiplier;
        chanceToDivide /= divider;

        for (int i = 0; i < _randomInstantiateAmount; i++)
        {
            Instantiate(_cube.renderer, transform.position, Quaternion.identity);
        }
    }
}
