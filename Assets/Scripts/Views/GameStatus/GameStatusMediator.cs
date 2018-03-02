using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class GameStatusMediator : Mediator
{
  [Inject]
  public GameStatusView gameStatusView { get; set; }

  [Inject]
  public GameStatusChangedSignal gameStatusChangedSignal { get; set; }

  public override void OnRegister()
  {
    gameStatusChangedSignal.AddListener(gameStatusView.UpdateScore);
  }
}
