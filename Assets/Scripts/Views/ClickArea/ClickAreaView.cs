using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using UnityEngine.UI;

public class ClickAreaView : View
{
  public string currentMark { get; set; }

  public string clickedIndex { get; set; }
  public Text xObj;

  public Text oObj;

  public Signal<string> areaClicked = new Signal<string>();

  private bool isClicked = false;

  private bool isGameOver = false;

  protected override void Start()
  {
    base.Start();
    currentMark = GameConstants.DEFAULT_MARK;
  }

  public void onClick(string clickedIndex)
  {
    if (isClicked || isGameOver)
      return;

    Text markObject = null;
    switch (currentMark)
    {
      case "x":
        markObject = GameObject.Instantiate(xObj, Vector3.zero, Quaternion.identity);
        break;
      case "o":
        markObject = GameObject.Instantiate(oObj, Vector3.zero, Quaternion.identity);
        break;
    }
    markObject.transform.parent = this.transform;
    markObject.rectTransform.localPosition = Vector3.zero;
    areaClicked.Dispatch(clickedIndex);
    isClicked = true;
  }

  public void SetGameOver(string gameStatus, bool isGameOverFlag) {
    isGameOver = isGameOverFlag;
  }
}
