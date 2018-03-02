using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.impl;
public class TicTacBootstrap : ContextView
{
  /// <summary>
  /// Awake is called when the script instance is being loaded.
  /// </summary>
  void Awake()
  {
    this.context = TicTacContext.GetTicTacContext(this);
    // DontDestroyOnLoad(this.transform);
  }
}
