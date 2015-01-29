using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCerta.NFe.Schemas
{
    public partial class IdentificacaoNFe
    {
        public DateTimeOffset DataEmissao
        {
            get { return DateTimeOffset.Parse(dhEmi); }
        }
    }
}
