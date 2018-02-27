using System.Collections;
using System.Collections.Generic;
using strange.extensions.signal.impl;
using UnityEngine;

public class StartSignal : Signal {}
public class ChangeSceneSignal : Signal <int> {}
public class AreaClickedSignal : Signal <string> {}
public class GameStatusChangedSignal : Signal <string> {}
public class CurrentMarkChangedSignal : Signal <string> {}