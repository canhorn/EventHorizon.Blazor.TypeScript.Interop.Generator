/// Generated - Do Not Edit
namespace BABYLON.GUI
{
    using System;
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using EventHorizon.Blazor.Interop;
    using EventHorizon.Blazor.Interop.Callbacks;
    using EventHorizon.Blazor.Interop.ResultCallbacks;
    using Microsoft.JSInterop;

    [JsonConverter(typeof(CachedEntityConverter<Button>))]
    public class Button : Rectangle
    {
        #region Static Accessors

        #endregion

        #region Static Properties

        #endregion

        #region Static Methods
        public static Button CreateImageButton(string name, string text, string imageUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageButton" },
                    name,
                    text,
                    imageUrl
                }
            );
        }

        public static Button CreateImageOnlyButton(string name, string imageUrl)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageOnlyButton" },
                    name,
                    imageUrl
                }
            );
        }

        public static Button CreateSimpleButton(string name, string text)
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateSimpleButton" },
                    name,
                    text
                }
            );
        }

        public static Button CreateImageWithCenterTextButton(
            string name,
            string text,
            string imageUrl
        )
        {
            return EventHorizonBlazorInterop.FuncClass<Button>(
                entity => new Button() { ___guid = entity.___guid },
                new object[]
                {
                    new string[] { "BABYLON", "GUI", "Button", "CreateImageWithCenterTextButton" },
                    name,
                    text,
                    imageUrl
                }
            );
        }
        #endregion

        #region Accessors
        private Image __image;
        public Image image
        {
            get
            {
                if (__image == null)
                {
                    __image = EventHorizonBlazorInterop.GetClass<Image>(
                        this.___guid,
                        "image",
                        (entity) =>
                        {
                            return new Image() { ___guid = entity.___guid };
                        }
                    );
                }
                return __image;
            }
        }

        private TextBlock __textBlock;
        public TextBlock textBlock
        {
            get
            {
                if (__textBlock == null)
                {
                    __textBlock = EventHorizonBlazorInterop.GetClass<TextBlock>(
                        this.___guid,
                        "textBlock",
                        (entity) =>
                        {
                            return new TextBlock() { ___guid = entity.___guid };
                        }
                    );
                }
                return __textBlock;
            }
        }
        #endregion

        #region Properties

        public string name
        {
            get { return EventHorizonBlazorInterop.Get<string>(this.___guid, "name"); }
            set
            {

                EventHorizonBlazorInterop.Set(this.___guid, "name", value);
            }
        }
        #endregion

        #region Constructor
        public Button()
            : base() { }

        public Button(ICachedEntity entity)
            : base(entity) { }

        public Button(string name = null)
            : base()
        {
            var entity = EventHorizonBlazorInterop.New(
                new string[] { "BABYLON", "GUI", "Button" },
                name
            );
            ___guid = entity.___guid;
        }
        #endregion

        #region Methods
        public void pointerEnterAnimation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pointerEnterAnimation" } }
            );
        }

        public void pointerOutAnimation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pointerOutAnimation" } }
            );
        }

        public void pointerDownAnimation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pointerDownAnimation" } }
            );
        }

        public void pointerUpAnimation()
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[] { new string[] { this.___guid, "pointerUpAnimation" } }
            );
        }

        public void serialize(object serializationObject, bool force)
        {
            EventHorizonBlazorInterop.Func<CachedEntity>(
                new object[]
                {
                    new string[] { this.___guid, "serialize" },
                    serializationObject,
                    force
                }
            );
        }
        #endregion
    }
}
