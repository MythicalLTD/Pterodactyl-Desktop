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
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace PteroController
{
    public class PluginInfo
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Author { get; set; }
    }

    public class PluginLoader
    {
        private const string FolderPath = "plugins";

        public void CheckAndCreatePluginFolder()
        {
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
                Console.WriteLine("[{0:HH:mm:ss}] (PluginLoader) Plugin folder created successfully.", DateTime.Now);
                CreatePluginDefault();
            }
        }

        private void CreatePluginDefault()
        {
            string folderPath = Path.Combine(Application.StartupPath, FolderPath);
            string filePath = Path.Combine(folderPath, "ExamplePlugin.cs");
            string code = @"
using System;

namespace PteroControllerPlugin
{
    public class PluginInit
    {
        private string _name = ""ExamplePlugin"";
        private string _version = ""1.0.0"";
        private string _author = ""NaysKutzu"";

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
            Console.WriteLine(""Hello, World from plugin!"");
        }
    }
}
// WARNING: DO NOT EDIT THE NAMESPACE OR THE PluginInit name this will not load on another pc!
";
            if (File.Exists(filePath))
            {
                return;
            }

            try
            {
                Directory.CreateDirectory(folderPath);
                File.WriteAllText(filePath, code);
                Console.WriteLine("[{0:HH:mm:ss}] (PluginLoader) Default plugin created successfully.", DateTime.Now);
            }
            catch (Exception e)
            {
                Console.WriteLine("[{0:HH:mm:ss}] (PluginLoader) An error occurred: {1}", DateTime.Now, e.Message);
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
                        Console.WriteLine($"[{{0:HH:mm:ss}}] (PluginLoader) Error in file {Path.GetFileName(file)} at line {error.Line}: {error.ErrorText}", DateTime.Now);
                    }
                }
                else
                {
                    Console.WriteLine($"[{{0:HH:mm:ss}}] (PluginLoader) File {Path.GetFileName(file)} compiled successfully.", DateTime.Now);
                    Assembly compiledAssembly = compilerResults.CompiledAssembly;
                    Type pluginType = compiledAssembly.GetType("PteroControllerPlugin.PluginInit");
                    object pluginInstance = Activator.CreateInstance(pluginType);
                    PluginInfo pluginInfo = GetPluginInfo(pluginInstance);
                    Console.WriteLine($"[{0:HH:mm:ss}] (PluginLoader) Loaded plugin: {pluginInfo.Name} (Version: {pluginInfo.Version}, Author: {pluginInfo.Author})",DateTime.Now);
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
