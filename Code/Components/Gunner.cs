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
    using UnityEngine;
    using uFrameECSDemo;
    using UniRx;
    using uFrame.ECS;
    
    
    [uFrame.Attributes.uFrameIdentifier("c1af0ce9-026a-43d8-9e67-7d92e304e7b8")]
    public partial class Gunner : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private List<Gun> _Guns;
        
        public int ComponentID {
            get {
                return 13;
            }
        }
        
        public List<Gun> Guns {
            get {
                if (_Guns == null) {
                    _Guns = new List<Gun>();
                }
                return _Guns;
            }
            set {
                _Guns = value;
            }
        }
    }
}
