//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentContextApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GuiContext {

    public GuiEntity resetScoreEntity { get { return GetGroup(GuiMatcher.ResetScore).GetSingleEntity(); } }

    public bool isResetScore {
        get { return resetScoreEntity != null; }
        set {
            var entity = resetScoreEntity;
            if (value != (entity != null)) {
                if (value) {
                    CreateEntity().isResetScore = true;
                } else {
                    entity.Destroy();
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GuiEntity {

    static readonly HyperCasual.GUI.ResetScoreComponent resetScoreComponent = new HyperCasual.GUI.ResetScoreComponent();

    public bool isResetScore {
        get { return HasComponent(GuiComponentsLookup.ResetScore); }
        set {
            if (value != isResetScore) {
                var index = GuiComponentsLookup.ResetScore;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : resetScoreComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
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

    static Entitas.IMatcher<GuiEntity> _matcherResetScore;

    public static Entitas.IMatcher<GuiEntity> ResetScore {
        get {
            if (_matcherResetScore == null) {
                var matcher = (Entitas.Matcher<GuiEntity>)Entitas.Matcher<GuiEntity>.AllOf(GuiComponentsLookup.ResetScore);
                matcher.componentNames = GuiComponentsLookup.componentNames;
                _matcherResetScore = matcher;
            }

            return _matcherResetScore;
        }
    }
}
