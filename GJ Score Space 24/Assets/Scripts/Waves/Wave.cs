using UnityEngine;

public class Wave
{
    private readonly WavePart[] _parts;

    public Wave(WavePart[] parts)
    {
        _parts = parts;
    }
    
    public Enemy SpawnAt(Vector3 position)
    {
        var index = Random.Range(0, _parts.Length);
        var part = _parts[index];

        return part.SpawnAt(position);
    }
}