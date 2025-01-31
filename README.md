# ASFEnhance

[![Codacy Badge](https://app.codacy.com/project/badge/Grade/3d174e792fd4412bb6b34a77d67e5dea)](https://www.codacy.com/gh/chr233/ASFEnhance/dashboard)
![GitHub Workflow Status](https://img.shields.io/github/workflow/status/chr233/ASFEnhance/AutoBuild?logo=github)
[![License](https://img.shields.io/github/license/chr233/ASFEnhance?logo=apache)](https://github.com/chr233/ASFEnhance/blob/master/license)
![GitHub last commit](https://img.shields.io/github/last-commit/chr233/ASFEnhance?logo=github)

[![GitHub Release](https://img.shields.io/github/v/release/chr233/ASFEnhance?logo=github)](https://github.com/chr233/ASFEnhance/releases)
[![GitHub Release](https://img.shields.io/github/v/release/chr233/ASFEnhance?include_prereleases&label=pre-release&logo=github)](https://github.com/chr233/ASFEnhance/releases)
[![GitHub Download](https://img.shields.io/github/downloads/chr233/ASFEnhance/total?logo=github)](https://img.shields.io/github/v/release/chr233/ASFEnhance)

![GitHub Repo stars](https://img.shields.io/github/stars/chr233/ASFEnhance?logo=github)
[![Gitee Stars](https://gitee.com/chr_a1/ASFEnhance/badge/star.svg?theme=dark)](https://gitee.com/chr_a1/ASFEnhance/stargazers)

[![爱发电](https://img.shields.io/badge/爱发电-chr__-ea4aaa.svg?logo=github-sponsors)](https://afdian.net/@chr233)
[![Bilibili](https://img.shields.io/badge/bilibili-Chr__-00A2D8.svg?logo=bilibili)](https://space.bilibili.com/5805394)
[![Steam](https://img.shields.io/badge/steam-Chr__-1B2838.svg?logo=steam)](https://steamcommunity.com/id/Chr_)
[![Steam](https://img.shields.io/badge/steam-donate-1B2838.svg?logo=steam)](https://steamcommunity.com/tradeoffer/new/?partner=221260487&token=xgqMgL-i)

[English Version](README.en.md)

ASFEnhance 介绍 & 使用指南: [https://keylol.com/t804841-1-1](https://keylol.com/t804841-1-1)

## EULA

> 请不要使用本插件来进行不受欢迎的行为, 包括但不限于: 刷好评, 发布广告 等

[注意事项](#插件配置说明)

## 下载链接

> 下载解压后将 "ASFEnhance.dll" 丢进 ASF 目录下的 "plugins" 文件夹即可安装

[GitHub Releases](https://github.com/chr233/ASFEnhance/releases)

## 适配说明

> 使用命令 `ASFEVERSION` / `AV` 可以检查插件更新
>
> 使用命令 `ASFEUPDATE` / `AU` 可以自动更新插件到最新版本 (需要手动重启 ASF)
>
> 标 \* 代表理论上兼容但是未经测试, 如果 ASF 没有修改插件 API 理论上可以向后兼容

| ASFEnhance 版本                                           | 依赖 ASF 版本 | 5.2.4.2 ~ 5.2.6.3 | 5.2.7.7 |
| --------------------------------------------------------- | ------------- | ----------------- | ------- |
| [最新版本](https://github.com/chr233/ASFEnhance/releases) | 5.2.7.7       | ❌                | ✔️      |

<details>
  <summary>历史版本</summary>

| ASFEnhance 版本                                                            | 依赖 ASF 版本 | 5.1.2.5 | 5.2.2.5 | 5.2.3.7 | 5.2.4.2 | 5.2.5.6 | 5.2.6.3 |
| -------------------------------------------------------------------------- | ------------- | ------- | ------- | ------- | ------- | ------- | ------- |
| [1.6.6.622](https://github.com/chr233/ASFEnhance/releases/tag/1.6.6.622)   | 5.2.6.3       | ❌      | ❌      | ❌      | ❌      | ✔️\*    | ✔️      |
| [1.5.20.381](https://github.com/chr233/ASFEnhance/releases/tag/1.5.20.381) | 5.2.5.7       | ❌      | ❌      | ❌      | ❌      | ✔️      |         |
| [1.5.18.304](https://github.com/chr233/ASFEnhance/releases/tag/1.5.18.304) | 5.2.4.2       | ❌      | ❌      | ✔️\*    | ✔️      | ✔️\*    |         |
| [1.5.17.289](https://github.com/chr233/ASFEnhance/releases/tag/1.5.17.289) | 5.2.4.2       | ❌      | ❌      | ✔️\*    | ✔️      | ✔️\*    |         |
| [1.5.16.260](https://github.com/chr233/ASFEnhance/releases/tag/1.5.16.260) | 5.2.4.2       | ❌      | ❌      | ✔️\*    | ✔️      | ✔️\*    |         |
| [1.5.15.257](https://github.com/chr233/ASFEnhance/releases/tag/1.5.15.257) | 5.2.3.7       | ❌      | ❌      | ✔️\*    | ✔️      | ✔️      |         |
| [1.5.14.235](https://github.com/chr233/ASFEnhance/releases/tag/1.5.14.235) | 5.2.2.5       | ❌      | ✔️      | ✔️      | ✔️\*    |         |         |
| [1.5.13.231](https://github.com/chr233/ASFEnhance/releases/tag/1.5.13.231) | 5.1.2.5       | ✔️      | ❌      | ❌      |         |         |         |
| [1.5.12.230](https://github.com/chr233/ASFEnhance/releases/tag/1.5.12.230) | 5.1.2.5       | ✔️      | ❌      | ❌      |         |         |         |

</details>

## 插件配置说明

ASF.json

```json
{
  //ASF 配置
  "CurrentCulture": "...",
  "IPCPassword": "...",
  "...": "...",
  //ASFEnhance 配置
  "ASFEnhance": {
    "EULA": true,
    "Statistic": true,
    "DevFeature": false
  }
}
```

| 配置项       | 类型 | 默认值  | 说明                                                               |
| ------------ | ---- | ------- | ------------------------------------------------------------------ |
| `EULA`       | bool | `true`  | 是否同意 [EULA](#EULA)\*                                           |
| `Statistic`  | bool | `true`  | 是否允许发送统计数据, 仅用于统计插件用户数量, 不会发送任何其他信息 |
| `DevFeature` | bool | `false` | 是否启用开发者特性 (一共 3 条命令) `具有一定安全风险, 请谨慎开启`  |

> \* 同意 EULA 后, ASFEnhance 将会开放全部命令, 作为交换, ASFEnhance 会在执行 `GROUPLIST` 和 `CURATORLIST` 时自动关注作者的[鉴赏家](https://steamcommunity.com/groups/11012580/curation)和[组](https://steamcommunity.com/groups/11012580) (如果尚未关注的话)
>
> \* 禁用 EULA 后, ASFEnhance 将会限制使用 鉴赏家/群组/评测 等功能, 同时 ASFEnhance 也不会主动关注[鉴赏家](https://steamcommunity.com/groups/11012580/curation)和[组](https://steamcommunity.com/groups/11012580)

## 插件指令说明

### 插件更新

| 命令          | 缩写   | 权限            | 说明                                              |
| ------------- | ------ | --------------- | ------------------------------------------------- |
| `ASFENHANCE`  | `ASFE` | `FamilySharing` | 查看 ASFEnhance 的版本                            |
| `ASFEVERSION` | `AV`   | `Operator`      | 检查 ASFEnhance 是否为最新版本                    |
| `ASFEUPDATE`  | `AU`   | `Owner`         | 自动更新 ASFEnhance 到最新版本 (需要手动重启 ASF) |

### 账号相关

| 命令                             | 缩写 | 权限       | 说明                              |
| -------------------------------- | ---- | ---------- | --------------------------------- |
| `PURCHASEHISTORY [Bots]`         | `PH` | `Operator` | 读取商店消费历史记录              |
| `FREELICENSES [Bots]`            | `FL` | `Operator` | 读取账户中的免费 Sub License 列表 |
| `FREELICENSE [Bots]`             |      |            | 同 `FREELICENSES`                 |
| `LICENSES [Bots]`                | `L`  | `Operator` | 读取账户中的所有 License 列表     |
| `LICENSE [Bots]`                 |      |            | 同 `LICENSES`                     |
| `REMOVEDEMOS [Bots]`             | `RD` | `Master`   | 移除账户中所有的 Demo License     |
| `REMOVEDEMO [Bots]`              |      |            | 同 `REMOVEDEMOS`                  |
| `REMOVELICENSES [Bots] <SubIDs>` | `RL` | `Master`   | 移除账户中指定的 Sub License      |
| `REMOVELICENSE [Bots] <SubIDs>`  |      |            | 同 `REMOVELICENSES`               |

### 其他功能

| 命令             | 缩写    | 权限            | 说明             |
| ---------------- | ------- | --------------- | ---------------- |
| `KEY <Text>`     | `K`     | `FamilySharing` | 从文本提取 key   |
| `ASFEHELP`       | `EHELP` | `FamilySharing` | 查看全部指令说明 |
| `HELP <Command>` | -       | `FamilySharing` | 查看指令说明     |

### 群组相关

| 命令                           | 缩写 | 权限            | 说明                 |
| ------------------------------ | ---- | --------------- | -------------------- |
| `GROUPLIST [Bots]`             | `GL` | `FamilySharing` | 查看机器人的群组列表 |
| `JOINGROUP [Bots] <GroupName>` | `JG` | `Master`        | 加入指定群组         |
| `LEAVEGROUP [Bots] <GroupID>`  | `LG` | `Master`        | 离开指定群组         |

> `GroupID`可以用命令`GROUPLIST`获取

### 个人资料相关

| 命令                 | 缩写  | 权限            | 说明             |
| -------------------- | ----- | --------------- | ---------------- |
| `PROFILE [Bots]`     | `PF`  | `FamilySharing` | 查看个人资料     |
| `PROFILELINK [Bots]` | `PFL` | `FamilySharing` | 查看个人资料链接 |
| `STEAMID [Bots]`     | `SID` | `FamilySharing` | 查看 steamID     |
| `FRIENDCODE [Bots]`  | `FC`  | `FamilySharing` | 查看好友代码     |
| `TRADELINK [Bots]`   | `TL`  | `Operator`      | 查看交易链接     |

### 鉴赏家相关

| 命令                             | 缩写   | 权限     | 说明                   |
| -------------------------------- | ------ | -------- | ---------------------- |
| `CURATORLIST [Bots]`             | `CL`   | `Master` | 查看已关注的鉴赏家列表 |
| `FOLLOWCURATOR [Bots] <ClanIDs>` | `FCU`  | `Master` | 关注指定鉴赏家         |
| `UNFOLLOWCURATOR [Bots]`         | `UFCU` | `Master` | 取消关注指定鉴赏家     |

### 愿望单相关

| 命令                             | 缩写  | 权限     | 说明                    |
| -------------------------------- | ----- | -------- | ----------------------- |
| `ADDWISHLIST [Bots] <AppIDs>`    | `AW`  | `Master` | 添加愿望单              |
| `REMOVEWISHLIST [Bots] <AppIDs>` | `RW`  | `Master` | 移除愿望单              |
| `FOLLOWGAME [Bots] <AppIDs>`     | `FG`  | `Master` | 关注游戏                |
| `UNFOLLOWGAME [Bots] <AppIDs>`   | `UFG` | `Master` | 取消关注游戏            |
| `CHECK [Bots] <AppIDs>`          | `CK`  | `Master` | 检查游戏关注/愿望单情况 |

### 商店相关

| 命令                                       | 缩写   | 权限       | 说明                                             |
| ------------------------------------------ | ------ | ---------- | ------------------------------------------------ |
| `APPDETAIL [Bots] <AppIDs>`                | `AD`   | `Operator` | 获取 APP 信息, 无法获取锁区游戏信息, 仅支持`APP` |
| `SEARCH [Bots] Keywords`                   | `SS`   | `Operator` | 搜索商店                                         |
| `SUBS [Bots] <AppIDs\|SubIDs\|BundleIDs>`  | `S`    | `Operator` | 查询商店 SUB, 支持`APP/SUB/BUNDLE`               |
| `PUBLISHRECOMMENT [Bots] <AppIDs> COMMENT` | `PREC` | `Master`   | 发布评测, APPID > 0 给好评, AppID < 0 给差评     |
| `DELETERECOMMENT [Bots] <AppIDs>`          | `DREC` | `Master`   | 删除评测                                         |

### 购物车相关

> STEAM 的购物车储存在 Cookies 里,重启 ASF 将会导致购物车清空

| 命令                                 | 缩写  | 权限       | 说明                                                                      |
| ------------------------------------ | ----- | ---------- | ------------------------------------------------------------------------- |
| `CART [Bots]`                        | `C`   | `Operator` | 查看机器人购物车                                                          |
| `ADDCART [Bots] <SubIDs\|BundleIDs>` | `AC`  | `Operator` | 添加购物车, 仅能使用`SubID`和`BundleID`                                   |
| `CARTRESET [Bots]`                   | `CR`  | `Operator` | 清空购物车                                                                |
| `CARTCOUNTRY [Bots]`                 | `CC`  | `Operator` | 获取购物车可用结算区域(跟账号钱包和当前 IP 所在地有关)                    |
| `SETCOUNTRY [Bots] <CountryCode>`    | `SC`  | `Master`   | 购物车改区,可以用`CARTCOUNTRY`命令获取当前可选的`CountryCode`(仍然有 Bug) |
| `PURCHASE [Bots]`                    | `PC`  | `Owner`    | 结算机器人的购物车, 只能为机器人自己购买 (使用 Steam 钱包余额结算)        |
| `PURCHASEGIFT [BotA] BotB`           | `PCG` | `Owner`    | 结算机器人 A 的购物车, 发送礼物给机器人 B (使用 Steam 钱包余额结算)       |

> Steam 允许重复购买,使用 `PURCHASE` 命令前请自行确认有无重复内容

### 探索队列

| 命令              | 缩写 | 权限     | 说明                        |
| ----------------- | ---- | -------- | --------------------------- |
| `EXPLORER [Bots]` | `EX` | `Master` | 5 秒后触发 ASF 探索队列任务 |

> 请尽量让 ASF 自己来探索队列, 本命令仅作为强制触发探索队列的一种补充方式

### ASF 命令缩写

| 命令缩写               | 等价命令                       | 说明                       |
| ---------------------- | ------------------------------ | -------------------------- |
| `AL [Bots] <Licenses>` | `ADDLICENSE [Bots] <Licenses>` | 添加免费 SUB               |
| `LA`                   | `LEVEL ASF`                    | 获取所有机器人的等级       |
| `BA`                   | `BALANCE ASF`                  | 获取所有机器人的钱包余额   |
| `PA`                   | `POINTS ASF`                   | 获取所有机器人的点数余额   |
| `P [Bots]`             | `POINTS`                       | 获取机器人的点数余额       |
| `CA`                   | `CART ASF`                     | 获取所有机器人的购物车信息 |

### 面向开发者

> 本组命令默认是禁用的.
> 需要在 `ASF.json` 中配置 `"DevFeature": true` 才能启用本组命令

| 命令                 | 权限    | 说明                      |
| -------------------- | ------- | ------------------------- |
| `COOKIES [Bots]`     | `Owner` | 查看 Steam 商店的 Cookies |
| `APIKEY [Bots]`      | `Owner` | 查看 Bot 的 APIKey        |
| `ACCESSTOKEN [Bots]` | `Owner` | 查看 Bot 的 ACCESSTOKEN   |

---

[![Repobeats analytics image](https://repobeats.axiom.co/api/embed/df6309642cc2a447195c816473e7e54e8ae849f9.svg "Repobeats analytics image")](https://github.com/chr233/ASFEnhance/pulse)

---
