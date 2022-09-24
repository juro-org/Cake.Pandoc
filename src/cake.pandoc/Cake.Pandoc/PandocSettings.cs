/*
 * MIT License
 *
 * Copyright (c) 2020 Jürgen Rosenthal-Buroh
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

/* Hint Exclude from DupFinder because of:
 * Duplicate Located with a cost of 75, across 2 Fragments
 * File Name: src\cake.pandoc\Cake.Pandoc\PandocSettings.cs Line Numbers: 198 - 200
 * File Name: src\cake.pandoc\Cake.Pandoc\PandocSettings.cs Line Numbers: 206 - 208
 *
 * NTH: MakeAbsolute in Path [BaseClass of DirectoryPath and FilePath] in Cake.Core
*/

namespace Cake.Pandoc
{
    using Cake.Core;
    using Cake.Core.IO;
    using Cake.Core.Tooling;

    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.Serialization;

    public sealed partial class PandocSettings : ToolSettings
    {
        public PandocSettings()
        {
            this.Files = new FilePathCollection();
        }

        public FilePathCollection Files { get; }

        #region General options

       

        #endregion General options

        public void Evaluate(ProcessArgumentBuilder builder, ICakeEnvironment environment)
        {
            this.GetType()
                .GetProperties()
                .ToList()
                .ForEach(p =>
                {
                    var attr = p.GetCustomAttribute(typeof(DataMemberAttribute)) as DataMemberAttribute;
                    if (attr == null)
                    {
                        return;
                    }

                    if (p.PropertyType == typeof(string))
                    {
                        var value = p.GetValue(this) as string;
                        if (string.IsNullOrWhiteSpace(value)) { return; }

                        builder.Append(string.Format("--{0}={1}", attr.Name, value));
                        return;
                    }

                    if (p.PropertyType == typeof(bool))
                    {
                        var value = p.GetValue(this) as bool?;
                        if (!value.HasValue || !value.Value) { return; }

                        builder.Append(string.Format("--{0}", attr.Name));
                        return;
                    }

                    if (p.PropertyType.BaseType == typeof(Enums.EnumBaseType))
                    {
                        var value = p.GetValue(this) as Enums.EnumBaseType;
                        if (value == null) { return; }

                        builder.Append(string.Format("--{0}={1}", attr.Name, value.ToString()));
                        return;
                    }

                    if (p.PropertyType == typeof(FilePath))
                    {
                        var value = p.GetValue(this) as FilePath;
                        if (value == null) { return; }
                        builder.Append(string.Format("--{0}={1}", attr.Name, value.MakeAbsolute(environment).FullPath.Quote()));
                        return;
                    }

                    if (p.PropertyType == typeof(DirectoryPath))
                    {
                        var value = p.GetValue(this) as DirectoryPath;
                        if (value == null) { return; }
                        builder.Append(string.Format("--{0}={1}", attr.Name, value.MakeAbsolute(environment).FullPath.Quote()));
                        return;
                    }

                    throw new ArgumentOutOfRangeException($"Unknown PropertyType {p.PropertyType} of property {p.Name}", new NotImplementedException());
                });

            this.Files
                .Select(file => file.MakeAbsolute(environment).FullPath.Quote())
                .ToList()
                .ForEach(file => builder.Append(file));
        }
    }
}
