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
                IEnumerable<TypeInfo> types = Assembly.LoadFrom(file).DefinedTypes;
                foreach (TypeInfo type in types)
                {
                }

            }
            // grab all the types from the dlls
            // create a PluginButton for each of the dlls and add them to the listing panel
            // for each PluginButton, PluginButton.OpenPlugin += executionPanel.switchPlugin
            // layout and display all of the panels
        }
    }
}
