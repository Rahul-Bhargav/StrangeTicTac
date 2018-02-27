using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine;

public class ClickAreaMediator : Mediator
{

  [Inject]
  public ClickAreaView clickAreaView { get; set; }

  [Inject]
  public CurrentMarkChangedSignal currentMarkChangedSignal { get; set; }

  [Inject]
  public AreaClickedSignal areaClickedSignal { get; set; }

  public override void OnRegister()
  {
    currentMarkChangedSignal.AddListener(OnMarkChanged);
    clickAreaView.areaClicked.AddListener(OnAreaClicked);
  }

  public void OnAreaClicked(string clickedIndex)
  {
    areaClickedSignal.Dispatch(clickedIndex);
  }

  public void OnMarkChanged(string currentMark)
  {
    clickAreaView.currentMark = currentMark;
  }
}
