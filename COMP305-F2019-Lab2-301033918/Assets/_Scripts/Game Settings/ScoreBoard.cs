using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Name: Geerthan K.
/// Student ID: 301033918
/// </summary>
[CreateAssetMenu(fileName = "ScoreBoard", menuName = "Game/ScoreBoard")]
[System.Serializable]
public class ScoreBoard : ScriptableObject
{
    public int highScore;
    public int lives;
    public int score;
}