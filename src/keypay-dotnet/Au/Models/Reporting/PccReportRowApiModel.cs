using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PccReportRowApiModel
    {
        public int? PayRunId { get; set; }
        public DateTime? PayPeriodStarting { get; set; }
        public DateTime? PayPeriodEnding { get; set; }
        public DateTime? DatePaid { get; set; }
        public decimal PaidEarnings { get; set; }
        public decimal ComparisonEarnings { get; set; }
        public decimal Variance { get; set; }
        public decimal VariancePct { get; set; }
        public decimal TotalHours { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal PenaltyHours { get; set; }
    }
}
