﻿using HIMS.Model.Opd;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIMS.Data.Opd
{
    public interface I_LoginManager
    {
        Login Get(string userName);
    }
}
