namespace VersionAttribute
{
    using System;

    [AttributeUsage(AttributeTargets.Class | 
                    AttributeTargets.Struct |
                    AttributeTargets.Interface |
                    AttributeTargets.Enum | 
                    AttributeTargets.Method)]

    class Attributes : Attribute
    {
        public string Version { get; set; }

        public Attributes(string version)
        {
            this.Version = version;
        }

    }
}
