using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.Shell;

namespace UwpEssentials
{
    [PackageRegistration(UseManagedResourcesOnly = true, AllowsBackgroundLoading = true)]
    [InstalledProductRegistration("#110", "#112", "1.5", IconResourceID = 400)] // Info on this package for Help/About
    [Guid(VSPackage.PackageGuidString)]
    public sealed class VSPackage : AsyncPackage
    {
        public const string PackageGuidString = "7a3e22ff-7f70-4605-8b6c-ae5d939f90d1";
    }
}
