﻿using System;
using Mono.Cecil;

namespace SingleExecutableGenerator
{
    static class Helpers
    {
        public static bool IsDotNetDll(string path)
        {
            try
            {
                AssemblyDefinition.ReadAssembly(path);
                return true;
            }
            catch (BadImageFormatException)
            {
                return false;
            }
        }
    }
}
