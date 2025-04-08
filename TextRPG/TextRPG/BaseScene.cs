using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    /// <summary>
    /// 씬 동작의 기본이 되는 추상클래스 BaseScene
    /// </summary>
    public abstract class BaseScene
    {
        public abstract void Render();
        public abstract void Input();
        public abstract void Update();
        public abstract void Result();

    }
}
