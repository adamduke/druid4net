namespace Raygun.Druid4Net
{
  public class TimeseriesContextSpec : ContextSpec
  {
    /// <summary>
    /// Disable timeseries zero-filling behavior, so only buckets with results will be returned.
    /// </summary>
    /// <remarks>default is false</remarks>
    public bool? SkipEmptyBuckets { get; set; }

    /// <summary>
    /// Whether to include an extra "grand totals" row as the last row of a timeseries result set.
    /// </summary>
    /// <remarks>default is false</remarks>
    public bool? GrandTotal { get; set; }
  }
}