using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PayConditionsComparisonReportQueryModel
    {
        public PccPeriodSelectionType? PeriodSelectionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PayScheduleId { get; set; }
        public int? PayRunId { get; set; }
        public PccServicePeriodType? ServicePeriodType { get; set; }
        public DateTime? ServicePeriodStartDate { get; set; }
        public DateTime? ServicePeriodEndDate { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public bool NegativeVariancesOnly { get; set; }
    }
}
