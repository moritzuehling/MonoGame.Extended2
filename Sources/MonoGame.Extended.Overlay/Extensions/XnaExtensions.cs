﻿using Microsoft.Xna.Framework;
using SkiaSharp;

namespace MonoGame.Extended.Overlay.Extensions {
    internal static class XnaExtensions {

        // ReSharper disable once InconsistentNaming
        internal static SKColor ToSKColor(this Color color) {
            return new SKColor(color.R, color.G, color.B, color.A);
        }

    }
}
