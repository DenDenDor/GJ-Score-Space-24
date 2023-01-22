using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatorDisplayerStat : MonoBehaviour
{
    [SerializeField] private DisplayerStat _displayerStat;
    [SerializeField] private Mutation _mutation;
    [SerializeField] private Transform _point;
   [SerializeField] private List<DisplayerStat> _currentDisplayerStats = new List<DisplayerStat>();
    private void Start()
    {
        _mutation.ChangableCharacteristics.ForEach(e => Create(e));
        _mutation.OnInitialize += UpdateSlots;
    }
    private void UpdateSlots()
    {
        Debug.Log("UPDATE!");
        _currentDisplayerStats.ForEach(e => e.DisplayStat());
    }
      private void Create(IChangerCharacteristic changerCharacteristic)
    {
      DisplayerStat displayerStat =  Instantiate(_displayerStat, _point.position, Quaternion.identity);
      displayerStat.transform.SetParent(_point);
      displayerStat.Initialize(changerCharacteristic);
     _currentDisplayerStats.Add(displayerStat);
    }
}
