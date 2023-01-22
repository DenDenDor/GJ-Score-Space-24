using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayerStat : MonoBehaviour
{
   [SerializeField] private Image _bar;
    [SerializeField] private GetterMove getterMove;
   private IChangerCharacteristic _changerCharacteristic;
    public void DisplayStat()
    {
         _bar.DivideImageBar(_changerCharacteristic.CharacteristicChangeLimitsStat.MaximumValueOfStat, _changerCharacteristic.GetValueOfStat());
    }
     public void Initialize(IChangerCharacteristic changerCharacteristic)
    {
        _changerCharacteristic = changerCharacteristic;
    }
}
