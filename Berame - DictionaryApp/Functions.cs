using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Berame___DictionaryApp
{
    internal class Functions
    {
        public static void DisplayDefinitions(FlowLayoutPanel panel, List<DictionaryResponse> definitions)
        {
            panel.Controls.Clear();

            if (definitions != null && definitions.Count > 0)
            {
                foreach (var definition in definitions)
                {
                    AddDefinitionToPanel(panel, "Word", definition.word, new Font("Arial", 18, FontStyle.Bold), Color.Black);
                    AddDefinitionToPanel(panel, "Phonetic", definition.phonetic, new Font("Arial", 15, FontStyle.Italic), Color.Gray);

                    foreach (var meaning in definition.meanings)
                    {
                        AddLabelToPanel(panel, $"Part of Speech: {meaning.partOfSpeech}", new Font("Arial", 15, FontStyle.Underline), Color.DarkGreen);

                        foreach (var def in meaning.definitions)
                        {
                            AddFormattedLabel(panel, "Definition: ", def.definition, new Font("Arial", 13, FontStyle.Bold), new Font("Arial", 13, FontStyle.Regular), Color.Black);

                            if (!string.IsNullOrEmpty(def.example))
                            {
                                AddFormattedLabel(panel, "Example: ", def.example, new Font("Arial", 12, FontStyle.Bold), new Font("Arial", 12, FontStyle.Italic), Color.DarkBlue);
                            }

                            if (def.synonyms != null && def.synonyms.Count > 0)
                            {
                                AddLabelToPanel(panel, $"Synonyms: {string.Join(", ", def.synonyms)}", new Font("Arial", 12, FontStyle.Regular), Color.Purple);
                            }

                            if (def.antonyms != null && def.antonyms.Count > 0)
                            {
                                AddLabelToPanel(panel, $"Antonyms: {string.Join(", ", def.antonyms)}", new Font("Arial", 12, FontStyle.Regular), Color.Purple);
                            }

                            panel.Controls.Add(new Label { Height = 10 });
                        }

                        if (meaning.synonyms != null && meaning.synonyms.Count > 0)
                        {
                            AddLabelToPanel(panel, $"Synonyms: {string.Join(", ", meaning.synonyms)}", new Font("Arial", 12, FontStyle.Regular), Color.Purple);
                        }

                        if (meaning.antonyms != null && meaning.antonyms.Count > 0)
                        {
                            AddLabelToPanel(panel, $"Antonyms: {string.Join(", ", meaning.antonyms)}", new Font("Arial", 12, FontStyle.Regular), Color.Purple);
                        }
                    }
                }
            }
            else
            {
                AddDefinitionToPanel(panel, "Error", "No definitions found.", new Font("Arial", 13, FontStyle.Regular), Color.Red);
            }

            panel.VerticalScroll.Value = 0;
        }

        public static void DisplaySynonyms(FlowLayoutPanel panel, List<DictionaryResponse> definitions)
        {
            panel.Controls.Clear();
            bool foundSynonyms = false;

            if (definitions != null && definitions.Count > 0)
            {
                foreach (var definition in definitions)
                {
                    foreach (var meaning in definition.meanings)
                    {
                        var synonyms = new HashSet<string>();

                        if (meaning.definitions != null && meaning.definitions.Count > 0)
                        {
                            foreach (var def in meaning.definitions)
                            {
                                if (def.synonyms != null && def.synonyms.Count > 0)
                                {
                                    synonyms.UnionWith(def.synonyms);
                                }
                            }
                        }

                        if (meaning.synonyms != null && meaning.synonyms.Count > 0)
                        {
                            synonyms.UnionWith(meaning.synonyms);
                        }

                        if (synonyms.Count > 0)
                        {
                            AddLabelToPanel(panel, $"Synonyms for {definition.word} ({meaning.partOfSpeech}):", new Font("Arial", 15, FontStyle.Bold), Color.Purple);
                            AddLabelToPanel(panel, string.Join(", ", synonyms), new Font("Arial", 13, FontStyle.Regular), Color.Purple);
                            foundSynonyms = true;
                        }
                    }
                }
            }

            if (!foundSynonyms)
            {
                AddDefinitionToPanel(panel, "API Response", "Doesn't contain synonyms for this word.", new Font("Arial", 13, FontStyle.Regular), Color.Red);
            }

            panel.VerticalScroll.Value = 0;
        }

        public static void DisplayAntonyms(FlowLayoutPanel panel, List<DictionaryResponse> definitions)
        {
            panel.Controls.Clear();
            bool foundAntonyms = false;

            if (definitions != null && definitions.Count > 0)
            {
                foreach (var definition in definitions)
                {
                    foreach (var meaning in definition.meanings)
                    {
                        var antonyms = new HashSet<string>();

                        if (meaning.definitions != null && meaning.definitions.Count > 0)
                        {
                            foreach (var def in meaning.definitions)
                            {
                                if (def.antonyms != null && def.antonyms.Count > 0)
                                {
                                    antonyms.UnionWith(def.antonyms);
                                }
                            }
                        }

                        if (meaning.antonyms != null && meaning.antonyms.Count > 0)
                        {
                            antonyms.UnionWith(meaning.antonyms);
                        }

                        if (antonyms.Count > 0)
                        {
                            AddLabelToPanel(panel, $"Antonyms for {definition.word} ({meaning.partOfSpeech}):", new Font("Arial", 15, FontStyle.Bold), Color.Purple);
                            AddLabelToPanel(panel, string.Join(", ", antonyms), new Font("Arial", 13, FontStyle.Regular), Color.Purple);
                            foundAntonyms = true;
                        }
                    }
                }
            }

            if (!foundAntonyms)
            {
                AddDefinitionToPanel(panel, "API Response", "Doesn't contain antonyms for this word.", new Font("Arial", 13, FontStyle.Regular), Color.Red);
            }

            panel.VerticalScroll.Value = 0;
        }

        public static void DisplayUsageExamples(FlowLayoutPanel panel, List<DictionaryResponse> definitions)
        {
            panel.Controls.Clear();
            bool foundExamples = false;

            if (definitions != null && definitions.Count > 0)
            {
                foreach (var definition in definitions)
                {
                    foreach (var meaning in definition.meanings)
                    {
                        if (meaning.definitions.Any(def => !string.IsNullOrEmpty(def.example)))
                        {
                            AddLabelToPanel(panel, $"Part of Speech: {meaning.partOfSpeech}", new Font("Arial", 15, FontStyle.Underline), Color.DarkGreen);
                        }

                        foreach (var def in meaning.definitions)
                        {
                            if (!string.IsNullOrEmpty(def.example))
                            {
                                AddFormattedLabel(panel, "Example: ", def.example, new Font("Arial", 12, FontStyle.Bold), new Font("Arial", 12, FontStyle.Italic), Color.DarkBlue);
                                foundExamples = true;
                            }
                        }
                    }
                }
            }

            if (!foundExamples)
            {
                AddDefinitionToPanel(panel, "API Response", "Doesn't contain usage examples for this word.", new Font("Arial", 13, FontStyle.Regular), Color.Red);
            }

            panel.VerticalScroll.Value = 0;
        }

        private static void AddDefinitionToPanel(FlowLayoutPanel panel, string label, string text, Font font, Color color)
        {
            var definitionLabel = new Label
            {
                Text = $"{label}: {text}",
                Font = font,
                AutoSize = true,
                ForeColor = color,
                Margin = new Padding(10, 5, 10, 5),
                MaximumSize = new Size(panel.Width - 20, 0)
            };

            panel.Controls.Add(definitionLabel);
        }

        private static void AddLabelToPanel(FlowLayoutPanel panel, string text, Font font, Color color)
        {
            var label = new Label
            {
                Text = text,
                Font = font,
                AutoSize = true,
                ForeColor = color,
                Padding = new Padding(0, 5, 0, 5),
                MaximumSize = new Size(panel.Width - 20, 0)
            };

            panel.Controls.Add(label);
        }

        private static void AddFormattedLabel(FlowLayoutPanel panel, string boldText, string regularText, Font boldFont, Font regularFont, Color color)
        {
            var labelPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Margin = new Padding(0),
                MaximumSize = new Size(panel.Width - 20, 0)
            };

            var boldLabel = new Label
            {
                Text = boldText,
                Font = boldFont,
                AutoSize = true,
                ForeColor = color,
                Margin = new Padding(0)
            };

            var regularLabel = new Label
            {
                Text = regularText,
                Font = regularFont,
                AutoSize = true,
                ForeColor = color,
                Margin = new Padding(0)
            };

            labelPanel.Controls.Add(boldLabel);
            labelPanel.Controls.Add(regularLabel);

            panel.Controls.Add(labelPanel);
        }
    }
}
