using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks2._0Enum
{
    enum MainMenu : byte
    {
        AddMark, About, PrintArray, AvarageGrade, Exit,
    }

    enum ArrayType : sbyte
    {
        Math,
        PI,
        Physics,
        Art,
        Programming,
        Back,
    }
}
