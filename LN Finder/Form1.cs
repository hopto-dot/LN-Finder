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
            public int resultsSize = 10;
        }
        class Link
        {
            public int ID = -1;
            public string Type = "";
            public string URL = "";
            public string Description = "";

            public Link()
            {
                Description = "              ";
            }
        }
        Settings settings = new Settings();
        List<Link> links = new List<Link>();
        bool firstOpen = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            loadSettings();
            if (settings.DToken != "") { cbDiscord.Checked = true; }
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

        private void startSearch()
        {
            Text = "LN Finder - Searching...";
            if (tbxSearch.Text.Trim() == "") { return; }

            listView1.Items.Clear();
            links.Clear();
            List<Task> actions = new List<Task>();
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
            Task.WaitAll(actions.ToArray());

            if (links.Count == 0)
            {
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            else
            {
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.None);
                listView1.Columns[0].Width = 40;
                listView1.Columns[1].Width = 100 * settings.resultsSize / 9;
                listView1.Columns[2].Width = 600 * settings.resultsSize / 9;
                listView1.Columns[3].Width = 700 * settings.resultsSize / 9;
            }
            addAllLinks();
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
                        link.Description = msgContent.Replace(newLink, "").Trim().Replace("*", "");
                        link.ID = links.Count();
                        links.Add(link);
                    }
                    else
                    {
                        try
                        {
                            foreach (var attachment in result.Children().ToList()[5].Children().ToList()[0])
                            {
                                if (attachment.Children().Count() == 0) { continue; }

                                msgAttachment = attachment.Children().ToList()[3].Children().ToList()[0].Value<String>();
                                String[] validAttachments = { ".epub", ".azw3", ".zip", ".rar" };
                                bool valid = false;
                                foreach (string validAttachment in validAttachments)
                                {
                                    if (msgAttachment.Contains(validAttachment)) { valid = true; break; }
                                }
                                if (!valid) { continue; }

                                Link link = new Link();
                                link.URL = msgAttachment;
                                link.Description = msgContent.Replace(msgAttachment, "").Trim().Replace("*", "");
                                link.Type = "Discord";
                                link.ID = links.Count();
                                links.Add(link);
                                Console.WriteLine();
                            }
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
                newLink.Type = "DLSite";
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
            if (firstOpen && !doubleClick) { MessageBox.Show("You can double click results to open their download page, and click on the list headers to sort results.", "LN Finder"); doubleClick = true; }
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') { startSearch(); }
        }
    }
}
