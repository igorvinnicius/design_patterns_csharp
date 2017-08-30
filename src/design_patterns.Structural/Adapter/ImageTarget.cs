using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns.Structural.Adapter
{
    public interface ImageTarget
    {
		void LoadImage(string path);

		void DrawImage(int posX, int posY, int height, int witdh);


	}
}
