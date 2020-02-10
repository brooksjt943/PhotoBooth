using System.Collections.Generic;
using System.Drawing;

namespace PhotoBooth
{
    public class Constants
    {
        public List<Frame> FrameList = new List<Frame>();

        // Add new frames here.  ("Frame Name", Width, Height, X, Y position (top left corner point)
        public Constants()
        {
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\DotsFrame.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\DotsFrameLogo.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\FlowerFrame.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\FlowerFrameColor.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\FlowerFrameColor2.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\PaintFrame.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\PaintFrameLogo.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\PaintFrameLogo2.png"), 736, 572, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\PaintFrameLogo3.png"), 736, 572, 0, 0));

            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\PolkaDots.png"), 697, 700, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\Rainbow.png"), 750, 550, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RedFlowerFrame.png"), 500, 500, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RedFrame.png"), 800, 577, 0, 0));

            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RedFrameLogo.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RedFrameLogo2.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RedFrameLogo3.png"), 800, 577, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RoseFrame.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RoseFrameLogo.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\RoseFrameLogo2.png"), 641, 531, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\TestFrame.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\TestFrameColor.png"), 800, 598, 0, 0));
            FrameList.Add(new Frame(new Bitmap("F:\\Frames\\Water.png"), 620, 440, 0, 0));

        }
    }
}
