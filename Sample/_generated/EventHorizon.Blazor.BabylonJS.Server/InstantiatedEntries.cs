/// Generated - Do Not Edit
namespace BABYLON
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Server.Interop;
    using EventHorizon.Blazor.Server.Interop.Callbacks;
    using Microsoft.JSInterop;

    
    
    [JsonConverter(typeof(CachedEntityConverter<InstantiatedEntries>))]
    public class InstantiatedEntries : CachedEntityObject
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods

        #endregion

        #region Accessors

        #endregion

        #region Properties
        
        public async ValueTask<TransformNode[]> get_rootNodes()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<TransformNode>(
                    this.___guid,
                    "rootNodes",
                    (entity) =>
                    {
                        return new TransformNode() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_rootNodes(TransformNode[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "rootNodes",
                    value
                );
        }

        
        public async ValueTask<Skeleton[]> get_skeletons()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_skeletons(Skeleton[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "skeletons",
                    value
                );
        }

        
        public async ValueTask<AnimationGroup[]> get_animationGroups()
        {
            return await EventHorizonBlazorInterop.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup() { ___guid = entity.___guid };
                    }
                );
        }
        public ValueTask set_animationGroups(AnimationGroup[] value)
        {

                return EventHorizonBlazorInterop.Set(
                    this.___guid,
                    "animationGroups",
                    value
                );
        }
        #endregion
        
        #region Constructor
        public InstantiatedEntries() : base() { } 

        public InstantiatedEntries(
            ICachedEntity entity
        ) : base(entity)
        {
            ___guid = entity.___guid;
        }


        #endregion

        #region Methods

        #endregion
    }
}