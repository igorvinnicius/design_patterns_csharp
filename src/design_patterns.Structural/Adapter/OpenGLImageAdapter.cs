using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Structural.Adapter
{
    public class OpenGLImageAdapter : ImageTarget
    {
		private OpenGLImage _openGLImage;

		public OpenGLImageAdapter()
		{
			_openGLImage = new OpenGLImage();
		}

		public void DrawImage(int posX, int posY, int height, int witdh)
		{
			_openGLImage.DrawImage(posX, posY);
		}

		public void LoadImage(string path)
		{
			_openGLImage.LoadImage(path);
		}
	}
}
