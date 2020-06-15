using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TagManager
{
    private static readonly Dictionary<TagType, string> tags;

    static TagManager()
    {
        tags = new Dictionary<TagType, string>
        {
            {TagType.Player, "Player" }
        };
    }

    public static string GetTag(TagType p_tagType)
    {
        return tags[p_tagType];
    }
}

