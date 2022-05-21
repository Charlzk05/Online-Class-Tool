using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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
using CefSharp;
using CefSharp.Wpf;
using Microsoft.Win32;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OnlineClassTool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText("./bin/DefaultSettings.json"));

                string defaultSES = (jsonFile["Settings"]["DefaultSearchEngine"]["engine"]);
                string defaultWQS = (jsonFile["Settings"]["DefaultQuestionsWebsite"]["website"]);
                string topMostS = (jsonFile["Settings"]["TopMost"]);

                TopMostSettings.Text = topMostS;
                if (TopMostSettings.Text == "true")
                {
                    c_TopMost.IsChecked = true;
                }
                else if (TopMostSettings.Text == "false")
                {
                    c_TopMost.IsChecked = false;
                }
                else
                {
                    MessageBox.Show(this, "Invalid TopMost setting\nPlease check it on /bin/DefaultSettings.json", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    this.Close();
                }

                WebsiteSettings.Text = defaultWQS;
                if (WebsiteSettings.Text == "brainly")
                {
                    C_BrainlyPH.IsChecked = true;
                }
                else if (WebsiteSettings.Text == "quora")
                {
                    C_Quora.IsChecked = true;
                }
                else if (WebsiteSettings.Text == "scholar google")
                {
                    C_SCHgoogle.IsChecked = true;
                }
                else
                {
                    MessageBox.Show(this, "Invalid default questions websites\nPlease check it on /bin/DefaultSettings.json", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    this.Close();
                }

                SearchEngineSettings.Text = defaultSES;
                if (SearchEngineSettings.Text == "google")
                {
                    m_browser.Load("https://google.com");
                }
                else if (SearchEngineSettings.Text == "bing")
                {
                    m_browser.Load("https://google.com");
                }
                else if (SearchEngineSettings.Text == "yahoo")
                {
                    m_browser.Load("https://google.com");
                }
                else if (SearchEngineSettings.Text == "yandex")
                {
                    m_browser.Load("https://google.com");
                }
                else if (SearchEngineSettings.Text == "ask")
                {
                    m_browser.Load("https://google.com");
                }
                else
                {
                    MessageBox.Show(this, "Invalid default search engine\nPlease check it on /bin/DefaultSettings.json", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show(this, "Something went wrong\nPlease check your internet", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                this.Close();
            }
        }

        private void btn_Ask_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                if (L_TextBox.Text == "")
                {
                    MessageBox.Show(this, "Please insert a text", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (C_BrainlyPH.IsChecked == true)
                    {
                        mitm_Using.Header = "Currently Using: Brainly";
            
                        ChromeDriverService webDriver1 = ChromeDriverService.CreateDefaultService();
                        webDriver1.HideCommandPromptWindow = true;
                        IWebDriver webDriver = new ChromeDriver(webDriver1);
            
                        By BrainlySearchb = By.Name("q");
                        By BrainlySbtn = By.ClassName("search__icon--PKLvc");
            
                        webDriver.Manage().Window.Maximize();
                        webDriver.Navigate().GoToUrl("https://brainly.ph/");
            
                        webDriver.FindElement(BrainlySearchb).SendKeys(L_TextBox.Text);
                        webDriver.FindElement(BrainlySbtn).Click();
                    }
                    else if (C_Quora.IsChecked == true)
                    {
                        mitm_Using.Header = "Currently Using: Quora";
            
                        ChromeDriverService webDriver1 = ChromeDriverService.CreateDefaultService();
                        webDriver1.HideCommandPromptWindow = true;
                        IWebDriver webDriver = new ChromeDriver(webDriver1);
            
                        string URLencode = Uri.EscapeDataString("https://quora.com/search?q=" + L_TextBox.Text);
                        string URLdecode = Uri.UnescapeDataString(URLencode);
            
                        webDriver.Manage().Window.Maximize();
                        webDriver.Navigate().GoToUrl(URLdecode);
                    }
                    else if (C_SCHgoogle.IsChecked == true)
                    {
                        mitm_Using.Header = "Currently using: Scholar Google";

                        ChromeDriverService webDriver1 = ChromeDriverService.CreateDefaultService();
                        webDriver1.HideCommandPromptWindow = true;
                        IWebDriver webDriver = new ChromeDriver(webDriver1);

                        By schGoogleTB = By.ClassName("gs_in_txt gs_in_ac");
                        By schGoogleSbtn = By.Name("btnG");

                        webDriver.Manage().Window.Maximize();
                        webDriver.Navigate().GoToUrl("https://scholar.google.com/");

                        webDriver.FindElement(schGoogleTB).SendKeys(L_TextBox.Text);
                        webDriver.FindElement(schGoogleSbtn).Click();
                    }
                    else
                    {
                        IWebDriver webDriver = new ChromeDriver();
            
                        MessageBox.Show(this, "Please select a website", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        webDriver.Quit();
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, "Something went wrong", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void c_Google_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Load("https://google.com/");
            TBWebsiteChecker.Text = "google";
        }

        private void c_Bing_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Load("https://bing.com/");
            TBWebsiteChecker.Text = "bing";
        }

        private void c_Yahoo_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Load("https://yahoo.com/");
            TBWebsiteChecker.Text = "yahoo";
        }

        private void c_Yandex_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Load("https://yandex.com/");
            TBWebsiteChecker.Text = "yandex";
        }

        private void c_Ask_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Load("https://ask.com/");
            TBWebsiteChecker.Text = "ask";
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Back();
        }

        private void btn_Front_Click(object sender, RoutedEventArgs e)
        {
            m_browser.Forward();
        }

        private void Window_Closed(object sender, EventArgs e)
        {

        }

        private void c_TopMost_Checked(object sender, RoutedEventArgs e)
        {
            this.Topmost = true;
        }

        private void c_TopMost_Unchecked(object sender, RoutedEventArgs e)
        {
            this.Topmost = false;
        }

        private void C_BrainlyPH_Checked(object sender, RoutedEventArgs e)
        {
            if (C_Quora.IsChecked == true)
            {
                C_Quora.IsChecked = false;
            }
            else if (C_SCHgoogle.IsChecked == true)
            {
                C_SCHgoogle.IsChecked = false;
            }
            else
            {

            }

            C_Quora.IsChecked = false;
            mitm_Using.Header = "Currently Using: Brainly";
        }

        private void C_Quora_Checked(object sender, RoutedEventArgs e)
        {
            if (C_BrainlyPH.IsChecked == true)
            {
                C_BrainlyPH.IsChecked = false;
            }
            else if (C_SCHgoogle.IsChecked == true)
            {
                C_SCHgoogle.IsChecked = false;
            }
            else
            {

            }

            mitm_Using.Header = "Currently Using: Quora";
        }

        private void C_SCHgoogle_Checked(object sender, RoutedEventArgs e)
        {
            if (C_BrainlyPH.IsChecked == true)
            {
                C_BrainlyPH.IsChecked = false;
            }
            else if (C_Quora.IsChecked == true)
            {
                C_Quora.IsChecked = false;
            }
            else
            {

            }

            mitm_Using.Header = "Currently Using: Google Scholar";
        }

        private void C_BrainlyPH_Unchecked(object sender, RoutedEventArgs e)
        {
            mitm_Using.Header = "Currently Using: None";
        }

        private void C_Quora_Unchecked(object sender, RoutedEventArgs e)
        {
            mitm_Using.Header = "Currently Using: None";
        }

        private void C_SCHgoogle_Unchecked(object sender, RoutedEventArgs e)
        {
            mitm_Using.Header = "Currently Using: None";
        }

        private void c_TextEditor_Click(object sender, RoutedEventArgs e)
        {
            TextEditor textEditor = new TextEditor();

            textEditor.Show();
        }
    }
}
