using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class AreaClickedCommand : Command
{

  [Inject]
  public IGameManager manager { get; set; }

  [Inject]
  public string clickedIndex { get; set; }

  [Inject]
  public GameStatusChangedSignal gameStatusChangedSignal { get; set; }

  [Inject]
  public CurrentMarkChangedSignal currentMarkChangedSignal { get; set; }

  public override void Execute()
  {
    manager.OnAreaClicked(clickedIndex);
    gameStatusChangedSignal.Dispatch(manager.GetGameStatus());
    currentMarkChangedSignal.Dispatch(manager.GetCurrentMark());
  }
}
