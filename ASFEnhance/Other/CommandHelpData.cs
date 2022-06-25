﻿namespace ASFEnhance.Other
{
    internal static class CommandHelpData
    {
        internal static readonly Dictionary<string, string> CommandArges = new() {
            // 更新
            { "ASFENHANCE", ""},
            { "ASFEVERSION", "" },
            { "ASFEUPDATE", "" },
            // 账号
            { "PURCHASEHISTORY", "[Bots]"},
            { "FREELICENSES", "[Bots]"},
            { "FREELICENSE", "[Bots]"},
            { "LICENSES", "[Bots]"},
            { "LICENSE", "[Bots]"},
            { "REMOVEDEMOS", "[Bots]"},
            { "REMOVEDEMO", "[Bots]"},
            { "REMOVELICENSES", "[Bots] <SubIDs>"},
            { "REMOVELICENSE", "[Bots] <SubIDs>"},
            // 其他
            { "KEY", "<Text>"},
            { "ASFEHELP", "ASFEHELP" },
            { "HELP", "<Command>" },
            // 群组
            { "GROUPLIST", "[Bots]"},
            { "JOINGROUP", "[Bots] <GroupName>"},
            { "LEAVEGROUP", "[Bots] <GroupID>"},
            // 个人资料
            { "PROFILE", "[Bots]"},
            { "PROFILELINK", "[Bots]"},
            { "STEAMID", "[Bots]"},
            { "FRIENDCODE", "[Bots]"},
            // 愿望单
            { "ADDWISHLIST", "[Bots] <AppIDs>"},
            { "REMOVEWISHLIST", "[Bots] <AppIDs>"},
            // 商店
            { "APPDETAIL", "[Bots] <AppIDS>"},
            { "SEARCH", "[Bots] Keywords"},
            { "SUBS", "[Bots] <AppIDS|SubIDS|BundleIDS>"},
            { "PUBLISHRECOMMENT", "[Bots] <AppIDS> COMMENT"},
            { "DELETERECOMMENT", "[Bots] <AppIDS>"},
            // 购物车
            { "CART", "[Bots]"},
            { "ADDCART", "[Bots] <SubIDs|BundleIDs>"},
            { "CARTRESET", "[Bots]"},
            { "CARTCOUNTRY", "[Bots]"},
            { "SETCOUNTRY", "[Bots] <CountryCode>"},
            { "PURCHASE", "[Bots]"},
            { "PURCHASEGIFT", "[BotA] BotB"},
        };

        internal static readonly Dictionary<string, string> CommandUsage = new() {
            // 更新
            { "ASFENHANCE", "查看 ASFEnhance 的版本"},
            { "ASFEVERSION", "检查 ASFEnhance 的最新版本" },
            { "ASFEUPDATE", "自动更新 ASFEnhance 到最新版本 (需要手动重启 ASF)" },
            // 账号
            { "PURCHASEHISTORY", "读取商店消费历史记录"},
            { "FREELICENSES", "读取账户中的免费 Sub License 列表"},
            { "FREELICENSE", "同 FREELICENSES"},
            { "LICENSES", "读取账户中的所有 License 列表"},
            { "LICENSE", "同 LICENSES"},
            { "REMOVEDEMOS", "移除账户中所有的 Demo License"},
            { "REMOVEDEMO", ""},
            { "REMOVELICENSES", "移除账户中指定的 Sub License"},
            { "REMOVELICENSE", "同 REMOVELICENSES"},
            // 其他
            { "KEY", "从文本提取 key"},
            { "ASFEHELP", "查看全部指令说明" },
            { "HELP", "查看指令说明" },
            // 群组
            { "GROUPLIST", "查看机器人的群组列表"},
            { "JOINGROUP", "加入指定群组"},
            { "LEAVEGROUP", "离开指定群组"},
            // 社区
            { "PROFILE", "查看个人资料"},
            { "PROFILELINK", "查看个人资料链接"},
            { "STEAMID", "查看 steamID"},
            { "FRIENDCODE", "查看好友代码"},
            // 愿望单
            { "ADDWISHLIST", "添加愿望单"},
            { "REMOVEWISHLIST", "移除愿望单"},
            // 商店
            { "APPDETAIL", "获取 APP 信息, 无法获取锁区游戏信息, 仅支持APP"},
            { "SEARCH", "搜索商店"},
            { "SUBS", "查询商店 SUB, 支持APP/SUB/BUNDLE"},
            { "PUBLISHRECOMMENT", "发布评测, APPID > 0 给好评, AppID < 0 给差评"},
            { "DELETERECOMMENT", "删除评测"},
            // 购物车
            { "CART", "查看机器人购物车"},
            { "ADDCART", "添加购物车, 仅能使用SubID和BundleID"},
            { "CARTRESET", "清空购物车"},
            { "CARTCOUNTRY", "获取购物车可用结算区域(跟账号钱包和当前 IP 所在地有关)"},
            { "SETCOUNTRY", "购物车改区,可以用CARTCOUNTRY命令获取当前可选的CountryCode(仍然有 Bug)"},
            { "PURCHASE", "结算机器人的购物车, 只能为机器人自己购买 (使用 Steam 钱包余额结算)"},
            { "PURCHASEGIFT", "结算机器人 A 的购物车, 发送礼物给机器人 B (使用 Steam 钱包余额结算)"},
        };

        internal static readonly Dictionary<string, string> ShortCmd2FullCmd = new() {
            // 更新
            { "ASFE", "ASFENHANCE" },
            { "AV", "ASFEVERSION" },
            { "AU", "ASFEUPDATE" },
            // 账号
            { "PH", "PURCHASEHISTORY" },
            { "FL", "FREELICENSES" },
            { "L", "LICENSES" },
            { "RD", "REMOVEDEMOS" },
            { "RL", "REMOVELICENSES " },
            // 其他
            { "K", "KEY" },
            { "EHELP", "ASFEHELP" },
            // 群组
            { "GL", "GROUPLIST" },
            { "JG", "JOINGROUP" },
            { "LG", "LEAVEGROUP" },
            // 个人资料
            { "PF", "PROFILE" },
            { "PFL", "PROFILELINK" },
            { "SID", "STEAMID" },
            { "FC", "FRIENDCODE" },
            // 愿望单
            { "AW", "ADDWISHLIST" },
            { "RW", "REMOVEWISHLIST" },
            // 商店
            { "AD", "APPDETAIL" },
            { "SS", "SEARCH" },
            { "S", "SUBS" },
            { "PREC", "PUBLISHRECOMMENT" },
            { "DREC", "DELETERECOMMENT" },
            // 购物车
            { "C", "CART" },
            { "AC", "ADDCART" },
            { "CR", "CARTRESET" },
            { "CC", "CARTCOUNTRY" },
            { "SC", "SETCOUNTRY" },
            { "PC", "PURCHASE" },
            { "PCG", "PURCHASEGIFT" },
        };

        internal static readonly Dictionary<string, string> FullCmd2ShortCmd = ShortCmd2FullCmd.ToDictionary(x => x.Value, x => x.Key);
    }
}
