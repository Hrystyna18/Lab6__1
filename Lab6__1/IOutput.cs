using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_1
{
    interface IOutput
    {
        void Write(DateTime date);
        void WriteNearest(DateTime date);

        void WriteFutureBirthdays(DateTime date);
    }
}
