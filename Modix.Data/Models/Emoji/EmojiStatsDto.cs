﻿namespace Modix.Data.Models.Emoji
{
    internal class EmojiStatsDto
    {
        public ulong? EmojiId { get; set; }

        public string EmojiName { get; set; } = null!;

        public bool IsAnimated { get; set; }

        public int Rank { get; set; }

        public int Uses { get; set; }
    }
}
