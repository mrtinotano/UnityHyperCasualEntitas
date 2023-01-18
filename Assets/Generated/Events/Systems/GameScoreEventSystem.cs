//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.EventSystemGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed class GameScoreEventSystem : Entitas.ReactiveSystem<GuiEntity> {

    readonly System.Collections.Generic.List<IGameScoreListener> _listenerBuffer;

    public GameScoreEventSystem(Contexts contexts) : base(contexts.gui) {
        _listenerBuffer = new System.Collections.Generic.List<IGameScoreListener>();
    }

    protected override Entitas.ICollector<GuiEntity> GetTrigger(Entitas.IContext<GuiEntity> context) {
        return Entitas.CollectorContextExtension.CreateCollector(
            context, Entitas.TriggerOnEventMatcherExtension.Added(GuiMatcher.GameScore)
        );
    }

    protected override bool Filter(GuiEntity entity) {
        return entity.hasGameScore && entity.hasGameScoreListener;
    }

    protected override void Execute(System.Collections.Generic.List<GuiEntity> entities) {
        foreach (var e in entities) {
            var component = e.gameScore;
            _listenerBuffer.Clear();
            _listenerBuffer.AddRange(e.gameScoreListener.value);
            foreach (var listener in _listenerBuffer) {
                listener.OnGameScore(e, component.GameScore);
            }
        }
    }
}
