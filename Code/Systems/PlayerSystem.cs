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
    
    
    [uFrame.Attributes.uFrameIdentifier("c33125c8-912c-4fa4-921b-3b89581f3b04")]
    public partial class PlayerSystem : uFrame.ECS.EcsSystem {
        
        private static PlayerSystem _Instance;
        
        private IEcsComponentManagerOf<PlayerGunner> _PlayerGunnerManager;
        
        private IEcsComponentManagerOf<Movable> _MovableManager;
        
        private IEcsComponentManagerOf<Hazard> _HazardManager;
        
        private IEcsComponentManagerOf<WavesGame> _WavesGameManager;
        
        private IEcsComponentManagerOf<Player> _PlayerManager;
        
        public static PlayerSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
        
        public IEcsComponentManagerOf<PlayerGunner> PlayerGunnerManager {
            get {
                return _PlayerGunnerManager;
            }
            set {
                _PlayerGunnerManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Movable> MovableManager {
            get {
                return _MovableManager;
            }
            set {
                _MovableManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Hazard> HazardManager {
            get {
                return _HazardManager;
            }
            set {
                _HazardManager = value;
            }
        }
        
        public IEcsComponentManagerOf<WavesGame> WavesGameManager {
            get {
                return _WavesGameManager;
            }
            set {
                _WavesGameManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Player> PlayerManager {
            get {
                return _PlayerManager;
            }
            set {
                _PlayerManager = value;
            }
        }
        
        public override void Setup() {
            Instance = this;
            base.Setup();
            PlayerGunnerManager = ComponentSystem.RegisterGroup<PlayerGunnerGroup,PlayerGunner>();
            MovableManager = ComponentSystem.RegisterComponent<Movable>(25);
            HazardManager = ComponentSystem.RegisterComponent<Hazard>(81);
            WavesGameManager = ComponentSystem.RegisterComponent<WavesGame>(8);
            PlayerManager = ComponentSystem.RegisterComponent<Player>(23);
            PlayerGunnerManager.CreatedObservable.Subscribe(PlayerGunnerCreatedComponentCreatedFilter).DisposeWith(this);
            this.OnEvent<uFrameECSDemo.GameOver>().Subscribe(_=>{ PlayerSystemGameOverFilter(_); }).DisposeWith(this);
            PlayerGunnerManager.RemovedObservable.Subscribe(_=>PlayerGunnerComponentDestroyed(_,_)).DisposeWith(this);
            this.OnEvent<uFrame.ECS.OnTriggerEnterDispatcher>().Subscribe(_=>{ PlayerSystemOnCollisionEnterFilter(_); }).DisposeWith(this);
        }
        
        protected void PlayerGunnerCreatedComponentCreated(PlayerGunner data, PlayerGunner group) {
            var handler = new PlayerGunnerCreatedComponentCreated();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void PlayerGunnerCreatedComponentCreatedFilter(PlayerGunner data) {
            var GroupItem = PlayerGunnerManager[data.EntityId];
            if (GroupItem == null) {
                return;
            }
            if (!GroupItem.Enabled) {
                return;
            }
            this.PlayerGunnerCreatedComponentCreated(data, GroupItem);
        }
        
        protected void PlayerSystemGameOverHandler(uFrameECSDemo.GameOver data, WavesGame group) {
            var handler = new PlayerSystemGameOverHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void PlayerSystemGameOverFilter(uFrameECSDemo.GameOver data) {
            var WavesGameItems = WavesGameManager.Components;
            for (var WavesGameIndex = 0
            ; WavesGameIndex < WavesGameItems.Count; WavesGameIndex++
            ) {
                if (!WavesGameItems[WavesGameIndex].Enabled) {
                    continue;
                }
                this.PlayerSystemGameOverHandler(data, WavesGameItems[WavesGameIndex]);
            }
        }
        
        protected void PlayerGunnerComponentDestroyed(PlayerGunner data, PlayerGunner group) {
            var handler = new PlayerGunnerComponentDestroyed();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void PlayerGunnerComponentDestroyedFilter(PlayerGunner data) {
            var GroupItem = PlayerGunnerManager[data.EntityId];
            if (GroupItem == null) {
                return;
            }
            if (!GroupItem.Enabled) {
                return;
            }
            this.PlayerGunnerComponentDestroyed(data, GroupItem);
        }
        
        protected void PlayerSystemOnCollisionEnterHandler(uFrame.ECS.OnTriggerEnterDispatcher data, Hazard collider, PlayerGunner source) {
            var handler = new PlayerSystemOnCollisionEnterHandler();
            handler.System = this;
            handler.Event = data;
            handler.Collider = collider;
            handler.Source = source;
            handler.Execute();
        }
        
        protected void PlayerSystemOnCollisionEnterFilter(uFrame.ECS.OnTriggerEnterDispatcher data) {
            var ColliderHazard = HazardManager[data.ColliderId];
            if (ColliderHazard == null) {
                return;
            }
            if (!ColliderHazard.Enabled) {
                return;
            }
            var SourceItem = PlayerGunnerManager[data.EntityId];
            if (SourceItem == null) {
                return;
            }
            if (!SourceItem.Enabled) {
                return;
            }
            this.PlayerSystemOnCollisionEnterHandler(data, ColliderHazard, SourceItem);
        }
    }
}
