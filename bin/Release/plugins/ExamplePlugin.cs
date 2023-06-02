// WARNING: DO NOT EDIT THE NAMESPACE OR THE PluginInit name this will not load on another pc!
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
