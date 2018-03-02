using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using strange.extensions.context.impl;
using strange.extensions.command.impl;
using strange.extensions.command.api;
using strange.extensions.signal.impl;

public class TicTacContext : MVCSContext
{
  static TicTacContext context;

  public static TicTacContext GetTicTacContext(MonoBehaviour view)
  {
    if (context == null)
      return new TicTacContext(view);

    return context;
  }
  public TicTacContext(MonoBehaviour view) : base(view)
  { }

  protected override void mapBindings()
  {
    base.mapBindings();

    commandBinder.Bind<StartSignal>().To<TicTacGameStartCommand>().Once();
    commandBinder.Bind<ChangeSceneSignal>().To<ChangeSceneCommand>().Pooled();
    commandBinder.Bind<AreaClickedSignal>().To<AreaClickedCommand>().Pooled();

    injectionBinder.Bind<GameStatusChangedSignal>().ToSingleton();
    injectionBinder.Bind<CurrentMarkChangedSignal>().ToSingleton();

    mediationBinder.Bind<StartButtonView>().To<StartButtonMediator>();
    mediationBinder.Bind<ClickAreaView>().To<ClickAreaMediator>();
    mediationBinder.Bind<GameStatusView>().To<GameStatusMediator>();

    injectionBinder.Bind<IGameManager>().To<GameManager>().ToSingleton();

  }

  public override void Launch()
  {
    base.Launch();
    Signal startSignal = injectionBinder.GetInstance<StartSignal>();
    startSignal.Dispatch();
  }
}
