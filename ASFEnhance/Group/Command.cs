﻿#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。

using ArchiSteamFarm.Core;
using ArchiSteamFarm.Localization;
using ArchiSteamFarm.Steam;
using ASFEnhance.Data;
using ASFEnhance.Localization;
using System.Text;
using static ASFEnhance.Utils;

namespace ASFEnhance.Group
{
    internal static class Command
    {
        /// <summary>
        /// 加入指定群组
        /// </summary>
        /// <param name="bot"></param>
        /// <param name="gruopID"></param>
        /// <returns></returns>
        internal static async Task<string?> ResponseJoinGroup(Bot bot, string gruopID)
        {
            if (!bot.IsConnectedAndLoggedOn)
            {
                return bot.FormatBotResponse(Strings.BotNotConnected);
            }

            (JoinGroupStatus status, string? message) = await WebRequest.JoinGroup(bot, gruopID).ConfigureAwait(false);

            string statusString = status switch {
                JoinGroupStatus.Failed => Langs.Failure,
                JoinGroupStatus.Joined => Langs.Joined,
                JoinGroupStatus.Unjoined => Langs.Unjoined,
                JoinGroupStatus.Applied => Langs.Applied,
                _ => throw new NotImplementedException(),
            };

            switch (status)
            {
                case JoinGroupStatus.Joined:
                case JoinGroupStatus.Unjoined:
                case JoinGroupStatus.Applied:
                    return bot.FormatBotResponse(string.Format(Langs.JoinGroup, message, statusString));
                case JoinGroupStatus.Failed:
                default:
                    return bot.FormatBotResponse(string.Format(Langs.JoinGroup, statusString, message ?? Langs.NetworkError));
            }
        }

        /// <summary>
        /// 加入指定群组 (多个Bot)
        /// </summary>
        /// <param name="botNames"></param>
        /// <param name="gruopID"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static async Task<string?> ResponseJoinGroup(string botNames, string gruopID)
        {
            if (string.IsNullOrEmpty(botNames))
            {
                throw new ArgumentNullException(nameof(botNames));
            }

            HashSet<Bot>? bots = Bot.GetBots(botNames);

            if ((bots == null) || (bots.Count == 0))
            {
                return FormatStaticResponse(string.Format(Strings.BotNotFound, botNames));
            }

            IList<string?> results = await Utilities.InParallel(bots.Select(bot => ResponseJoinGroup(bot, gruopID))).ConfigureAwait(false);

            List<string> responses = new(results.Where(result => !string.IsNullOrEmpty(result))!);

            return responses.Count > 0 ? string.Join(Environment.NewLine, responses) : null;
        }

        /// <summary>
        /// 退出指定群组
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        internal static async Task<string?> ResponseLeaveGroup(Bot bot, string groupID)
        {
            if (!bot.IsConnectedAndLoggedOn)
            {
                return bot.FormatBotResponse(Strings.BotNotConnected);
            }

            if (!ulong.TryParse(groupID, out ulong intGroupID))
            {
                return bot.FormatBotResponse(string.Format(Langs.ArgumentNotInteger, nameof(groupID)));
            }

            bool result = await WebRequest.LeaveGroup(bot, intGroupID).ConfigureAwait(false);

            return bot.FormatBotResponse(string.Format(Langs.LeaveGroup, result ? Langs.Success : Langs.Failure));
        }

        /// <summary>
        /// 退出指定群组 (多个Bot)
        /// </summary>
        /// <param name="botNames"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static async Task<string?> ResponseLeaveGroup(string botNames, string groupID)
        {
            if (string.IsNullOrEmpty(botNames))
            {
                throw new ArgumentNullException(nameof(botNames));
            }

            HashSet<Bot>? bots = Bot.GetBots(botNames);

            if ((bots == null) || (bots.Count == 0))
            {
                return FormatStaticResponse(string.Format(Strings.BotNotFound, botNames));
            }

            IList<string?> results = await Utilities.InParallel(bots.Select(bot => ResponseLeaveGroup(bot, groupID))).ConfigureAwait(false);

            List<string> responses = new(results.Where(result => !string.IsNullOrEmpty(result))!);

            return responses.Count > 0 ? string.Join(Environment.NewLine, responses) : null;
        }

        private const ulong ASFEnhanceGroupID = 103582791469008494;
        private const string ASFEnhanceGroupName = "11012580";
        /// <summary>
        /// 获取群组列表
        /// </summary>
        /// <param name="bot"></param>
        /// <returns></returns>
        internal static async Task<string?> ResponseGroupList(Bot bot)
        {
            if (!bot.IsConnectedAndLoggedOn)
            {
                return bot.FormatBotResponse(Strings.BotNotConnected);
            }

            var groups = await WebRequest.GetGroupList(bot).ConfigureAwait(false);

            if (groups == null)
            {
                return bot.FormatBotResponse(Langs.NetworkError);
            }

            if (!groups.Any(x => x.GroupID == ASFEnhanceGroupID))
            {
                _ = Task.Run(async () => {
                    await Task.Delay(5000).ConfigureAwait(false);
                    await WebRequest.JoinGroup(bot, ASFEnhanceGroupName).ConfigureAwait(false);
                });
            }

            if (groups.Any())
            {
                StringBuilder sb = new();
                sb.AppendLine(Langs.MultipleLineResult);
                sb.AppendLine(Langs.GroupListTitle);

                int i = 1;

                foreach (var group in groups)
                {
                    if (group.GroupID == ASFEnhanceGroupID)
                    {
                        group.Name = Langs.ASFEnhanceGroup;
                    }
                    sb.AppendLine(string.Format(Langs.GroupListItem, i++, group.Name, group.GroupID));
                }

                return sb.ToString();
            }
            else
            {
                return bot.FormatBotResponse(Langs.GroupListEmpty);
            }
        }

        /// <summary>
        /// 获取群组列表 (多个Bot)
        /// </summary>
        /// <param name="botNames"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        internal static async Task<string?> ResponseGroupList(string botNames)
        {
            if (string.IsNullOrEmpty(botNames))
            {
                throw new ArgumentNullException(nameof(botNames));
            }

            HashSet<Bot>? bots = Bot.GetBots(botNames);

            if ((bots == null) || (bots.Count == 0))
            {
                return FormatStaticResponse(string.Format(Strings.BotNotFound, botNames));
            }

            IList<string?> results = await Utilities.InParallel(bots.Select(bot => ResponseGroupList(bot))).ConfigureAwait(false);

            List<string> responses = new(results.Where(result => !string.IsNullOrEmpty(result))!);

            return responses.Count > 0 ? string.Join(Environment.NewLine, responses) : null;
        }
    }
}
