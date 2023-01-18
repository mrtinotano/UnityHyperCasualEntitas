//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ActiveGameObjectListenerComponent activeGameObjectListener { get { return (ActiveGameObjectListenerComponent)GetComponent(GameComponentsLookup.ActiveGameObjectListener); } }
    public bool hasActiveGameObjectListener { get { return HasComponent(GameComponentsLookup.ActiveGameObjectListener); } }

    public void AddActiveGameObjectListener(System.Collections.Generic.List<IActiveGameObjectListener> newValue) {
        var index = GameComponentsLookup.ActiveGameObjectListener;
        var component = (ActiveGameObjectListenerComponent)CreateComponent(index, typeof(ActiveGameObjectListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceActiveGameObjectListener(System.Collections.Generic.List<IActiveGameObjectListener> newValue) {
        var index = GameComponentsLookup.ActiveGameObjectListener;
        var component = (ActiveGameObjectListenerComponent)CreateComponent(index, typeof(ActiveGameObjectListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveActiveGameObjectListener() {
        RemoveComponent(GameComponentsLookup.ActiveGameObjectListener);
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
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherActiveGameObjectListener;

    public static Entitas.IMatcher<GameEntity> ActiveGameObjectListener {
        get {
            if (_matcherActiveGameObjectListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ActiveGameObjectListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherActiveGameObjectListener = matcher;
            }

            return _matcherActiveGameObjectListener;
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
public partial class GameEntity {

    public void AddActiveGameObjectListener(IActiveGameObjectListener value) {
        var listeners = hasActiveGameObjectListener
            ? activeGameObjectListener.value
            : new System.Collections.Generic.List<IActiveGameObjectListener>();
        listeners.Add(value);
        ReplaceActiveGameObjectListener(listeners);
    }

    public void RemoveActiveGameObjectListener(IActiveGameObjectListener value, bool removeComponentWhenEmpty = true) {
        var listeners = activeGameObjectListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveActiveGameObjectListener();
        } else {
            ReplaceActiveGameObjectListener(listeners);
        }
    }
}
