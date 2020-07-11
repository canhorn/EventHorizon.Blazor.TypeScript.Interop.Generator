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
        
        public TransformNode[] rootNodes
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<TransformNode>(
                    this.___guid,
                    "rootNodes",
                    (entity) =>
                    {
                        return new TransformNode(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "rootNodes",
                    value
                );
            }
        }

        
        public Skeleton[] skeletons
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<Skeleton>(
                    this.___guid,
                    "skeletons",
                    (entity) =>
                    {
                        return new Skeleton(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "skeletons",
                    value
                );
            }
        }

        
        public AnimationGroup[] animationGroups
        {
            get
            {
            return EventHorizonBlazorInteropt.GetArrayClass<AnimationGroup>(
                    this.___guid,
                    "animationGroups",
                    (entity) =>
                    {
                        return new AnimationGroup(entity);
                    }
                );
            }
            set
            {

                EventHorizonBlazorInteropt.Set(
                    this.___guid,
                    "animationGroups",
                    value
                );
            }
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