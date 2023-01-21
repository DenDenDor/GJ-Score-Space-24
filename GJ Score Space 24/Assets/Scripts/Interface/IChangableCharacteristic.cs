using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IChangableCharacteristic
{
    Changing—haracteristicStat Changing—haracteristicStat { get; set; }
    IRaiserStat RaiserStat { get; set; }
    public Stat StartStat { get; set; }
    public Stat GetCurrentStat();
    public void WorsenStat();
    public void ImproveStat();

}
