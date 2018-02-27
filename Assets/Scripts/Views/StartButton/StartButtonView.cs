using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButtonView : View
{

  public Signal<int> buttonClicked = new Signal<int>();

  public void OnClick(int sceneId) {
    buttonClicked.Dispatch(sceneId);
  }
}
