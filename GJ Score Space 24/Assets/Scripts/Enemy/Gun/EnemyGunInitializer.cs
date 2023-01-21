using UnityEngine;

public class EnemyGunInitializer : MonoBehaviour
{
    [SerializeField] private Gun _gun;
    [SerializeField] private GetterEnemyRotation _getterRotation;

    private void Awake()
    {
        _gun.Initialize(_getterRotation.GetRotation());
    }
}
