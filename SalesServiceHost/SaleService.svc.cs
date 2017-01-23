using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SalesServiceHost
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "SaleService" nel codice, nel file svc e nel file di configurazione contemporaneamente.
    // NOTA: per avviare il client di prova WCF per testare il servizio, selezionare SaleService.svc o SaleService.svc.cs in Esplora soluzioni e avviare il debug.
    public class SaleService : ISaleService
    {
        public void DoWork()
        {
        }
    }
}
