public async Task CallAoD()
        {
            try
            {
                Console.WriteLine("Calling Article of the Day.");
                File.AppendAllText("files/log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - " + "Calling Article of the Day." + Environment.NewLine);

                if (counter.Equals(0))
                {
                    AoDT = "oooo,ooo";
                }
                else if (counter.Equals(1))
                {
                    AoDT = "anhänge-fehlen";
                }
                else if (counter.Equals(1))
                {
                    AoDT = "deutsch";
                }

                string url = "http://scpper.com/api/tags?site=" + AoDBAPI + "&tags=" + AoDT + "&limit=1&method=or&random=1";
                var json = new WebClient().DownloadString(url);

                dynamic obj = JsonConvert.DeserializeObject(json);

                string firstEntry = obj.pages[0].title;
                Console.WriteLine("Article found: " + firstEntry);
                File.AppendAllText("files/log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - " + "Article found: " + firstEntry + Environment.NewLine);

                string[] liste = File.ReadAllLines("files/aod.txt");

                var index = Array.FindIndex(liste, x => x.StartsWith(firstEntry));

                if (obj.pages[0].rating != null && obj.pages[0].rating <= 3 && index == -1)
                {
                    var channel = _client.GetChannel(AoDC) as SocketTextChannel;

                    var embed = new EmbedBuilder()
                    {
                        Color = new Color(247, 97, 4),
                    };

                    if (obj.pages[0].authors[0].role == "Author")
                    {
                        roleUser = "Autor";
                    }
                    else if (obj.pages[0].authors[0].role == "Translator")
                    {
                        roleUser = "Übersetzer";
                    }

                    if (counter.Equals(0))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"Artikel des Tages, mit einem Korrekturbedürfnislevel von 3 oder 4:";
                            efb.IsInline = false;
                            efb.Value = $"[{obj.pages[0].title}]({AoDB + obj.pages[0].name})\n" +
                                        $"​";
                        });
                    }
                    else if (counter.Equals(1))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"Artikel des Tages, mit fehlenden Anhängen:";
                            efb.IsInline = false;
                            efb.Value = $"[{obj.pages[0].title}]({AoDB + obj.pages[0].name})\n" +
                                        $"​";
                        });
                    }
                    else if (counter.Equals(2))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"Artikel des Tages, mit niedriger Bewertung:";
                            efb.IsInline = false;
                            efb.Value = $"[{obj.pages[0].title}]({AoDB + obj.pages[0].name})\n" +
                                        $"​";
                        });
                    }

                    embed.AddField((efb) =>
                    {
                        efb.Name = $"{roleUser}:";
                        efb.IsInline = true;
                        efb.Value = $"{obj.pages[0].authors[0].user}";
                    });

                    embed.AddField((efb) =>
                    {
                        efb.Name = $"Bewertung:";
                        efb.IsInline = true;
                        efb.Value = $"{obj.pages[0].rating}";
                    });

                    if (counter.Equals(0))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"---";
                            efb.IsInline = true;
                            efb.Value = $"Bei einem so hohen KBL reicht eine Überprüfung der Rechtschreibung nicht, hier muss auch Ausdruck und, bei Übersetzungen, die Übereinstimmung mit dem Original überprüft werden. Hilf mit ihn zu verbessern um den KBL zu senken.";
                        });
                    }
                    else if (counter.Equals(1))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"---";
                            efb.IsInline = true;
                            efb.Value = $"Es fehlen ein oder mehrere Anhänge, bitte hilf mit indem du sie übersetzt.";
                        });
                    }
                    else if (counter.Equals(2))
                    {
                        embed.AddField((efb) =>
                        {
                            efb.Name = $"---";
                            efb.IsInline = true;
                            efb.Value = $"Schaue ihn dir an, gib Feedback und deine ehrliche Bewertung ab.";
                        });
                    }

                    await channel.SendMessageAsync("", false, embed);

                    File.AppendAllText("files/aod.txt", firstEntry + Environment.NewLine);

                    counter++;

                    if (counter.Equals(2))
                    {
                        counter = 0;
                    }
                }
                else
                {
                    Console.WriteLine($"Rating ({obj.pages[0].rating}) too high, equals null or the article was introduced already. Calling.");
                    if (index > -1)
                    {
                        Console.WriteLine(firstEntry + " already introduced.");
                        File.AppendAllText("files/log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - " + firstEntry + " already introduced." + Environment.NewLine);
                    }
                    File.AppendAllText("files/log.txt", DateTime.Now.ToString("dd/MM/yyyy HH:mm") + " - " + $"Rating too high ({obj.pages[0].rating}), equals null or the article was introduced already. Calling." + Environment.NewLine);

                    await CallAoD();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
