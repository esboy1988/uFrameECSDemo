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
    using uFrame.ECS;
    using uFrame.Kernel;
    
    
    public partial class DemoLoader : uFrame.Kernel.SystemLoader {
        
        public override void Load() {
            EcsSystem system = null;
            system = this.AddSystem<ShootingSystem>();
            system = this.AddSystem<InputSystem>();
            system = this.AddSystem<HazardSystem>();
            system = this.AddSystem<GameSystem>();
            system = this.AddSystem<WeaponSystem>();
            system = this.AddSystem<SoundSystem>();
            system = this.AddSystem<WavesGameSystem>();
            system = this.AddSystem<Shooter>();
            system = this.AddSystem<ScrollSystem>();
            system = this.AddSystem<FxSystem>();
        }
    }
}
