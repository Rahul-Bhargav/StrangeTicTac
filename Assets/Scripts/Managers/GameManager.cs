using System.Collections;
using System.Collections.Generic;
using strange.extensions.signal.impl;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour, IGameManager
{

  public string gameStatus { get; set; }

  public string currentMark = GameConstants.DEFAULT_MARK;

  public GameManager()
  {
    Debug.Log("Get new Game Manager");
  }

  /// <summary>
  /// Start is called on the frame when a script is enabled just before
  /// any of the Update methods is called the first time.
  /// </summary>
  void Start()
  {
    DontDestroyOnLoad(this.gameObject);
  }

  public string GetCurrentMark()
  {
    return currentMark;
  }

  public string GetGameStatus()
  {
    return gameStatus;
  }

  public void OnAreaClicked(string clickedIndex)
  {
    gameStatus = "Area clicked " + clickedIndex;
    currentMark = (currentMark == "x") ? "o" : "x";
  }

  public void OnSceneChange(int sceneId)
  {
    Debug.Log("Scene Change triggered");
    SceneManager.LoadScene(sceneId);
  }
}
