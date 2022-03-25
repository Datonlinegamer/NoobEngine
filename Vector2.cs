using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Noobengine.Noobengine
{
    public class vector2
    {

        public float x { get; set; }
        public float y { get; set; }

        public vector2()
        {
            x = Zero().x;
            y = Zero().y;
   
        }

        ///<Summary>
        ///returns x&y as 0    
        /// <\Summary>
        ///<Returns><\returns>


        public vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }


        public static vector2 Zero()
        {
            return new vector2(0, 0);

        }

    }


}