using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRotation
{
    public IReturnerRotation ReturnerRotation { get; set; }
    public void Rotate(); 
}
