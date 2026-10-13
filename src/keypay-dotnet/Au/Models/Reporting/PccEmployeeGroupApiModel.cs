using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PccEmployeeGroupApiModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExternalId { get; set; }
        public PccReportTotalRowApiModel Subtotals { get; set; }
        public IList<PccReportRowApiModel> PayRunRows { get; set; }
    }
}
