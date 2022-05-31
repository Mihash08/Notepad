using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using Microsoft.CodeAnalysis.CSharp;
using System.Collections.Generic;
using System.Text;

namespace Notepad_
{
    class RunTimeCompiler
    {
        public static string[] ErrorDisplay(string sourceCode)
        {
            var codeString = SourceText.From(sourceCode);
            var options = CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp7_3);
            var parsedSyntaxTree = SyntaxFactory.ParseSyntaxTree(codeString, options);
            var references = new MetadataReference[]
            {
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(System.Runtime.AssemblyTargetedPatchBandAttribute).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo).Assembly.Location),
            };
            CSharpCompilation compilation = CSharpCompilation.Create("Hello.dll",
                new[] { parsedSyntaxTree },
                references: references,
                options: new CSharpCompilationOptions(OutputKind.ConsoleApplication,
                optimizationLevel: OptimizationLevel.Release,
                assemblyIdentityComparer: DesktopAssemblyIdentityComparer.Default));
            var result = compilation.Emit("Hello.dll");
            List<string> output = new List<string>();
            foreach (var i in result.Diagnostics)
            {
                output.Add(i.ToString());
            }
            return output.ToArray();
        }
    }
}
