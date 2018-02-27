using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;
using UnityEngine.UI;

public class GameStatusView : View
{

  public Text gameStatusText;

  public void UpdateScore(string status)
  {
    gameStatusText.text = status;
  }
}
