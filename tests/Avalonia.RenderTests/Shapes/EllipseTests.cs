// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Media;
using Xunit;

#if AVALONIA_CAIRO
namespace Avalonia.Cairo.RenderTests.Shapes
#elif AVALONIA_SKIA
namespace Avalonia.Skia.RenderTests
#else
namespace Avalonia.Direct2D1.RenderTests.Shapes
#endif
{
    public class EllipseTests : TestBase
    {
        public EllipseTests()
            : base(@"Shapes\Ellipse")
        {
        }

        [Fact]
        public void Circle_1px_Stroke()
        {
            Decorator target = new Decorator
            {
                Padding = new Thickness(8),
                Width = 200,
                Height = 200,
                Child = new Ellipse
                {
                    Stroke = Brushes.Black,
                    StrokeThickness = 1,
                }
            };

            RenderToFile(target);
            CompareImages();
        }
    }
}
