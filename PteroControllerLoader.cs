//
// PteroController | PluginLoader  
//
// HI THERE THANKS FOR CHECKING THIS FILE OUT!
// IF YOU ARE LOOKING FOR THE DEAFULT CODE TO MAKE A PLUGIN HERE YOU GO:
/*
using System;

namespace PteroControllerPlugin
{
    public class PluginInit
    {
        private string _name = "ExamplePlugin";
        private string _version = "1.0.0";
        private string _author = "NaysKutzu";

        public string Name
        {
            get { return _name; }
        }

        public string Version
        {
            get { return _version; }
        }

        public string Author
        {
            get { return _author; }
        }

        public PluginInit()
        {
            sayhello();
        }

        private void sayhello()
        {
            Console.WriteLine("Hello, World from plugin!");
        }
    }
}
*/
// WARNING: DO NOT EDIT THE NAMESPACE OR THE PluginInit name this will not load on another pc!
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using Microsoft.CSharp;

namespace PteroController
{
    public class PluginInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
    }

    public class PteroControllerLoader
    {
        private const string FolderPath = "plugins";

        public void CheckAndCreatePluginFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine("Plugin folder created successfully.");
            }
        }

        public void LoadPlugins()
        {
            CheckAndCreatePluginFolder();

            string[] files = Directory.GetFiles(FolderPath, "*.cs");
            foreach (string file in files)
            {
                string fileContent = File.ReadAllText(file);

                CSharpCodeProvider codeProvider = new CSharpCodeProvider();
                CompilerParameters compilerParameters = new CompilerParameters();
                compilerParameters.GenerateInMemory = true;

                CompilerResults compilerResults = codeProvider.CompileAssemblyFromSource(compilerParameters, fileContent);
                if (compilerResults.Errors.HasErrors)
                {
                    foreach (CompilerError error in compilerResults.Errors)
                    {
                        Console.WriteLine($"Error in file {Path.GetFileName(file)} at line {error.Line}: {error.ErrorText}");
                    }
                }
                else
                {
                    Console.WriteLine($"File {Path.GetFileName(file)} compiled successfully.");
                    Assembly compiledAssembly = compilerResults.CompiledAssembly;
                    Type pluginType = compiledAssembly.GetType("PteroControllerPlugin.PluginInit");
                    object pluginInstance = Activator.CreateInstance(pluginType);
                    PluginInfo pluginInfo = GetPluginInfo(pluginInstance);
                    Console.WriteLine($"Loaded plugin: {pluginInfo.Name} (Version: {pluginInfo.Version}, Author: {pluginInfo.Author})");
                }
            }
        }

        private PluginInfo GetPluginInfo(object pluginInstance)
        {
            Type pluginType = pluginInstance.GetType();

            PropertyInfo nameProperty = pluginType.GetProperty("Name");
            PropertyInfo versionProperty = pluginType.GetProperty("Version");
            PropertyInfo authorProperty = pluginType.GetProperty("Author");

            PluginInfo pluginInfo = new PluginInfo
            {
                Name = nameProperty?.GetValue(pluginInstance)?.ToString(),
                Version = versionProperty?.GetValue(pluginInstance)?.ToString(),
                Author = authorProperty?.GetValue(pluginInstance)?.ToString()
            };

            return pluginInfo;
        }
    }
}
