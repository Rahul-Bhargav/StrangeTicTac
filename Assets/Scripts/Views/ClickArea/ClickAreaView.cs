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
  void Start()
  {
    currentMark = GameConstants.DEFAULT_MARK;
  }

  public void onClick(string clickedIndex)
  {
    if (isClicked)
      return;

    Text markObject = null;
    switch (currentMark)
    {
      case "x":
        markObject = GameObject.Instantiate(xObj, this.gameObject.transform.position, Quaternion.identity);
        break;
      case "o":
        markObject = GameObject.Instantiate(oObj, this.gameObject.transform.position, Quaternion.identity);
        break;
    }
    markObject.transform.parent = this.transform;
    areaClicked.Dispatch(clickedIndex);
    isClicked = true;
  }
}
