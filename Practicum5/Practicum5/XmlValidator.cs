using System;
using System.Collections.Generic;
using System.Text;

namespace Alg1.Practica.Practicum5
{
    public class XmlValidator
    {
        public bool Validate(string xml)
        {
            if (String.IsNullOrWhiteSpace(xml)) return false;

            if (xml[0] != '<' || xml[xml.Length - 1] != '>') return false;

            var tags = getTags(xml);

            return validateTags(tags);
        }

        private List<string> getTags(string xml)
        {
            var tags = new List<string>();

            var tag = new StringBuilder();

            foreach (var character in xml)
            {
                if (character == '<')
                {
                    tag.Clear();
                    continue;
                }

                if (character == '>') tags.Add(tag.ToString());

                tag.Append(character);
            }

            return tags;
        }

        private bool validateTags(List<string> tags)
        {
            if (tags.Count <= 0) return false;

            if (tags.Count % 2 != 0) return false;

            foreach (var tag in tags)
                if (tag.Contains(" "))
                    return false;

            while (tags.Count > 0)
            {
                string tag = tags[0];
                string closeTag = $"/{tag}";

                if (!tags.Contains(closeTag)) return false;

                if (!(tags[1] == closeTag || tags[tags.Count - 1] == closeTag)) return false;

                tags.Remove(tag);
                tags.Remove(closeTag);
            }

            return true;
        }
    }
}