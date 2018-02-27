using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class StartButtonMediator : Mediator {

  [Inject]
  public StartButtonView view  {get; set; }

  [Inject]
  public ChangeSceneSignal changeSceneSignal {get; set; }

  public override void OnRegister() {
    view.buttonClicked.AddListener((sceneId) => changeSceneSignal.Dispatch(sceneId));
  }
}
