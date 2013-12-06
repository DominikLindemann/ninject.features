﻿//-------------------------------------------------------------------------------
// <copyright file="CommandLineArguments.cs" company="Appccelerate">
//   Copyright (c) 2008-2013
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//-------------------------------------------------------------------------------

namespace Ninject.FeatureDumper
{
    using Appccelerate.IO;

    public class CommandLineArguments
    {
        public static CommandLineArguments CreateSuccessful(
            AbsoluteFilePath outputPath,
            AbsoluteFolderPath assemblyFolder)
        {
            return new CommandLineArguments(outputPath, assemblyFolder, true);
        }

        public static CommandLineArguments CreateFailed()
        {
            return new CommandLineArguments(null, null, false);
        }

        private CommandLineArguments(AbsoluteFilePath outputPath, AbsoluteFolderPath assemblyFolder, bool successful)
        {
            this.OutputPath = outputPath;
            this.AssemblyFolder = assemblyFolder;
            this.Successful = successful;
        }

        public AbsoluteFilePath OutputPath { get; private set; }
            
        public AbsoluteFolderPath AssemblyFolder { get; private set; }

        public bool Successful { get; private set; }
    }
}