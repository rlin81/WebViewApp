﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;
namespace WebviewApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            String userDataFolder = @"C:\Users\rlin8\Desktop" + @"NETWebView2UserDataTest";
            CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions();
            CoreWebView2Environment env = CoreWebView2Environment.CreateAsync("", userDataFolder, options).GetAwaiter().GetResult();
            InitializeComponent();
            webView.EnsureCoreWebView2Async(env);
           // webView.CoreWebView2Ready += WebView_CoreWebView2Ready;
        }
        void ButtonGo_Click(object sender, RoutedEventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                webView.CoreWebView2.Navigate(addressBar.Text);
            }
        }
    }
}

