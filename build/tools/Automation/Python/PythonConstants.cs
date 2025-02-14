﻿// --------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
// --------------------------------------------------------------------------------------------
using System.Collections.Generic;

namespace Oryx.Microsoft.Automation.Python
{
    public class PythonConstants
    {
        public const string ConstantsYaml = "constants.yaml";
        public const string PythonName = "python";
        public const string VersionsToBuildTxt = "versionsToBuild.txt";
        public const string ConstantsYamlPythonKey = "python-versions";
        public const string PythonBlockedVersionsEnvVar = "PYTHON_BLOCKED_VERSIONS_ARRAY";
        public const string PythonMinReleaseVersionEnvVar = "PYTHON_MIN_RELEASE_VERSION";
        public const string PythonMaxReleaseVersionEnvVar = "PYTHON_MAX_RELEASE_VERSION";
        public const string PythonReleaseUrl = "https://www.python.org/api/v2/downloads/release/";
        public const string PythonSuffixUrl = "/python?restype=container&comp=list&include=metadata";
        public static readonly Dictionary<string, string> VersionGpgKeys = new Dictionary<string, string>()
        {
            { "3.10", "A035C8C19219BA821ECEA86B64E628F8D684696D" },
            { "3.11", "A035C8C19219BA821ECEA86B64E628F8D684696D" },
        };
    }
}
