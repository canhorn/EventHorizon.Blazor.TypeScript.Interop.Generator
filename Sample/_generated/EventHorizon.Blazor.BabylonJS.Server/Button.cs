/// Generated - Do Not Edit
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EventHorizon.Blazor.Server.Interop;
using EventHorizon.Blazor.Server.Interop.Callbacks;
using EventHorizon.Blazor.Server.Interop.ResultCallbacks;
using Microsoft.JSInterop;

[JsonConverter(typeof(CachedEntityConverter<Button>))]
public class Button : Rectangle
{
    #region Static Accessors

    #endregion

    #region Static Properties

    #endregion

    #region Static Methods
    public static async ValueTask<Button> CreateImageButton(
        string name,
        string text,
        string imageUrl
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<Button>(
            entity => new Button() { ___guid = entity.___guid },
            new object[] { new string[] { "Button", "CreateImageButton" }, name, text, imageUrl }
        );
    }

    public static async ValueTask<Button> CreateImageOnlyButton(string name, string imageUrl)
    {
        return await EventHorizonBlazorInterop.FuncClass<Button>(
            entity => new Button() { ___guid = entity.___guid },
            new object[] { new string[] { "Button", "CreateImageOnlyButton" }, name, imageUrl }
        );
    }

    public static async ValueTask<Button> CreateSimpleButton(string name, string text)
    {
        return await EventHorizonBlazorInterop.FuncClass<Button>(
            entity => new Button() { ___guid = entity.___guid },
            new object[] { new string[] { "Button", "CreateSimpleButton" }, name, text }
        );
    }

    public static async ValueTask<Button> CreateImageWithCenterTextButton(
        string name,
        string text,
        string imageUrl
    )
    {
        return await EventHorizonBlazorInterop.FuncClass<Button>(
            entity => new Button() { ___guid = entity.___guid },
            new object[]
            {
                new string[] { "Button", "CreateImageWithCenterTextButton" },
                name,
                text,
                imageUrl
            }
        );
    }
    #endregion

    #region Accessors
    private Image __image;

    public async ValueTask<Image> get_image()
    {
        if (__image == null)
        {
            __image = await EventHorizonBlazorInterop.GetClass<Image>(
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

    private TextBlock __textBlock;

    public async ValueTask<TextBlock> get_textBlock()
    {
        if (__textBlock == null)
        {
            __textBlock = await EventHorizonBlazorInterop.GetClass<TextBlock>(
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
    #endregion

    #region Properties

    public async ValueTask<string> get_name()
    {
        return await EventHorizonBlazorInterop.Get<string>(this.___guid, "name");
    }

    public ValueTask set_name(string value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "name", value);
    }

    public async ValueTask<bool> get_delegatePickingToChildren()
    {
        return await EventHorizonBlazorInterop.Get<bool>(this.___guid, "delegatePickingToChildren");
    }

    public ValueTask set_delegatePickingToChildren(bool value)
    {
        return EventHorizonBlazorInterop.Set(this.___guid, "delegatePickingToChildren", value);
    }
    #endregion

    #region Constructor
    public Button()
        : base() { }

    public Button(ICachedEntity entity)
        : base(entity) { }

    public static async ValueTask<Button> NewButton(string name = null)
    {
        var entity = await EventHorizonBlazorInterop.New(new string[] { "Button" }, name);

        return new Button(entity);
    }
    #endregion

    #region Methods
    public async ValueTask pointerEnterAnimation()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "pointerEnterAnimation" } }
        );
    }

    public async ValueTask pointerOutAnimation()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "pointerOutAnimation" } }
        );
    }

    public async ValueTask pointerDownAnimation()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "pointerDownAnimation" } }
        );
    }

    public async ValueTask pointerUpAnimation()
    {
        await EventHorizonBlazorInterop.Func<CachedEntity>(
            new object[] { new string[] { this.___guid, "pointerUpAnimation" } }
        );
    }
    #endregion
}
