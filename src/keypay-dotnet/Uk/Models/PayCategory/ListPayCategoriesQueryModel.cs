using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.PayCategory
{
    public class ListPayCategoriesQueryModel
    {
        public string Query { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
