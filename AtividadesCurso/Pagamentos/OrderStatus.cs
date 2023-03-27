using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadesCurso.Pagamentos
{
    public enum OrderStatus
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
