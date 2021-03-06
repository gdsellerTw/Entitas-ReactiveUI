//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public TickListenerComponent tickListener { get { return (TickListenerComponent)GetComponent(ComponentIds.TickListener); } }

        public bool hasTickListener { get { return HasComponent(ComponentIds.TickListener); } }

        public Entity AddTickListener(ITickListener newListener) {
            var component = CreateComponent<TickListenerComponent>(ComponentIds.TickListener);
            component.listener = newListener;
            return AddComponent(ComponentIds.TickListener, component);
        }

        public Entity ReplaceTickListener(ITickListener newListener) {
            var component = CreateComponent<TickListenerComponent>(ComponentIds.TickListener);
            component.listener = newListener;
            ReplaceComponent(ComponentIds.TickListener, component);
            return this;
        }

        public Entity RemoveTickListener() {
            return RemoveComponent(ComponentIds.TickListener);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherTickListener;

        public static IMatcher TickListener {
            get {
                if (_matcherTickListener == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.TickListener);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherTickListener = matcher;
                }

                return _matcherTickListener;
            }
        }
    }
}
