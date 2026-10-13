using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Reporting
{
    public class PccExcelReportApiRequestModel
    {
        public bool ShowAllBreakdownsInOneWorksheet { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PccPeriodSelectionType? PeriodSelectionType { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PayScheduleId { get; set; }
        public int? PayRunId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PccServicePeriodType? ServicePeriodType { get; set; }
        public DateTime? ServicePeriodStartDate { get; set; }
        public DateTime? ServicePeriodEndDate { get; set; }
        public int? EmployingEntityId { get; set; }
        public int? LocationId { get; set; }
        public int? EmployeeId { get; set; }
        public bool NegativeVariancesOnly { get; set; }
    }
}
