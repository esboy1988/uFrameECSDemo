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
    using UniRx;
    using uFrame.Kernel;
    using uFrame.ECS;
    
    
    public partial class EnemyShip : uFrame.ECS.GroupItem {
        
        private Deadly _Deadly;
        
        private Ship _Ship;
        
        public Deadly Deadly {
            get {
                return _Deadly;
            }
            set {
                _Deadly = value;
            }
        }
        
        public Ship Ship {
            get {
                return _Ship;
            }
            set {
                _Ship = value;
            }
        }
        
        public int ComponentID {
            get {
                return 12;
            }
        }
    }
}
