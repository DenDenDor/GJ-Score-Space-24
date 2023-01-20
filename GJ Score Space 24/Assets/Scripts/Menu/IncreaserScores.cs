using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreaserScores : MonoBehaviour
{
    private int _countOfScores; 
    [SerializeField] private MusicVolume _musicVolume;
    [SerializeField] private SaverLootLooker _saverLootLooker;
    private void OnEnable() 
    {
        _musicVolume.AudioSource.Pause();
    }
    private void IncreaseScore()
    {
        _countOfScores++;
        _musicVolume.AudioSource.Play();
        _saverLootLooker.Save(_countOfScores);
        _saverLootLooker.UpdloadScores();
    }
    private void OnDisable() 
    {
    }
}
