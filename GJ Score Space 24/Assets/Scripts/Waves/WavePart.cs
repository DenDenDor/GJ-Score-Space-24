using UnityEngine;

public class WavePart
{
    public bool IsEmpty => Count == 0;
    public int Count { get; private set; }
    
    private readonly Enemy _prefab;

    public WavePart(Enemy prefab, int count)
    {
        _prefab = prefab;

        Count = count;
    }

    public Enemy SpawnAt(Vector3 position)
    {
        if (Count <= 0)
            throw new System.InvalidOperationException("Wave part is empty");

        Count--;

        return Object.Instantiate(_prefab, position, Quaternion.identity);
    }
}