//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GuiEntity {

    public GameScoreListenerComponent gameScoreListener { get { return (GameScoreListenerComponent)GetComponent(GuiComponentsLookup.GameScoreListener); } }
    public bool hasGameScoreListener { get { return HasComponent(GuiComponentsLookup.GameScoreListener); } }

    public void AddGameScoreListener(System.Collections.Generic.List<IGameScoreListener> newValue) {
        var index = GuiComponentsLookup.GameScoreListener;
        var component = (GameScoreListenerComponent)CreateComponent(index, typeof(GameScoreListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceGameScoreListener(System.Collections.Generic.List<IGameScoreListener> newValue) {
        var index = GuiComponentsLookup.GameScoreListener;
        var component = (GameScoreListenerComponent)CreateComponent(index, typeof(GameScoreListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveGameScoreListener() {
        RemoveComponent(GuiComponentsLookup.GameScoreListener);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GuiMatcher {

    static Entitas.IMatcher<GuiEntity> _matcherGameScoreListener;

    public static Entitas.IMatcher<GuiEntity> GameScoreListener {
        get {
            if (_matcherGameScoreListener == null) {
                var matcher = (Entitas.Matcher<GuiEntity>)Entitas.Matcher<GuiEntity>.AllOf(GuiComponentsLookup.GameScoreListener);
                matcher.componentNames = GuiComponentsLookup.componentNames;
                _matcherGameScoreListener = matcher;
            }

            return _matcherGameScoreListener;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GuiEntity {

    public void AddGameScoreListener(IGameScoreListener value) {
        var listeners = hasGameScoreListener
            ? gameScoreListener.value
            : new System.Collections.Generic.List<IGameScoreListener>();
        listeners.Add(value);
        ReplaceGameScoreListener(listeners);
    }

    public void RemoveGameScoreListener(IGameScoreListener value, bool removeComponentWhenEmpty = true) {
        var listeners = gameScoreListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveGameScoreListener();
        } else {
            ReplaceGameScoreListener(listeners);
        }
    }
}
