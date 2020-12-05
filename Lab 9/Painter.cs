using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9
{
    static class Painter
    {
        public static void Draw(IDraw objectToDraw) => objectToDraw.Draw();
    }
}
