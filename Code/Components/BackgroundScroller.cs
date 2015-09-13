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
    using UnityEngine;
    using UniRx;
    
    
    public partial class BackgroundScroller : uFrame.ECS.EcsComponent {
        
        private Subject<Vector3> _StartPositionObservable;
        
        private Subject<Single> _ScrollSpeedObservable;
        
        private Subject<Single> _TileSizeZObservable;
        
        [UnityEngine.SerializeField()]
        private Vector3 _StartPosition;
        
        [UnityEngine.SerializeField()]
        private Single _ScrollSpeed;
        
        [UnityEngine.SerializeField()]
        private Single _TileSizeZ;
        
        public int ComponentID {
            get {
                return 13;
            }
        }
        
        public IObservable<Vector3> StartPositionObservable {
            get {
                if (_StartPositionObservable == null) {
                    _StartPositionObservable = new Subject<Vector3>();
                }
                return _StartPositionObservable;
            }
        }
        
        public IObservable<Single> ScrollSpeedObservable {
            get {
                if (_ScrollSpeedObservable == null) {
                    _ScrollSpeedObservable = new Subject<Single>();
                }
                return _ScrollSpeedObservable;
            }
        }
        
        public IObservable<Single> TileSizeZObservable {
            get {
                if (_TileSizeZObservable == null) {
                    _TileSizeZObservable = new Subject<Single>();
                }
                return _TileSizeZObservable;
            }
        }
        
        public Vector3 StartPosition {
            get {
                return _StartPosition;
            }
            set {
                _StartPosition = value;
                if (_StartPositionObservable != null) {
                    _StartPositionObservable.OnNext(value);
                }
            }
        }
        
        public Single ScrollSpeed {
            get {
                return _ScrollSpeed;
            }
            set {
                _ScrollSpeed = value;
                if (_ScrollSpeedObservable != null) {
                    _ScrollSpeedObservable.OnNext(value);
                }
            }
        }
        
        public Single TileSizeZ {
            get {
                return _TileSizeZ;
            }
            set {
                _TileSizeZ = value;
                if (_TileSizeZObservable != null) {
                    _TileSizeZObservable.OnNext(value);
                }
            }
        }
    }
}