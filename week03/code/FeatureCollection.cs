using System.Data.Common;
using Microsoft.VisualBasic;

public class FeatureCollection
{
    public string Type { get; set; }
    public Metadata Metadata { get; set; }
    public List<double> Bbox { get; set; }
    public List<Features> Features { get; set; }
}

public class Metadata
{
    public long Generated { get; set; }
    public string Url { get; set; }
    public string Title { get; set; }

    public string Api { get; set; }
    public int Count { get; set; }
}
public class Features
{
    public string Type { get; set; }
    public Properties Properties { get; set; }
    public Geometry Geometry { get; set; }
    public string Id { get; set; }
}
public class Properties
{
    public decimal Mag { get; set; } // Earthquake magnitude
    public string Place { get; set; } // Location description
    public long Time { get; set; } // Time of the earthquake (milliseconds since epoch)
    public long Updated { get; set; } // Time the data was last updated (milliseconds since epoch)
    public int Tz { get; set; } // Timezone offset
    public string Url { get; set; } // URL for more details
    public string Detail { get; set; } // Additional details
    public int Felt { get; set; } // Number of people who reported feeling the earthquake
    public decimal Cdi { get; set; } // Mercalli intensity scale
    public decimal Mmi { get; set; } // Modified Mercalli intensity scale
    public string Alert { get; set; } // Tsunami alert level
    public string Status { get; set; } // Event status
    public int Tsunami { get; set; } // Tsunami threat level
    public int Sig { get; set; } // Significance ranking
    public string Net { get; set; } // Network that detected the earthquake
    public string Code { get; set; } // Event identifier code
    public string Ids { get; set; } // Comma-separated list of event identifiers
    public string Sources { get; set; } // Comma-separated list of data sources
    public string Types { get; set; } // Comma-separated list of event types
    public int Nst { get; set; } // Number of stations used to locate the earthquake
    public decimal Dmin { get; set; } // Minimum distance from an earthquake station (kilometers)
    public decimal Rms { get; set; } // Root mean square of travel-time residuals
    public decimal Gap { get; set; } // Largest azimuthal gap in station coverage (degrees)
    public string MagType { get; set; } // Type of magnitude measurement
    public string Type { get; set; } // Event type
    public string Title { get; set; }
}
public class Geometry
{
    public string Type { get; set; }
    public List<double> Coordinates { get; set; }
}