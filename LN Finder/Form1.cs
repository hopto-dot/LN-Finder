using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using System.Web;

namespace LN_Finder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Settings
        {
            public string DToken = "";
            public int resultsSize = 11;
        }
        class Link
        {
            public int ID = -1;
            public string Type = "";
            public string URL = "";
            public string Description = "";

            public string messageURL = "";
            public string pointerURL = "";

            public Link()
            {
                Description = "              ";
            }
        }
        Settings settings = new Settings();
        List<Link> links = new List<Link>();
        bool firstOpen = false;
        bool clickedVN = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            if (settings.DToken != "") { cbDiscord.Checked = true; }
            toolStripTextBox1.Text = settings.DToken;

            if (cbDiscord.Checked == true & cbBoroboro.Checked == true && cbItazuraneko.Checked == true && cbZLib.Checked == true && cbNyaa.Checked == true && cbDLRaw.Checked == true)
            {
                cbAll.Checked = true;
            }
            Size = new Size(1300, 800);
        }

        private void loadSettings()
        {
            string settingsString = "";
            if (File.Exists("settings.json"))
            {
                settingsString = File.ReadAllText("settings.json");
                settings = JsonConvert.DeserializeObject<Settings>(settingsString);
            }
            else
            {
                firstOpen = true;
                MessageBox.Show("Settings file created" ,"LN Finder");
                settings = new Settings();
                settings.DToken = "";
                settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText("settings.json", settingsString);
            }

            listView1.Font = new Font("Consolas", settings.resultsSize);
            numericUpDown1.Value = settings.resultsSize;
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            startSearch();
        }

        private void startSearch(bool testScrapers = false)
        {
            if (tbxSearch.Text.Trim() == "") { return; }
            Text = testScrapers ? "LN Finder - Testing scrapers..." : "LN Finder - Searching...";

            listView1.Items.Clear();
            links.Clear();
            List<Task> actions = new List<Task>();
            if (testScrapers == false)
            {
                if (cbDiscord.Checked == true && settings.DToken != "")
                {
                    var discordTask = new Task(searchDiscord);
                    discordTask.Start();
                    actions.Add(discordTask);
                }
                if (cbBoroboro.Checked == true)
                {
                    var boroboroTask = new Task(searchBoroBoro);
                    boroboroTask.Start();
                    actions.Add(boroboroTask);
                }
                if (cbItazuraneko.Checked == true)
                {
                    var itazuraTask = new Task(searchItazura);
                    itazuraTask.Start();
                    actions.Add(itazuraTask);
                }
                if (cbZLib.Checked == true)
                {
                    var zLibTask = new Task(searchZLib);
                    zLibTask.Start();
                    actions.Add(zLibTask);
                }
                if (cbNyaa.Checked == true)
                {
                    var nyaaTask = new Task(searchNyaa);
                    nyaaTask.Start();
                    actions.Add(nyaaTask);
                    var bigNyaaTask = new Task(searchBigNyaaTorrent);
                    bigNyaaTask.Start();
                    actions.Add(bigNyaaTask);
                }
                if (cbDLRaw.Checked == true)
                {
                    var dlRawTask = new Task(searchDLRaw);
                    dlRawTask.Start();
                    actions.Add(dlRawTask);
                }
            }
            else
            {
                var discordTask = new Task(searchDiscord);
                discordTask.Start();
                actions.Add(discordTask);
                var boroboroTask = new Task(searchBoroBoro);
                boroboroTask.Start();
                actions.Add(boroboroTask);
                var itazuraTask = new Task(searchItazura);
                itazuraTask.Start();
                actions.Add(itazuraTask);
                var zLibTask = new Task(searchZLib);
                zLibTask.Start();
                actions.Add(zLibTask);
                var nyaaTask = new Task(searchNyaa);
                nyaaTask.Start();
                actions.Add(nyaaTask);
                var bigNyaaTask = new Task(searchBigNyaaTorrent);
                bigNyaaTask.Start();
                actions.Add(bigNyaaTask);
                var dlRawTask = new Task(searchDLRaw);
                dlRawTask.Start();
                actions.Add(dlRawTask);
            }

            try
            {
                Task.WaitAll(actions.ToArray());
            } catch
            {
                foreach (var action in actions)
                {
                    if (action.Status != TaskStatus.RanToCompletion)
                    {
                        MessageBox.Show($"Scraper with ID #{action.Id} faulted.\n{action.Exception.InnerException.Message}\n{action.Exception.InnerException.StackTrace}", "An error occurred");
                    }
                }
            }

            if (links.Count == 0)
            {
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
                listView1.Columns[0].Width = 50;
                listView1.Columns[1].Width = 100 * settings.resultsSize / 9;
                listView1.Columns[2].Width = 600 * settings.resultsSize / 9;
                listView1.Columns[3].Width = 700 * settings.resultsSize / 9;
            }
            if (testScrapers == false)
            {
                addAllLinks();
            } else
            {
                tbxSearch.Text = "";
                bool discordWorking = links.Find(x => x.Type == "Discord") == null ? false : true;
                bool boroboroWorking = links.Find(x => x.Type == "Boroboro") == null ? false : true;
                bool itazuraWorking = links.Find(x => x.Type == "Itazura") == null ? false : true;
                bool zlibWorking = links.Find(x => x.Type == "Z-Lib") == null ? false : true;
                bool NyaaWorking = links.Find(x => x.Type == "Nyaa") == null ? false : true;
                bool NyaaBigWorking = links.Find(x => x.Description.Contains("truckload")) == null ? false : true;
                bool DLRawWorking = links.Find(x => x.Type == "DLRaw") == null ? false : true;
                
                string functionality =
                    $"Discord: {(discordWorking ? "Working" : "Not working")}\n" +
                    $"Boroboro: {(boroboroWorking ? "Working" : "Not working")}\n" +
                    $"Itazuraneko: {(itazuraWorking ? "Working" : "Not working")}\n" +
                    $"Z-Library: {(zlibWorking ? "Working" : "Not working")}\n" +
                    $"Nyaa: {(NyaaWorking ? (NyaaBigWorking ? "Working" : "Partially working") : "Not working")}\n" +
                    $"DLRaw: {(DLRawWorking ? "Working" : "Not working")}\n";
                MessageBox.Show(functionality, "Scraper Functionality");
                Text = "LN Finder";
            }
        }

        private void addAllLinks()
        {
            if (links.Count == 0) { MessageBox.Show("Nothing found.", "LN Finder"); Text = "LN Finder - Nothing found"; return; }
            Text = $"LN Finder - {links.Count} found";
            int i = 0;
            foreach (Link link in links)
            {
                ListViewItem item = new ListViewItem(link.ID.ToString());
                item.SubItems.Add(link.Type);
                item.SubItems.Add(link.Description);
                item.SubItems.Add(link.URL);
                listView1.Items.Add(item);
                i++;
            }
        }
        
        private void searchZLib()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri($"https://b-ok.cc/s/{tbxSearch.Text}?languages%5B%5D=japanese"));
            }
            catch (Exception ex)
            {
                return;
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(HTML);
            var results = document.DocumentNode.SelectNodes("/html/body/table/tbody/tr[2]/td/div/div/div/div[2]")[0].ChildNodes.ToList();
            int i = 0;
            foreach (var result in results)
            {
                i++;
                if (result.Attributes.Count == 0) { continue; }
                if (!result.Attributes["class"].Value.Contains("exactMatch")) { continue; }

                Link newLink = new Link();
                newLink.Type = "Z-Lib";
                newLink.Description = result.ChildNodes[1].ChildNodes[3].InnerText.Trim();
                newLink.Description = newLink.Description.Substring(0, newLink.Description.IndexOf("\n"));
                if (!newLink.Description.ToLower().Contains(tbxSearch.Text.ToLower())) { continue; }
                newLink.URL = "https://b-ok.cc" + result.ChildNodes[1].ChildNodes[3].ChildNodes[1].ChildNodes[3].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].Attributes["href"].Value;
                newLink.ID = links.Count();
                links.Add(newLink);
            }
        }
        private void searchBoroBoro()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri("https://boroboro.neocities.org/listfullepub.html"));
            }
            catch (Exception ex)
            {
                return;
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(HTML);
            var results = document.DocumentNode.SelectNodes("/html/body/table/tbody")[0].ChildNodes;
            foreach (var result in results)
            {
                if (result.Name != "tr") { continue; }
                if (!result.InnerText.Contains(tbxSearch.Text)) { continue; }

                Link newLink = new Link();
                newLink.Description = result.InnerText;
                newLink.URL = result.ChildNodes[0].ChildNodes[0].Attributes["href"].Value;
                newLink.Type = "Boroboro";
                newLink.ID = links.Count();
                links.Add(newLink);
            }


            Console.WriteLine();
        }
        private void searchItazura()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri("https://yonde.itazuraneko.org/other/kensaku.html"));
            }
            catch (Exception ex)
            {
                return;
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(HTML);
            var results = document.DocumentNode.SelectNodes("/html/body/div/table")[0].ChildNodes;
            foreach (var result in results)
            {
                if (result.Name == "#text" || result.ChildNodes[0].InnerText.Contains("(html link)")) { continue; }
                var link = new Link();
                link.Description = result.ChildNodes[0].InnerText;
                if (!link.Description.Contains(tbxSearch.Text)) { continue; }
                link.URL = result.ChildNodes[0].ChildNodes[0].Attributes["href"].Value.Replace("../", "https://yonde.itazuraneko.org/");
                link.Type = "Itazura";
                link.ID = links.Count;
                links.Add(link);

                
            }
            Console.WriteLine();
        }
        private void searchDiscord()
        {           
            bool inBookList = false;
            bool doneAllPages = false;
            int looped = 0;
            while (!doneAllPages)
            {
                string url = $"https://discord.com/api/v9/guilds/617136488840429598/messages/search?channel_id=819968020012204112&content={tbxSearch.Text}&include_nsfw=true&offset={looped}";
                var httpClient = new HttpClient();
                var request = new HttpRequestMessage(new HttpMethod("GET"), url);
                request.Headers.TryAddWithoutValidation("authorization", settings.DToken);

                var response = httpClient.SendAsync(request).Result;
                string content = response.Content.ReadAsStringAsync().Result;

                var results = JObject.Parse(content).Children().ToList()[1].Children().ToList()[0].Values();

                int totalResults = -1;
                if (JObject.Parse(content).Children().ToList()[0].Children().ToList()[0].Value<String>() ==  "False")
                {
                    return;
                }
                try
                {
                    totalResults = int.Parse(JObject.Parse(content).Children().ToList()[0].Children().ToList()[0].Value<String>());
                } catch
                {
                    string token = "";
                    if (InputBox("Enter Token", "It seems the provided token was wrong. Please try entering it again.", ref token) == DialogResult.OK)
                    {
                        if (token.Length < 60 || !token.Contains(".") || token.Contains(" "))
                        {
                            MessageBox.Show("That isn't a valid Discord token!", "LN Finder");
                            string newSettingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                            settings.DToken = "";
                            File.WriteAllText("settings.json", newSettingsString);
                            return;
                        }

                        settings.DToken = token;
                        string settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                        File.WriteAllText("settings.json", settingsString);

                        MessageBox.Show($"Discord token is now {token}", "LN Finder");
                    }
                }

                foreach (var result in results)
                {
                    looped++;
                    string msgContent = result.Children().ToList()[2].Children().ToList()[0].Value<String>();
                    
                    if (msgContent.Contains("https://discord.com/channels/"))
                    {
                        string temp = msgContent;
                        try
                        {
                            temp = temp.Substring(temp.IndexOf(tbxSearch.Text));
                            temp = temp.Substring(temp.IndexOf("https://discord.com/channels/"));
                            try
                            {
                                temp = temp.Substring(0, temp.IndexOf("\n"));
                            } catch { }
                            Link link = new Link();
                            link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //
                            link.Type = "Discord";
                            link.URL = temp;

                            //temp = msgContent;
                            //temp = temp.Substring(temp.IndexOf(tbxSearch.Text));
                            //temp = temp.Substring(0, temp.IndexOf("\n"));

                            link.Description = msgContent;
                            bool startReached = false;
                            int contentIndex = msgContent.IndexOf(tbxSearch.Text);
                            while (startReached == false)
                            {
                                if (contentIndex == 0) { startReached = true; break; }
                                string indexChar = msgContent.Substring(contentIndex, 1);
                                if (indexChar == "\n") { startReached = true; break; };
                                contentIndex--;
                            }
                                link.Description = link.Description.Substring(contentIndex).Trim(); //, link.Description.IndexOf(link.URL) - contentIndex
                            try
                            {
                                link.Description = link.Description.Substring(0, link.Description.IndexOf("\n"));
                            } catch { }
                            link.ID = links.Count;
                            link.pointerURL = link.URL;
                            links.Add(link);
                            continue;
                        } catch
                        {
                            Link link = new Link();
                            link.Type = "Discord";
                            link.URL = "https://discord.com/channels/617136488840429598/882987261627617310"; //+ result.Children().ToList()[0].Children().ToList()[0].Value<String>();
                            link.Description = "List of downloads";
                            link.ID = links.Count;
                            link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //
                            links.Add(link);
                            continue;
                        }
                        

                        Console.WriteLine();
                    }
                    if (msgContent.Contains("Books:"))
                    {
                        if (msgContent.Contains(tbxSearch.Text)) { inBookList = true; }
                        continue;
                    }
                    string msgAttachment = "";
                    if ((msgContent.Contains("mega.nz/") || msgContent.Contains("drive.google")) && !msgContent.ToLower().Contains("audio"))
                    {
                        Link link = new Link();
                        int snipIndex = -1;
                        string newLink = "";
                        snipIndex = msgContent.Contains("mega.nz/") ? msgContent.IndexOf("https://mega.nz/") : msgContent.IndexOf("https://drive.google.com/");
                        newLink = msgContent.Substring(snipIndex);
                        bool end = false;
                        int i = 0;
                        while (end == false)
                        {
                            if (i >= newLink.Length - 1)
                            {
                                end = true; break;
                            }
                            string substring = newLink.Substring(i, 1);
                            if (substring == "\n" || substring == " ")
                            {

                                newLink = newLink.Substring(0, i);
                                end = true; break;
                            }
                            i += 1;
                        }

                        link.URL = newLink;
                        link.Type = "Discord";
                        link.Description = msgContent;//.Replace(newLink, "").Trim().Replace("*", "");
                        link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //

                        ////
                        bool startReached = false;
                        int contentIndex = msgContent.IndexOf(tbxSearch.Text);
                        while (startReached == false)
                        {
                            if (contentIndex == 0) { startReached = true; break; }
                            string indexChar = msgContent.Substring(contentIndex, 1);
                            if (indexChar == "\n") { startReached = true; break; };
                            contentIndex--;
                        }
                        link.Description = link.Description.Substring(contentIndex).Trim(); //, link.Description.IndexOf(link.URL) - contentIndex
                        try
                        {
                            link.Description = link.Description.Substring(0, link.Description.IndexOf("\n"));
                        }
                        catch { }
                        ////

                        link.ID = links.Count();
                        links.Add(link);
                    }
                    else
                    {
                        try
                        {
                            int attachmentCount = 0;
                            Console.WriteLine();
                            foreach (var attachment in result.Children().ToList()[5].Children().ToList()[0])
                            {
                                if (attachment.Children().Count() == 0) { continue; }

                                msgAttachment = attachment.Children().ToList()[3].Children().ToList()[0].Value<String>();
                                String[] validAttachments = { ".epub", ".azw3", ".zip", ".rar", ".pdf" };
                                bool valid = false;
                                foreach (string validAttachment in validAttachments)
                                {
                                    if (msgAttachment.Contains(validAttachment)) { valid = true; attachmentCount++; break; }
                                }
                                if (!valid) { continue; }

                                //Link link = new Link();
                                //link.URL = msgAttachment;
                                //link.Description = msgContent.Replace(msgAttachment, "").Trim().Replace("*", "");
                                //link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //
                                //link.Type = "Discord";
                                //link.ID = links.Count();
                                //links.Add(link);
                                //Console.WriteLine();
                            }

                            if (attachmentCount == 1)
                            {
                                Link link = new Link();
                                link.URL = msgAttachment;
                                link.Description = msgContent.Replace(msgAttachment, "").Trim().Replace("*", "");
                                link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //
                                link.Type = "Discord (download)";
                                link.ID = links.Count();
                                links.Add(link);
                            }
                            else if (attachmentCount > 1)
                            {
                                Link link = new Link();
                                link.URL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>();
                                link.Description = msgContent.Replace(msgAttachment, "").Trim().Replace("*", "");
                                link.messageURL = "https://discord.com/channels/617136488840429598/819968020012204112/" + result.Children().ToList()[0].ToList()[0].Value<String>(); //
                                link.Type = "Discord";
                                link.ID = links.Count();
                                links.Add(link);
                            }
                            
                            Console.WriteLine();
                        }
                        catch
                        {
                            try
                            {
                                var attachments = result.Children().ToList()[5].Children().ToList();
                            }
                            catch
                            {

                            }
                        }
                    }
                }
                if (looped >= totalResults)
                {
                    doneAllPages = true; break;
                }
            }
            

            if (inBookList == true)
            {
                //MessageBox.Show("A download link for that ln couldn't be extracted but it seems there is a link on Discord");
                Link newLink = new Link();
                newLink.Type = "Discord msg";
                newLink.Description = "(Collection of links)";
                newLink.URL = "https://discord.com/channels/617136488840429598/882987261627617310/882987263477301330";
                newLink.ID = links.Count();
                links.Add(newLink);
            }

            bool foundResults = links.Count == 0 ? false : true;
            List<Link> toRemove = new List<Link>();
            foreach (Link link in links.Where(l => l.Type.Contains("Discord")))
            {
                foreach (Link link2 in links.Where(l => l.Type.Contains("Discord")))
                {
                    if (link == link2) { continue; }
                    if ( (!(link.pointerURL == "" && link2.messageURL == "")) && (link.pointerURL == link2.messageURL) )
                    {
                        toRemove.Add(link);
                    }
                }
            }
            foreach (Link remove in toRemove)
            {
                links.Remove(remove);
            }
            if (links.Count == 0 && foundResults == true) { MessageBox.Show("Something went wrong with removing duplicate download links", "Error"); }

            Console.WriteLine("Done!");
        }
        private void searchNyaa()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri($"https://nyaa.si/?f=0&c=3_3&q={tbxSearch.Text}"));
            }
            catch (Exception ex)
            {
                return;
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(HTML);
            HtmlNodeCollection results = null;
            try
            {
                results = document.DocumentNode.SelectNodes("/html/body/div/div[1]/table")[0].ChildNodes[3].ChildNodes;
            } catch { return; }
            foreach (var result in results)
            {
                if (result.Name != "tr") { continue; }
                Link newLink = new Link();
                try
                {
                    newLink.Description = result.ChildNodes[3].ChildNodes[1].InnerText.Trim();
                    int num = -1;
                    bool isNum = int.TryParse(newLink.Description, out num);
                    if (isNum) { newLink.Description = result.ChildNodes[3].ChildNodes[3].InnerText.Trim(); }
                    if (!newLink.Description.ToLower().Contains(tbxSearch.Text.ToLower())) { continue; }
                    newLink.Description = newLink.Description.Replace("[Novel]", "");
                    newLink.Description = newLink.Description.Replace("(一般小説)", "").Trim();
                    if (newLink.Description.IndexOf("]") <= 7 && newLink.Description.IndexOf("]") != -1)
                    {
                        newLink.Description = newLink.Description.Substring(newLink.Description.IndexOf("]") + 1).Trim();
                    }

                    newLink.URL = "https://nyaa.si" + result.ChildNodes[3].ChildNodes[1].Attributes["href"].Value.Replace("#comments", "");
                    newLink.Type = "Nyaa";
                    newLink.ID = links.Count;
                    links.Add(newLink);
                } catch {}
            }
        }
        private void searchBigNyaaTorrent()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri("http://dawn.whatbox.ca:11665/f/filelist.html"));
            }
            catch (Exception ex)
            {
                return;
            }

            if (!HTML.Contains(tbxSearch.Text)) { return; }

            Link newLink = new Link();
            newLink.Description = "A torrent with a truckload of light novels";
            newLink.Type  = "Nyaa";
            newLink.URL = "https://nyaa.si/view/1350523";
            newLink.ID = links.Count;
            links.Add(newLink);
        }
        private void searchDLRaw()
        {
            var Client = new WebClient();
            string HTML = "";
            int SnipIndex = -1;
            Client.Encoding = Encoding.UTF8;

            try
            {
                HTML = Client.DownloadString(new Uri($"https://dl-raw.net/?s={tbxSearch.Text}"));
            }
            catch (Exception ex)
            {
                return;
            }

            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(HTML);
            var results = document.DocumentNode.SelectNodes("/html/body/div[4]/div/div/div[1]/div/div[1]/div/div[2]")[0].ChildNodes;

            foreach (var result in results)
            {
                if (result.Name != "article") { continue; }
                Link newLink = new Link();
                newLink.Description = result.ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[0].InnerText;
                if (!newLink.Description.Contains("[Novel]") || !newLink.Description.Contains(tbxSearch.Text)) { continue; }
                newLink.Description = newLink.Description.Replace("[Novel]", "").Trim();
                newLink.URL = HttpUtility.UrlDecode(result.ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[1].ChildNodes[0].Attributes["href"].Value);
                newLink.Type = "DLRaw";
                newLink.ID = links.Count;
                links.Add(newLink);
            }



            Console.WriteLine();
        }





        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 15, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 26);
            buttonCancel.SetBounds(309, 72, 75, 26);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void cbDiscord_CheckedChanged(object sender, EventArgs e)
        {
            if (settings.DToken.Length < 10 && cbDiscord.Checked == true)
            {
                string token = "";
                if (InputBox("Enter Token", "Enter your discord token (this will be saved in settings.json).", ref token) == DialogResult.OK)
                {
                    if (token.Length < 60 || !token.Contains(".") || token.Contains(" ")) { MessageBox.Show("That isn't a valid Discord token!", "LN Finder"); cbDiscord.Checked = false; return; }
                    settings.DToken = token;
                    string settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                    File.WriteAllText("settings.json", settingsString);

                    toolStripTextBox1.Text = settings.DToken;
                    MessageBox.Show($"Discord token is now {token}", "LN Finder");
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            Process.Start(listView1.SelectedItems[0].SubItems[3].Text);
            Console.WriteLine();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value > 20) { numericUpDown1.Value = 26; }
            if ((int)numericUpDown1.Value < 7) { numericUpDown1.Value = 6; }
            settings.resultsSize = (int)numericUpDown1.Value;
            listView1.Font = new Font("Consolas", settings.resultsSize);
            string settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText("settings.json", settingsString);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        int lastColumnClick = -1;
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (links.Count == 0) { return; }
            sortLinks(e.Column);
        }

        private void sortLinks(int column)
        {
            if (column != lastColumnClick)
            {
                switch (column)
                {
                    case 0:
                        links = links.OrderBy(x => x.ID).ToList();
                        break;
                    case 1:
                        links = links.OrderBy(x => x.Type).ToList();
                        break;
                    case 2:
                        links = links.OrderBy(x => x.Description).ToList();
                        break;
                    case 3:
                        links = links.OrderBy(x => x.URL).ToList();
                        break;
                }
                lastColumnClick = column;
            } else
            {
                switch (column)
                {
                    case 0:
                        links = links.OrderByDescending(x => x.ID).ToList();
                        break;
                    case 1:
                        links = links.OrderByDescending(x => x.Type).ToList();
                        break;
                    case 2:
                        links = links.OrderByDescending(x => x.Description).ToList();
                        break;
                    case 3:
                        links = links.OrderByDescending(x => x.URL).ToList();
                        break;
                }
                lastColumnClick -= 5;
            }

            listView1.Items.Clear();
            addAllLinks();
        }

        bool doubleClick = false;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) 
            {

            }
            if (firstOpen && !doubleClick) { MessageBox.Show("You can double click results to open their download page, and click on the list headers to sort results.", "LN Finder"); doubleClick = true; }
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { startSearch(); }
        }

        //select all
        private void cbAll_Click(object sender, EventArgs e)
        {
            selectAllChanged();
        }

        private void selectAllChanged()
        {
            if (cbAll.Checked == true)
            {
                if (btnLN.Enabled == false) //if viewing light novels
                {
                    if (settings.DToken != "") { cbDiscord.Checked = true; }
                    cbBoroboro.Checked = true;
                    cbItazuraneko.Checked = true;
                    cbZLib.Checked = true;
                    cbNyaa.Checked = true;
                    cbDLRaw.Checked = true;
                }
                else //if viewing visual novels
                {
                    cbRyuu.Checked = true;
                    cbGGB.Checked = true;
                    cbCrane.Checked = true;
                    cbAnimeSharing.Checked = true;
                    cbMiko.Checked = true;
                }
            }
            else
            {
                if (btnLN.Enabled == false) //if viewing light novels
                {
                    cbDiscord.Checked = false;
                    cbBoroboro.Checked = false;
                    cbItazuraneko.Checked = false;
                    cbZLib.Checked = false;
                    cbNyaa.Checked = false;
                    cbDLRaw.Checked = false;
                }
                else //if viewing visual novels
                {
                    cbRyuu.Checked = false;
                    cbGGB.Checked = false;
                    cbCrane.Checked = false;
                    cbAnimeSharing.Checked = false;
                    cbMiko.Checked = false;
                }
            }
        }
        



        //////// menu strip ////////

        //quit

        //quit application
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //open settings.json
        private void openSettingsFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("notepad.exe", "settings.json");
            } catch
            {
                MessageBox.Show("File not found");
            }
        }
        //open program folder
        private void openProgramFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
            }
            catch
            {
                MessageBox.Show("Failed to open folder");
            }
        }
        //type in DToken box
        private void toolStripTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                string token = toolStripTextBox1.Text;
                if (token.Length < 60 || !token.Contains(".") || token.Contains(" ")) { MessageBox.Show("That isn't a valid Discord token!", "LN Finder"); cbDiscord.Checked = false; toolStripTextBox1.Text = settings.DToken; return; }
                settings.DToken = token;
                string settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                File.WriteAllText("settings.json", settingsString);

                toolStripTextBox1.Text = settings.DToken;
                MessageBox.Show($"Discord token is now {token}", "LN Finder");



            }
        }
        //type in results size box
        private void toolStripTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                int newSize = -1;
                int.TryParse(toolStripTextBox2.Text, out newSize);
                if (newSize > 3 && newSize < 60)
                {
                    numericUpDown1.Value = newSize;
                    settings.resultsSize = newSize;
                    string settingsString = JsonConvert.SerializeObject(settings, Formatting.Indented);
                    File.WriteAllText("settings.json", settingsString);
                }
            }
        }
        //click Edit
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = settings.DToken;
            toolStripTextBox2.Text = numericUpDown1.Value.ToString();
            if (listView1.SelectedItems.Count > 0) {
                copyTitleToolStripMenuItem.Enabled = true;
                copyLinkOfSelectedToolStripMenuItem.Enabled = true;
            }
        }
        //test all scrapers click
        private void checkScraperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "ソードアート・オンライン";
            startSearch(true);

            tbxSearch.Text = "";
        }
        //check internet
        private void checkInternetConnectivityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var client = new WebClient();
            try
            {
                client.DownloadString("https://www.google.co.uk/");
                MessageBox.Show("You are connected to the internet");
            } catch
            {
                MessageBox.Show("You are not connected to the internet");
            }
        }
        //reset settings
        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset your settings?", "Reset Settings", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete("settings.json");
                    loadSettings();
                    MessageBox.Show("Successfully reset your settings", "Reset Success");
                } catch
                {
                    MessageBox.Show("Failed to reset your settings", "Reset failed");
                }
            }
        }
        //copy title of selected
        private void copyTitleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[2].Text);
        }
        //copy link of selected
        private void copyLinkOfSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[3].Text);
        }

        //list context menu
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                copyTitleToolStripMenuItem1.Enabled = false;
                copyLinkToolStripMenuItem.Enabled = false;
                goToLinkToolStripMenuItem.Enabled = false;
            }
            else
            {
                copyTitleToolStripMenuItem1.Enabled = true;
                copyLinkToolStripMenuItem.Enabled = true;
                goToLinkToolStripMenuItem.Enabled = true;
            }

            try
            {
                if (links.FindAll(s => s.ID == int.Parse(listView1.SelectedItems[0].SubItems[0].Text))[0].Type.Contains("Discord"))
                {
                    goToMessageToolStripMenuItem.Visible = true;
                }
                else
                {
                    goToMessageToolStripMenuItem.Visible = false;
                }
            } catch
            {
                goToMessageToolStripMenuItem.Visible = false;
            }
            
            if (listView1.Items.Count == 0)
            {
                clearListToolStripMenuItem.Enabled = false;
            } else
            {
                clearListToolStripMenuItem.Enabled = true;
            }
        }

        //resize to fit
        private void resizeHeadersToFitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        //clear list
        private void clearListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void copyTitleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[2].Text);
        }

        private void copyLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(listView1.SelectedItems[0].SubItems[3].Text);
        }

        private void goToLinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(listView1.SelectedItems[0].SubItems[3].Text);
        }

        private void changeMedium(object sender, EventArgs e)
        {
            if (sender.ToString().Contains("Light novels"))
            {
                //if (settings.DToken != "") { cbDiscord.Checked = true; }

                btnLN.Enabled = false;
                btnVN.Enabled = true;

                cbDiscord.Visible = true;
                cbBoroboro.Visible = true;
                cbItazuraneko.Visible = true;
                cbZLib.Visible = true;
                cbNyaa.Visible = true;
                cbDLRaw.Visible = true;

                cbRyuu.Visible = false;
                cbGGB.Visible = false;
                cbCrane.Visible = false;
                cbAnimeSharing.Visible = false;
                cbMiko.Visible = false;
                cbRyuu.Location = new Point(cbRyuu.Location.X, cbRyuu.Location.Y + 312);
                cbGGB.Location = new Point(cbGGB.Location.X, cbGGB.Location.Y + 312);
                cbCrane.Location = new Point(cbCrane.Location.X, cbCrane.Location.Y + 312);
                cbAnimeSharing.Location = new Point(cbAnimeSharing.Location.X, cbAnimeSharing.Location.Y + 312);
                cbMiko.Location = new Point(cbMiko.Location.X, cbMiko.Location.Y + 312);
                if (cbDiscord.Checked == true & cbBoroboro.Checked == true && cbItazuraneko.Checked == true && cbZLib.Checked == true && cbNyaa.Checked == true && cbDLRaw.Checked == true)
                {
                    cbAll.Checked = true;
                }
                else if (cbDiscord.Checked == false || cbBoroboro.Checked == false || cbItazuraneko.Checked == false || cbZLib.Checked == false || cbNyaa.Checked == false || cbDLRaw.Checked == false)
                {
                    cbAll.Checked = false;
                }
            }
            else //visual novels
            {
                if (clickedVN == false) { MessageBox.Show("This feature doesn't work yet!", "Search Visual Novels", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                clickedVN = true;

                cbRyuu.Checked = true;
                btnLN.Enabled = true;
                btnVN.Enabled = false;

                cbRyuu.Visible = true;
                cbGGB.Visible = true;
                cbCrane.Visible = true;
                cbAnimeSharing.Visible = true;
                cbMiko.Visible = true;
                cbRyuu.Location = new Point(cbRyuu.Location.X, cbRyuu.Location.Y - 312);
                cbGGB.Location = new Point(cbGGB.Location.X, cbGGB.Location.Y - 312);
                cbCrane.Location = new Point(cbCrane.Location.X, cbCrane.Location.Y - 312);
                cbAnimeSharing.Location = new Point(cbAnimeSharing.Location.X, cbAnimeSharing.Location.Y - 312);
                cbMiko.Location = new Point(cbMiko.Location.X, cbMiko.Location.Y - 312);


                cbDiscord.Visible = false;
                cbBoroboro.Visible = false;
                cbItazuraneko.Visible = false;
                cbZLib.Visible = false;
                cbNyaa.Visible = false;
                cbDLRaw.Visible = false;
                if (cbRyuu.Checked == true && cbCrane.Checked == true && cbGGB.Checked == true && cbAnimeSharing.Checked == true && cbMiko.Checked == true)
                {
                    cbAll.Checked = true;
                }
                else if (cbRyuu.Checked == false || cbCrane.Checked == false || cbGGB.Checked == false || cbAnimeSharing.Checked == false || cbMiko.Checked == false)
                {
                    cbAll.Checked = false;
                }
            }
        }

        private void cbAnyLN(object sender, EventArgs e)
        {
            if (cbDiscord.Checked == true & cbBoroboro.Checked == true && cbItazuraneko.Checked == true && cbZLib.Checked == true && cbNyaa.Checked == true && cbDLRaw.Checked == true)
            {
                cbAll.Checked = true;
            }
            else if (cbDiscord.Checked == false || cbBoroboro.Checked == false || cbItazuraneko.Checked == false || cbZLib.Checked == false || cbNyaa.Checked == false || cbDLRaw.Checked == false)
            {
                cbAll.Checked = false;
            }
        }

        private void cbAnyVN(object sender, EventArgs e)
        {
            if (cbRyuu.Checked == true && cbCrane.Checked == true && cbGGB.Checked == true && cbAnimeSharing.Checked == true && cbMiko.Checked == true)
            {
                cbAll.Checked = true;
            } 
            else if (cbRyuu.Checked == false || cbCrane.Checked == false || cbGGB.Checked == false || cbAnimeSharing.Checked == false || cbMiko.Checked == false)
            {
                cbAll.Checked = false;
            }
        }

        private void bigGUIScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bigGUIScaleToolStripMenuItem.Enabled = false;

            menuStrip1.Font = new Font(menuStrip1.Font.Name, 11);
            //listView1.Size = new Size(912, 436);
            listView1.Size = new Size(listView1.Size.Width - 19, listView1.Size.Height);
            listView1.Location = new Point(12, 77);
            btnSearch.Font = new Font(btnSearch.Font.Name, 12);
            btnSearch.Location = new Point(12, 38);
            btnSearch.Size = new Size(90, 36);
            tbxSearch.Location = new Point(109, 39);
            //tbxSearch.Size = new Size(815, 29);
            tbxSearch.Size = new Size(tbxSearch.Size.Width - 32, 29);
            tbxSearch.Font = new Font(tbxSearch.Font.Name, 14);

            cbAll.Location = new Point(cbAll.Location.X - 5, cbAll.Location.Y);
            cbDiscord.Location = new Point(cbDiscord.Location.X - 9, cbDiscord.Location.Y);
            cbBoroboro.Location = new Point(cbBoroboro.Location.X - 6, cbBoroboro.Location.Y);
            cbItazuraneko.Location = new Point(cbItazuraneko.Location.X - 3, cbItazuraneko.Location.Y);
            cbZLib.Location = new Point(cbZLib.Location.X - 15, cbZLib.Location.Y);
            cbNyaa.Location = new Point(cbNyaa.Location.X - 15, cbNyaa.Location.Y);
            cbDLRaw.Location = new Point(cbDLRaw.Location.X - 11, cbDLRaw.Location.Y);

            cbRyuu.Location = new Point(cbRyuu.Location.X + 1, cbRyuu.Location.Y);
            cbCrane.Location = new Point(cbCrane.Location.X + 4, cbCrane.Location.Y);
            cbGGB.Location = new Point(cbGGB.Location.X - 7, cbGGB.Location.Y);
            cbAnimeSharing.Location = new Point(cbAnimeSharing.Location.X + 7, cbAnimeSharing.Location.Y);
            cbMiko.Location = new Point(cbMiko.Location.X - 14, cbMiko.Location.Y);

            cbAll.Font = new Font(cbAll.Font.Name, 11);
            cbDiscord.Font = new Font(cbDiscord.Font.Name, 11);
            cbBoroboro.Font = new Font(cbBoroboro.Font.Name, 11);
            cbItazuraneko.Font = new Font(cbItazuraneko.Font.Name, 11);
            cbZLib.Font = new Font(cbZLib.Font.Name, 11);
            cbNyaa.Font = new Font(cbNyaa.Font.Name, 11);
            cbDLRaw.Font = new Font(cbDLRaw.Font.Name, 11);
            cbRyuu.Font = new Font(cbRyuu.Font.Name, 11);
            cbCrane.Font = new Font(cbCrane.Font.Name, 11);
            cbGGB.Font = new Font(cbGGB.Font.Name, 11);
            cbAnimeSharing.Font = new Font(cbAnimeSharing.Font.Name, 11);
            cbMiko.Font = new Font(cbMiko.Font.Name, 11);

            label1.Location = new Point(label1.Location.X - 26, label1.Location.Y - 4);
            label1.Font = new Font(label1.Font.Name, 12);
            numericUpDown1.Location = new Point(numericUpDown1.Location.X - 26, numericUpDown1.Location.Y);
            numericUpDown1.Size = new Size(numericUpDown1.Size.Width + 40, numericUpDown1.Size.Height);
            numericUpDown1.Font = new Font(numericUpDown1.Font.Name, 13);

            btnLN.Location = new Point(btnLN.Location.X - 26, btnLN.Location.Y);
            btnLN.Size = new Size(btnLN.Width + 40, btnLN.Height + 10);
            btnLN.Font = new Font(btnLN.Font.Name, 11);
            btnVN.Location = new Point(btnVN.Location.X - 26, btnVN.Location.Y + 10);
            btnVN.Size = new Size(btnVN.Width + 40, btnVN.Height + 10);
            btnVN.Font = new Font(btnVN.Font.Name, 11);
            MinimumSize = new Size(MinimumSize.Width + 30, MinimumSize.Height + 17);
            if (numericUpDown1.Value == 10) { numericUpDown1.Value = 12; }
        }

        private void browseVisualNovelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.amazon.co.jp/s?i=stripbooks&bbn=2189055051&rh=n%3A2189055051%2Cp_n_condition-type%3A680578011%2Cp_n_publication_date%3A82838051&s=date-desc-rank&dc&ds=v1%3AVj1grqE9nzMKA4z3wRUA9PHofS9HvSAxuEWp424M0IE&rnid=82836051&ref=sr_nr_p_n_publication_date_8");
        }

        private void goToMessageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(links.FindAll(s => s.ID.ToString() == listView1.SelectedItems[0].SubItems[0].Text.ToString())[0].messageURL);
        }
    }
}
