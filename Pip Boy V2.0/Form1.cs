using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Pip_Boy_V2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpServer.start(this);
        }

        /// ----------------------------------------------------------------------------------------------------
        /// Peripherie
        /// ----------------------------------------------------------------------------------------------------

        public static bool STATbool = false;
        public static bool DATAbool = false;

        private bool normalMode = true;

        public void Peripherie(string button)
        {
            switch (button)
            {
                case "mode":
                    normalMode = !normalMode;
                    break;

                case "stat":
                    if (this.normalMode)
                    {
                        mainTabControl.SelectedTab = mainTabControl.TabPages[0];
                    } else
                    {
                        SendKeys.Send("{TAB}");
                    }
                    break;

                case "data":
                    if (this.normalMode)
                    {
                        mainTabControl.SelectedTab = mainTabControl.TabPages[1];
                    } else
                    {
                        SendKeys.Send("{ENTER}");
                    }
                    break;

                case "radio":
                    if (normalMode)
                    {
                        mainTabControl.SelectedTab = mainTabControl.TabPages[2];
                    } else
                    {
                        SendKeys.Send("+{TAB}");
                    }
                    break;
                case "rotaryRight":
                case "rotaryLeft":
                    Dictionary<int, TabControl> myDict = new Dictionary<int, TabControl>();
                    myDict.Add(0, subTabControlSTAT);
                    myDict.Add(1, subTabControlDATA);
                    
                    int mainTabIndex = mainTabControl.TabPages.IndexOf(mainTabControl.SelectedTab);

                    if (mainTabIndex != 2)
                    {
                        TabControl subTabControl = myDict[mainTabIndex];
                        int subTabIndex = subTabControl.TabPages.IndexOf(subTabControl.SelectedTab);
                        subTabIndex += (button == "rotaryLeft" ? -1 : 1);
                        if (subTabIndex > subTabControl.TabPages.Count - 1) subTabIndex = 0;
                        if (subTabIndex < 0) subTabIndex = subTabControl.TabPages.Count - 1;
                        subTabControl.SelectedTab = subTabControl.TabPages[subTabIndex];
                    }
                    break;
            }
        }

        /// ----------------------------------------------------------------------------------------------------
        /// Terminal
        /// ----------------------------------------------------------------------------------------------------

        public static string OriginalInputText = "";
        public static string InputText = "";
        public static string GeneratedText = "";
        public static string OldText = "";
        public bool TerminalInputBool = false;


        private void Terminalinput_TextChanged(object sender, EventArgs e)
        {
            OriginalInputText = Terminalinput.Text;
            InputText = OriginalInputText.ToLower();
            TerminalInputBool = true;
        }
        private void Terminalinput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char) Keys.Enter)
            {
                TerminalinputEnter_Click(new object(), new EventArgs());
            }
        }

        private void TerminalinputEnter_Click(object sender, EventArgs e)
        {
            if (TerminalInputBool == true)
            {
                OldText = Terminaloutput.Text;
                Task.Run(new Action(TerminalOutput));
                Thread.Sleep(200);

                Terminaloutput.Text = OldText + "\n" + "\n" + GeneratedText;

                TerminalInputBool = false;
            }
        }

        public void TerminalOutput()
        {
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            myDict.Add("wetter", "Sonnig 34°C, 94,1°F, geringe Mengen radioaktiver Regen im Osten");
            myDict.Add("weather", "Sunny 34°C, 94,1°F, low amounts of Fallout in the East");
            myDict.Add("signal", "no signal available");
            myDict.Add("strahlung", "0,48 µSv/h");
            myDict.Add("radiation", "0,48 µSv/h");
            myDict.Add("atmosphäre", "Temperatur: 34,5°C, 94,1°F, 307,65K" + "\n" + "Luftdruck: 1029 hPa, 1,029 bar" + "\n" + "Luftfeuchtigkeit: 58%" + "\n" + "Stickstoff: 78,09" + "\n" + "Sauerstoff: 19,8%");
            myDict.Add("atmosphere", "Temperature: 34°C, 94,1°F, 307,65K" + "\n" + "Pressure: 1029 hPa, 1,029 bar" + "\n" + "Humidity: 58%" + "\n" + "Nitrogen: 78,09" + "\n" + "Oxygen: 19,8%");

            bool found = false;
            foreach( KeyValuePair<string, string> keyValue in myDict)
            {
                if (!found)
                {
                    if (InputText.Contains(keyValue.Key))
                    {
                        GeneratedText = keyValue.Value;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                TextGenerator();
            }
        }

        public void TextGenerator()
        {
            string[] words = { "the", "be", "to", "of", "and", "a", "in", "that", "have", "I", "it", "for", "not", "on", "with", "he", "as", "you", "do", "at", "this", "but", "his", "by", "form", "they", "we", "say", "her", "she", "or", "an", "will", "my", "one", "all", "would", "there", "their", "what", "so", "up", "out", "if", "about", "who", "get", "which", "go", "me", "when", "make", "can", "like", "time", "no", "just", "him", "know", "take", "people", "into", "year", "your", "good", "some", "could", "them", "see", "other", "than", "then", "now", "look", "only", "come", "its", "over", "think", "also", "back", "after", "use", "two", "how", "our", "work", "first", "well", "way", "even", "new", "want", "because", "any", "these", "give", "day", "most", "us" };

            Random randomnum1 = new Random();

            int wordCount = randomnum1.Next(1, 25);
            StringBuilder builder = new StringBuilder();
            Random random1 = new Random();

            for (int i = 0; i < wordCount; i++)
            {
                builder.Append(words[random1.Next(words.Length)]).Append(" ");
            }

            string sentence = builder.ToString().Trim() + ". ";

            sentence = char.ToUpper(sentence[0]) + sentence.Substring(1);

            builder = new StringBuilder();
            builder.Append(sentence);

            builder.ToString();
            GeneratedText = builder.ToString();
        }

        /// ----------------------------------------------------------------------------------------------------
        /// Inventar
        /// ----------------------------------------------------------------------------------------------------

        public static string InventoryInputText = "new item";
        public bool InventoryInputBool = false;
        public string SelectedText = "";

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (InventoryList.Items.Count == 0) return;
            int index = 0;
            if (InventoryList.SelectedItem != null)
            {
                string currentItem = InventoryList.SelectedItem.ToString();
                index = InventoryList.FindString(currentItem);
            }
            index--;
            if (index < 0)
            {
                index = InventoryList.Items.Count - 1;
            }
            InventoryList.SetSelected(index, true);
            SelectedText = InventoryList.SelectedItem.ToString();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (InventoryList.Items.Count == 0) return;
            int index = 0;
            if (InventoryList.SelectedItem != null)
            {
                string currentItem = InventoryList.SelectedItem.ToString();
                index = InventoryList.FindString(currentItem);
            }
            index++;
            if (index > InventoryList.Items.Count - 1)
            {
                index = 0;
            }
            InventoryList.SetSelected(index, true);
            SelectedText = InventoryList.SelectedItem.ToString();
        }

        private void InventoryInput_TextChanged(object sender, EventArgs e)
        {
            InventoryInputText = InventoryInput.Text;
            InventoryInputBool = true;
        }

        private void AddSelectedButton_Click(object sender, EventArgs e)
        {

            string ReplacedSelectedText = Regex.Replace(SelectedText, "^[0-9]+x ", "");
            bool found = false;
            int index = -1;
            string text = "";
            foreach (string item in InventoryList.Items)
            {
                if (!found && Regex.Match(item, "^[0-9]+x ").Success && ReplacedSelectedText == Regex.Replace(item, "^[0-9]+x ", ""))
                {

                    found = true;
                    text = item;
                    index = InventoryList.Items.IndexOf(item);
                }
            }
            if (index != -1)
            {
                int number = int.Parse(Regex.Match(text, "^[0-9]+").Value) + 1;

                InventoryList.Items.RemoveAt(index);
                InventoryList.Items.Insert(index, Regex.Replace(text, "^[0-9]+", number.ToString()));
                InventoryList.SetSelected(index, true);
            }
            if (!Regex.Match(SelectedText, "^[0-9]+x ").Success)
            {
                index = InventoryList.Items.IndexOf(SelectedText);
                InventoryList.Items.RemoveAt(index);
                InventoryList.Items.Insert(index, "2x " + SelectedText);
                InventoryList.SetSelected(index, true);
            }
        }

        private void InventoryInput_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    AddNewButton_Click(new object(), new EventArgs());
                }
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {

            bool found = false;
            if (InventoryList.Items.Contains(InventoryInputText))
            {
                found = true;
            } 
            else
            {
                foreach (string item in InventoryList.Items)
                {
                    if (!found && Regex.Match(item, "^[0-9]+x " + InventoryInputText).Success)
                    {
                        found = true;
                    }
                }
            }
            if (found)
            {
                string backupSelectedText = SelectedText;
                SelectedText = InventoryInputText;
                AddSelectedButton_Click(new object(), new EventArgs());
                SelectedText = backupSelectedText;

            } 
            else
            {
                InventoryList.Items.Add(InventoryInputText);
            }
        }

        private void DeleteSelectedButton_Click(object sender, EventArgs e)
        {
            string ReplacedSelectedText = Regex.Replace(SelectedText, "^[0-9]+x ", "");
            if (InventoryList.Items.Count == 0) return;
            bool found = false;
            int index = -1;
            string text = "";
            foreach (string item in InventoryList.Items)
            {
                if (!found && Regex.Match(item, "^[0-9]+x ").Success && ReplacedSelectedText == Regex.Replace(item, "^[0-9]+x ", ""))
                {
                    found = true;
                    text = item;
                    index = InventoryList.Items.IndexOf(item);
                    
                }
            }
            if (index != -1)
            {
                int number = int.Parse(Regex.Match(text, "^[0-9]+").Value) - 1;
                InventoryList.Items.RemoveAt(index);
                if (number != 0)
                {
                    InventoryList.Items.Insert(index, Regex.Replace(text, "^[0-9]+", number.ToString()));
                    InventoryList.SetSelected(index, true);
                }
            }
        }

        private void DeleteAllButton_Click(object sender, EventArgs e)
        {
            bool found = false;
            string removeText = InventoryInputText;
            foreach (string item in InventoryList.Items)
            {
                if (!found && Regex.Match(item, "^[0-9]+x " + InventoryInputText).Success)
                {
                    found = true;
                    removeText = item;
                }
            }
            InventoryList.Items.Remove(removeText);
        }

        private void SelectedTextChange(object sender, EventArgs e)
        {
            if (InventoryList.SelectedItem != null) SelectedText = InventoryList.SelectedItem.ToString();
        }

        /// ----------------------------------------------------------------------------------------------------
        /// Radio
        /// ----------------------------------------------------------------------------------------------------
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Songlist.Items.Add("no signal found");
            Songlist.Items.Add("no Holotape found");
            Console.WriteLine("songlist");
        }

    }

    /// ----------------------------------------------------------------------------------------------------
    /// Webserver
    /// ----------------------------------------------------------------------------------------------------

    class HttpServer
    {
        public static HttpListener listener;
        public static string url = "http://localhost:8000/";
        public static async Task HandleIncomingConnections(Form1 Formobject)
        {
            bool runServer = true;

            while (runServer)
            {
                HttpListenerContext ctx = await listener.GetContextAsync();

                HttpListenerRequest req = ctx.Request;
                HttpListenerResponse resp = ctx.Response;

                Console.WriteLine("requested " + req.Url);

                if (""+req.Url == "http://localhost:8000/mode")
                {
                    Console.WriteLine("besonderer request");
                    Formobject.Peripherie("mode");
                }
                else if ("" + req.Url == "http://localhost:8000/stat")
                {
                    Formobject.Peripherie("stat");
                }
                else if ("" + req.Url == "http://localhost:8000/data")
                {
                    Formobject.Peripherie("data");
                }
                else if ("" + req.Url == "http://localhost:8000/radio")
                {
                    Formobject.Peripherie("radio");
                }
                else if ("" + req.Url == "http://localhost:8000/rotaryRight")
                {
                    Formobject.Peripherie("rotaryRight");
                }
                else if ("" + req.Url == "http://localhost:8000/rotaryLeft")
                {
                    Formobject.Peripherie("rotaryLeft");
                }

                byte[] data = Encoding.UTF8.GetBytes("Request processed");
                resp.ContentType = "text/plain";
                resp.ContentEncoding = Encoding.UTF8;
                resp.ContentLength64 = data.LongLength;

                await resp.OutputStream.WriteAsync(data, 0, data.Length);
                resp.Close();
            }
        }
        public static void start(Form1 Formobject)
        {
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            Console.WriteLine("Listening for connections on {0}", url);

            Task listenTask = HandleIncomingConnections(Formobject);
        }
    }
}
