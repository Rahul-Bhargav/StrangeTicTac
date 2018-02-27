using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.command.impl;

public class TicTacGameStartCommand : Command
{
  public override void Execute()
  {
    Debug.Log("Started");
  }
}
