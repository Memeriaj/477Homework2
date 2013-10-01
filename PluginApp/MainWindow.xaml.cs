using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Forms;

namespace PluginApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Select the folder that contains your plugins.";
            folderBrowser.ShowDialog();
            string currentDirectory = folderBrowser.SelectedPath;
            string[] dlls = Directory.GetFiles(currentDirectory, "*.dll");
            foreach (string file in dlls)
            {
                Type[] types = Assembly.LoadFrom(file).GetTypes();
                foreach (Type type in types)
                {
                    if (type.IsSubclassOf(typeof(AbstractPlugin)))
                    {
                        AbstractPlugin pluginToAdd = (AbstractPlugin)Activator.CreateInstance(type);
                        executionPanel.addPlugin(pluginToAdd);
                        pluginToAdd.StatusPosted += statusPanel.postStatus;
                        PluginButton newPluginButton = listingPanel.addPlugin(type);
                        if (null != newPluginButton)
                        {
                            newPluginButton.OpenPlugin += executionPanel.switchPlugin;
                        }
                    }
                }
            }
        }
    }
}
