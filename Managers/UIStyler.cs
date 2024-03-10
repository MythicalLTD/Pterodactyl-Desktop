using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace Pterodactyl.Managers
{
    public class UIStyler
    {
        private Dictionary<string, Dictionary<string, string>> styles;

        public UIStyler()
        {
            styles = new Dictionary<string, Dictionary<string, string>>();
        }

        public void LoadFromYaml(string yamlFilePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(yamlFilePath))
                {
                    var deserializer = new DeserializerBuilder().Build();
                    styles = deserializer.Deserialize<Dictionary<string, Dictionary<string, string>>>(reader);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(LogType.Error, "[UI] Failed to apply UI modification: \n" + ex.ToString());
            }
        }

        public void ApplyStyles(Control control)
        {
            try
            {
                string controlName = control.Name;
                if (styles.ContainsKey(controlName))
                {
                    Dictionary<string, string> controlStyles = styles[controlName];

                    foreach (KeyValuePair<string, string> style in controlStyles)
                    {
                        ApplyStyle(control, style.Key, style.Value);
                    }
                }

                foreach (Control childControl in control.Controls)
                {
                    ApplyStyles(childControl);
                }
            }
            catch (Exception ex)
            {
                Program.logger.Log(LogType.Error, "[UI] Failed to apply UI modification: \n" + ex.ToString());

            }
        }

        private void ApplyStyle(Control control, string property, string value)
        {
            PropertyInfo prop = control.GetType().GetProperty(property);
            if (prop != null)
            {
                if (prop.PropertyType == typeof(Color))
                {
                    prop.SetValue(control, Color.FromName(value));
                }
                else if (prop.PropertyType == typeof(Size))
                {
                    string[] sizeParts = value.Split(',');
                    if (sizeParts.Length == 2 && int.TryParse(sizeParts[0], out int width) && int.TryParse(sizeParts[1], out int height))
                    {
                        prop.SetValue(control, new Size(width, height));
                    }
                }
                else if (prop.PropertyType == typeof(Point))
                {
                    string[] pointParts = value.Split(',');
                    if (pointParts.Length == 2 && int.TryParse(pointParts[0], out int x) && int.TryParse(pointParts[1], out int y))
                    {
                        prop.SetValue(control, new Point(x, y));
                    }
                }
                else if (prop.PropertyType == typeof(DockStyle))
                {
                    DockStyle dockStyle;
                    if (Enum.TryParse(value, out dockStyle))
                    {
                        prop.SetValue(control, dockStyle);
                    }
                }
                else if (prop.PropertyType == typeof(bool))
                {
                    bool boolValue;
                    if (bool.TryParse(value, out boolValue))
                    {
                        prop.SetValue(control, boolValue);
                    }
                }
                else
                {
                    prop.SetValue(control, Convert.ChangeType(value, prop.PropertyType));
                }
            }
        }
    }
}