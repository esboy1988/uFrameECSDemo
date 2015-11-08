// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace uFrameECSDemo {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrameECSDemo;
    using UnityEngine;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("c39f72a9-03fa-4cc0-990c-f82be2aa6954")]
    public partial class ScrollSystem : uFrame.ECS.EcsSystem, uFrame.ECS.ISystemUpdate {
        
        private static ScrollSystem _Instance;
        
        private IEcsComponentManagerOf<BackgroundScroller> _BackgroundScrollerManager;
        
        public static ScrollSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
        
        public IEcsComponentManagerOf<BackgroundScroller> BackgroundScrollerManager {
            get {
                return _BackgroundScrollerManager;
            }
            set {
                _BackgroundScrollerManager = value;
            }
        }
        
        public override void Setup() {
            Instance = this;
            base.Setup();
            BackgroundScrollerManager = ComponentSystem.RegisterComponent<BackgroundScroller>(5);
            BackgroundScrollerManager.CreatedObservable.Subscribe(GrabStartPositionComponentCreatedFilter).DisposeWith(this);
        }
        
        protected void ScrollSystemUpdateHandler(BackgroundScroller group) {
            var handler = new ScrollSystemUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void ScrollSystemUpdateFilter() {
            var BackgroundScrollerItems = BackgroundScrollerManager.Components;
            for (var BackgroundScrollerIndex = 0
            ; BackgroundScrollerIndex < BackgroundScrollerItems.Count; BackgroundScrollerIndex++
            ) {
                if (!BackgroundScrollerItems[BackgroundScrollerIndex].Enabled) {
                    continue;
                }
                this.ScrollSystemUpdateHandler(BackgroundScrollerItems[BackgroundScrollerIndex]);
            }
        }
        
        public virtual void SystemUpdate() {
            ScrollSystemUpdateFilter();
        }
        
        protected void GrabStartPositionComponentCreated(BackgroundScroller data, BackgroundScroller group) {
            var handler = new GrabStartPositionComponentCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void GrabStartPositionComponentCreatedFilter(BackgroundScroller data) {
            var GroupBackgroundScroller = BackgroundScrollerManager[data.EntityId];
            if (GroupBackgroundScroller == null) {
                return;
            }
            if (!GroupBackgroundScroller.Enabled) {
                return;
            }
            this.GrabStartPositionComponentCreated(data, GroupBackgroundScroller);
        }
    }
}
