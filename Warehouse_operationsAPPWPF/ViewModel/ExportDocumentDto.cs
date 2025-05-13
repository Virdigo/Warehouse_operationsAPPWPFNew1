using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_operationsAPPWPF.ViewModel
{
    public class ExportDocumentDto
    {
        public DateTime? Date { get; set; }
        public string ReceiptType { get; set; }
        public string UsersName { get; set; }
        public string ProductName { get; set; }
        public int? Quantity { get; set; }
        public string ReceiptDocName { get; set; }
        public string SuppliersName { get; set; }
        public decimal? Cost { get; set; }
        public decimal? Price { get; set; }
    }

}
