// Struct to hold version numbers

public struct Version
{
    /// <summary>Version zero, 0.0.0</summary>
    public static Version zero = new Version(0, 0, 0);

    public short major { get; private set; }
    public short minor { get; private set; }
    public short subMinor { get; private set; }

    ///<summary>Create a new version object</summary>
    ///<param name="major">Major version number</param>
    ///<param name="minor">Minor version number</param>
    ///<param name="subMinor">Sub-minor version number</param>
    public Version(short _major, short _minor, short _subMinor)
    {
        major = _major;
        minor = _minor;
        subMinor = _subMinor;
    }

    ///<summary>Create a new version object</summary>
    ///<param name="_version">String version number</param>
    public Version(string _version)
    {
        string[] versionStrings = _version.Split('.');
        if (versionStrings.Length != 3)
        {
            major = 0;
            minor = 0;
            subMinor = 0;
            return;
        }
        major = short.Parse(versionStrings[0]);
        minor = short.Parse(versionStrings[1]);
        subMinor = short.Parse(versionStrings[2]);
    }

    ///<summary>Compare if the other version is different to this version</summary>
    ///<param name="other">Version to compare to</param>
    public bool IsDifferentThan(Version _otherVersion)
    {
        if (major != _otherVersion.major)
        {
            return true;
        }
        else
        {
            if (minor != _otherVersion.minor)
            {
                return true;
            }
            else
            {
                if (subMinor != _otherVersion.subMinor)
                {
                    return true;
                }
            }
        }
        return false;
    }

    ///<summary>Returns a string representation of the version</summary>
    public override string ToString()
    {
        return $"{major}.{minor}.{subMinor}";
    }
}
