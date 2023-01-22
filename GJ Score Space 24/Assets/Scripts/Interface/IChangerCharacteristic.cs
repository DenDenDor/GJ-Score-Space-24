using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChangerCharacteristic
{
    Changing—haracteristicStat Changing—haracteristicStat { get; set; }
    CharacteristicChangeLimitsStat CharacteristicChangeLimitsStat { get; set; }
    IRaiserStat RaiserStat { get; set; }
    IDegraderStat DegraderStat { get; set; }
    public Stat StartStat { get; set; }
    public Stat GetCurrentStat();
    public void WorsenStat();
    public void ImproveStat();
    public float GetValueOfStat();
}
