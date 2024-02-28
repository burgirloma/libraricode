[TypeConverter(typeof(TypeConverter<Configuration>))]
public class Configuration : Enumeration
{
    public static Configuration Debug = new Configuration { Value = nameof(Debug) };
    public static Configuration Release = new Configuration { Value = nameof(Release) };

    public static implicit operator string(Configuration configuration)
    {
        return configuration.Value;
    }
}
using System;
using System.ComponentModel;
using System.Linq;
using Nuke.Common.Tooling;

    public ReleaseNotes(SemVersion semVersion, IEnumerable<string> notes, string rawVersionLine)
        : this(
            semVersion?.AssemblyVersion ?? throw new ArgumentNullException(nameof(semVersion)),
            semVersion,
            notes,
            rawVersionLine)
    {
    }
  public ReleaseNotes(Version version, IEnumerable<string> notes, string rawVersionLine)
        : this(
            version ?? throw new ArgumentNullException(nameof(version)),
            new SemVersion(version.Major, version.Minor, version.Build),
            notes,
            rawVersionLine)
    {
    }
