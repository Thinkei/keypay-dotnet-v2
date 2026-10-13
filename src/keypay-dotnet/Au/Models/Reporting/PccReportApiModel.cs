using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PccReportApiModel
    {
        public IList<PccLocationGroupApiModel> LocationGroups { get; set; }
        public PccReportTotalRowApiModel OverallTotals { get; set; }
        public bool HasUnfinalisedPayRuns { get; set; }
        public bool HasUncostedTimesheets { get; set; }
    }
}
