using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PccLocationGroupApiModel
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public IList<PccEmployeeGroupApiModel> EmployeeGroups { get; set; }
        public PccReportTotalRowApiModel Subtotals { get; set; }
    }
}
