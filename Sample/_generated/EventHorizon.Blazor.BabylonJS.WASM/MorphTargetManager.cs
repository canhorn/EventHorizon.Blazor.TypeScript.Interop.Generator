/// Generated - Do Not Edit
namespace BabylonJS
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter))]
    public class MorphTargetManager : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static MorphTargetManager Parse(object serializationObject, Scene scene)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { "BABYLON", "MorphTargetManager", "Parse" }, serializationObject, scene
                }
            );
        }
        #endregion

        #region Accessors
        
        public decimal uniqueId
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "uniqueId"
                );
            }
        }

        
        public decimal vertexCount
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "vertexCount"
                );
            }
        }

        
        public bool supportsNormals
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "supportsNormals"
                );
            }
        }

        
        public bool supportsTangents
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "supportsTangents"
                );
            }
        }

        
        public bool supportsUVs
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "supportsUVs"
                );
            }
        }

        
        public decimal numTargets
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "numTargets"
                );
            }
        }

        
        public decimal numInfluencers
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<decimal>(
                    this.___guid,
                    "numInfluencers"
                );
            }
        }

        
        public decimal[] influences
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArray<decimal>(
                    this.___guid,
                    "influences"
                );
            }
        }
        #endregion

        #region Properties
        
        public bool enableNormalMorphing
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableNormalMorphing"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableNormalMorphing",
                    value
                );
            }
        }

        
        public bool enableTangentMorphing
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableTangentMorphing"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableTangentMorphing",
                    value
                );
            }
        }

        
        public bool enableUVMorphing
        {
            get
            {
            return EventHorizonBlazorInteropt.Get<bool>(
                    this.___guid,
                    "enableUVMorphing"
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "enableUVMorphing",
                    value
                );
            }
        }
        #endregion
        
        #region Constructor
        public MorphTargetManager() : base() { } 

        public MorphTargetManager(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }

        public MorphTargetManager(
            Scene scene = null
        )
        {
            var entity = EventHorizonBlazorInteropt.New(
                new string[] { "BABYLON", "MorphTargetManager" },
                scene
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public MorphTarget getActiveTarget(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getActiveTarget" }, index
                }
            );
        }

        public MorphTarget getTarget(decimal index)
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTarget>(
                entity => new MorphTarget() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "getTarget" }, index
                }
            );
        }

        public void addTarget(MorphTarget target)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "addTarget" }, target
                }
            );
        }

        public void removeTarget(MorphTarget target)
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "removeTarget" }, target
                }
            );
        }

        public MorphTargetManager clone()
        {
            return EventHorizonBlazorInteropt.FuncClass<MorphTargetManager>(
                entity => new MorphTargetManager() { ___guid = entity.___guid },
                new object[] 
                {
                    new string[] { this.___guid, "clone" }
                }
            );
        }

        public CachedEntity serialize()
        {
            return EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "serialize" }
                }
            );
        }

        public void synchronize()
        {
            EventHorizonBlazorInteropt.Func<CachedEntity>(
                new object[] 
                {
                    new string[] { this.___guid, "synchronize" }
                }
            );
        }
        #endregion
    }
}