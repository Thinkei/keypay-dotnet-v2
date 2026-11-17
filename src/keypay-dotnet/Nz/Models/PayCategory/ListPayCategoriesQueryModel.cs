using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Nz.Models.Common;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.PayCategory
{
    public class ListPayCategoriesQueryModel
    {
        public string Query { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
