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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(3)]
    [uFrame.Attributes.uFrameIdentifier("c1af0ce9-026a-43d8-9e67-7d92e304e7b8")]
    public partial class Gunner : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Gun[] _Guns;
        
        private ReactiveCollection<Gun> _GunsReactive;
        
        public override int ComponentId {
            get {
                return 3;
            }
        }
        
        public ReactiveCollection<Gun> Guns {
            get {
                if (_GunsReactive == null) {
                    _GunsReactive = new ReactiveCollection<Gun>(_Guns ?? new Gun[] { });
                }
                return _GunsReactive;
            }
        }
    }
}
