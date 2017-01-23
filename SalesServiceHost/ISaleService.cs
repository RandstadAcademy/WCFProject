﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SalesServiceHost
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "ISaleService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface ISaleService
    {
        [OperationContract]
        void DoWork();
    }
}
