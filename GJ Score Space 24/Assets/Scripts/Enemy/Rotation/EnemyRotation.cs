using UnityEngine;

class EnemyRotation : IRotation
{
    public IReturnerRotation ReturnerRotation { get; set; }

    private readonly Transform _self;

    public EnemyRotation(Transform self, IReturnerRotation returnerRotation)
    {
        _self = self;
        
        ReturnerRotation = returnerRotation;
    }

    public void Rotate()
    {
        _self.rotation = Quaternion.Euler(ReturnerRotation.ReturnRotation());
    }
}