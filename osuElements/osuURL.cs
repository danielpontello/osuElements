﻿using System;
using System.Linq;

namespace osuElements
{
    public static class osuURL
    {
        public static Action<string> OsuAction { get; set; }
        public static string JoinMultiplayerRoom(int multiId, string password = null) {
            var result = $"osu://mp/{multiId}" + (password == null ? "" : $"/{password}");
            OsuAction?.Invoke(result);
            return result;
        }
        public static string SelectEditorNotes(Timing time, params int[] notes) {
            var result = $"osu://edit/{time}";
            if (notes.Length > 0) {
                result += " (" + notes.ToString(",") + ")";
            }
            OsuAction?.Invoke(result);
            return result;
        }
        public static string JoinChatChannel(string channel) {
            var result = $"osu://chan/#{channel}";
            OsuAction?.Invoke(result);
            return result;
        }
        public static string InClientDownload(int mapSetId) {
            var result = $"osu://dl/{mapSetId}";
            OsuAction?.Invoke(result);
            return result;
        }
        public static string SpectateUser(string userName) {
            var result = $"osu://spectate/#{userName}";
            OsuAction?.Invoke(result);
            return result;
        }
        public static string SpectateUser(int userId) => SpectateUser(userId.ToString());

    }
}