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
    using uFrame.Kernel;
    using uFrame.ECS;
    using UnityEngine;
    
    
    public class PlayerGunnerComponentDestroyed {
        
        public PlayerGunner Group;
        
        private PlayerGunner _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private uFrameECSDemo.GameOver PublishEventNode19_Result = default( uFrameECSDemo.GameOver );
        
        public PlayerGunner Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual void Execute() {
            // PublishEventNode
            var PublishEventNode19_Event = new GameOver();
            System.Publish(PublishEventNode19_Event);
            PublishEventNode19_Result = PublishEventNode19_Event;
        }
    }
}
