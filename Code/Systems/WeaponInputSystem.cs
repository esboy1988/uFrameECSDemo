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
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    
    
    [uFrame.Attributes.uFrameIdentifier("a97bf658-eb09-4340-8a9c-be005f8be076")]
    public partial class WeaponInputSystem : uFrame.ECS.EcsSystem, uFrame.ECS.ISystemUpdate {
        
        private static WeaponInputSystem _Instance;
        
        private IEcsComponentManagerOf<ShootingGuns> _ShootingGunsManager;
        
        private IEcsComponentManagerOf<PlayerGunner> _PlayerGunnerManager;
        
        private IEcsComponentManagerOf<GunnerInput> _GunnerInputManager;
        
        private IEcsComponentManagerOf<Gunner> _GunnerManager;
        
        private IEcsComponentManagerOf<Gun> _GunManager;
        
        public static WeaponInputSystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
        
        public IEcsComponentManagerOf<ShootingGuns> ShootingGunsManager {
            get {
                return _ShootingGunsManager;
            }
            set {
                _ShootingGunsManager = value;
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
        
        public IEcsComponentManagerOf<GunnerInput> GunnerInputManager {
            get {
                return _GunnerInputManager;
            }
            set {
                _GunnerInputManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Gunner> GunnerManager {
            get {
                return _GunnerManager;
            }
            set {
                _GunnerManager = value;
            }
        }
        
        public IEcsComponentManagerOf<Gun> GunManager {
            get {
                return _GunManager;
            }
            set {
                _GunManager = value;
            }
        }
        
        public override void Setup() {
            Instance = this;
            base.Setup();
            ShootingGunsManager = ComponentSystem.RegisterGroup<ShootingGunsGroup,ShootingGuns>();
            PlayerGunnerManager = ComponentSystem.RegisterGroup<PlayerGunnerGroup,PlayerGunner>();
            GunnerInputManager = ComponentSystem.RegisterComponent<GunnerInput>(1);
            GunnerManager = ComponentSystem.RegisterComponent<Gunner>(3);
            GunManager = ComponentSystem.RegisterComponent<Gun>(2);
        }
        
        protected void GunnerInputUpdateHandler(PlayerGunner group) {
            var handler = new GunnerInputUpdateHandler();
            handler.System = this;
            handler.Group = group;
            handler.Execute();
        }
        
        protected void GunnerInputUpdateFilter() {
            var PlayerGunnerItems = PlayerGunnerManager.Components;
            for (var PlayerGunnerIndex = 0
            ; PlayerGunnerIndex < PlayerGunnerItems.Count; PlayerGunnerIndex++
            ) {
                if (!PlayerGunnerItems[PlayerGunnerIndex].Enabled) {
                    continue;
                }
                this.GunnerInputUpdateHandler(PlayerGunnerItems[PlayerGunnerIndex]);
            }
        }
        
        public virtual void SystemUpdate() {
            GunnerInputUpdateFilter();
        }
    }
}
