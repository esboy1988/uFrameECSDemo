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
    using uFrame.ECS;
    using UniRx;
    using uFrameECSDemo;
    
    
    public partial class ContinuousMovement : uFrame.ECS.EcsComponent {
        
        private Subject<Single> _SpeedObservable;
        
        private Subject<Vector3> _DirectionObservable;
        
        [UnityEngine.SerializeField()]
        private Single _Speed;
        
        [UnityEngine.SerializeField()]
        private Vector3 _Direction;
        
        public int ComponentID {
            get {
                return 1;
            }
        }
        
        public IObservable<Single> SpeedObservable {
            get {
                if (_SpeedObservable == null) {
                    _SpeedObservable = new Subject<Single>();
                }
                return _SpeedObservable;
            }
        }
        
        public IObservable<Vector3> DirectionObservable {
            get {
                if (_DirectionObservable == null) {
                    _DirectionObservable = new Subject<Vector3>();
                }
                return _DirectionObservable;
            }
        }
        
        public Single Speed {
            get {
                return _Speed;
            }
            set {
                _Speed = value;
                if (_SpeedObservable != null) {
                    _SpeedObservable.OnNext(value);
                }
            }
        }
        
        public Vector3 Direction {
            get {
                return _Direction;
            }
            set {
                _Direction = value;
                if (_DirectionObservable != null) {
                    _DirectionObservable.OnNext(value);
                }
            }
        }
    }
}
