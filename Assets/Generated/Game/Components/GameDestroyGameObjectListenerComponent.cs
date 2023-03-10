//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public DestroyGameObjectListenerComponent destroyGameObjectListener { get { return (DestroyGameObjectListenerComponent)GetComponent(GameComponentsLookup.DestroyGameObjectListener); } }
    public bool hasDestroyGameObjectListener { get { return HasComponent(GameComponentsLookup.DestroyGameObjectListener); } }

    public void AddDestroyGameObjectListener(System.Collections.Generic.List<IDestroyGameObjectListener> newValue) {
        var index = GameComponentsLookup.DestroyGameObjectListener;
        var component = (DestroyGameObjectListenerComponent)CreateComponent(index, typeof(DestroyGameObjectListenerComponent));
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceDestroyGameObjectListener(System.Collections.Generic.List<IDestroyGameObjectListener> newValue) {
        var index = GameComponentsLookup.DestroyGameObjectListener;
        var component = (DestroyGameObjectListenerComponent)CreateComponent(index, typeof(DestroyGameObjectListenerComponent));
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveDestroyGameObjectListener() {
        RemoveComponent(GameComponentsLookup.DestroyGameObjectListener);
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

    static Entitas.IMatcher<GameEntity> _matcherDestroyGameObjectListener;

    public static Entitas.IMatcher<GameEntity> DestroyGameObjectListener {
        get {
            if (_matcherDestroyGameObjectListener == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.DestroyGameObjectListener);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherDestroyGameObjectListener = matcher;
            }

            return _matcherDestroyGameObjectListener;
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

    public void AddDestroyGameObjectListener(IDestroyGameObjectListener value) {
        var listeners = hasDestroyGameObjectListener
            ? destroyGameObjectListener.value
            : new System.Collections.Generic.List<IDestroyGameObjectListener>();
        listeners.Add(value);
        ReplaceDestroyGameObjectListener(listeners);
    }

    public void RemoveDestroyGameObjectListener(IDestroyGameObjectListener value, bool removeComponentWhenEmpty = true) {
        var listeners = destroyGameObjectListener.value;
        listeners.Remove(value);
        if (removeComponentWhenEmpty && listeners.Count == 0) {
            RemoveDestroyGameObjectListener();
        } else {
            ReplaceDestroyGameObjectListener(listeners);
        }
    }
}
