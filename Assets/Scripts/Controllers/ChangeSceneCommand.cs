using System.Collections;
using System.Collections.Generic;
using strange.extensions.command.impl;
using UnityEngine;

public class ChangeSceneCommand : Command
{

  [Inject]
  public IGameManager manager{get; set;}

  [Inject]
  public int sceneId {get; set;}

  public override void Execute()
  {
    manager.OnSceneChange(sceneId);
  }
}
