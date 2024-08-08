以下是该文档的中文翻译：

# 英超联赛 MAUI 应用  [![英文](https://img.shields.io/badge/Language-English-blue.svg)](README.md) [![中文](https://img.shields.io/badge/Language-中文-red.svg)](README.zh-CN.md) [![韩文](https://img.shields.io/badge/Language-한국어-green.svg)](README.ko.md)

使用 .NET MAUI 实现的跨平台英超联赛学习应用
[![许可证: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/download)
[![星标](https://img.shields.io/github/stars/jamesnet214/maui-premierleague.svg)](https://github.com/jamesnet214/maui-premierleague/stargazers)
[![问题](https://img.shields.io/github/issues/jamesnet214/maui-premierleague.svg)](https://github.com/jamesnet214/maui-premierleague/issues)

## 项目概述

这个英超联赛应用是一个使用 .NET MAUI（多平台应用 UI）实现的以学习为中心的项目。它特别适合从 WPF 转向跨平台开发的开发者，帮助他们理解 MAUI 和 WPF 之间的相似之处和差异。

<img width="400" alt="Tables" src="https://user-images.githubusercontent.com/52397976/193004770-75654ac4-ab56-4f4d-bd63-416110b94b18.png"> <img width="400" alt="Results" src="https://user-images.githubusercontent.com/52397976/193004945-4a76f3e2-3583-47e7-aef3-3dc10a265d3e.png">

## 主要技术和实现

#### 1. MVVM 架构
- [x] 不使用第三方框架的纯 MVVM 实现
- [x] 数据绑定和命令的恰当使用

#### 2. UI 组件和样式
- [x] 实现用于导航的 TabBar
- [x] 使用 CollectionView 实现高效的列表渲染
- [x] 自定义 DataTemplate 实现灵活的 UI 设计
- [x] 内置主题实现

#### 3. 跨平台设计
- [x] 响应式布局适应各种屏幕尺寸
- [x] 必要时进行平台特定适配

#### 4. 资源管理
- [x] 利用 .svg 资源实现可扩展图形
- [x] 实现自定义形状的 Geometry

#### 5. MAUI 特有功能
- [x] 探索 MAUI 特有控件和 API
- [x] 演示原生功能的平台调用 (P/Invoke)

## 技术栈
- .NET 8.0
- .NET MAUI
- C# 10.0
- MVVM (Model-View-ViewModel) 模式

## 入门指南

### 先决条件
- Visual Studio 2022 或更高版本（适用于 Windows）
- JetBrains Rider（适用于 Windows 或 macOS）
- .NET 8.0 SDK
- 安装 MAUI 工作负载

### 安装和运行

#### 1. 克隆仓库：
```
git clone https://github.com/jamesnet214/maui-premierleague.git
```

#### 2. 打开解决方案
- [x] Visual Studio（仅限 Windows）
- [x] JetBrains Rider（Windows 和 macOS）

<img src="https://github.com/user-attachments/assets/af70f422-7057-4e77-a54d-042ee8358d2a" width="24%"/>
<img src="https://github.com/user-attachments/assets/e4feaa10-a107-4b58-8d13-1d8be620ec62" width="24%"/>
<img src="https://github.com/user-attachments/assets/5ff487f6-55e4-43e1-9abf-f8d419ee6943" width="24%"/>
<img src="https://github.com/user-attachments/assets/153143f8-2e76-4dca-b056-2a405aaf6a78" width="24%"/>

#### 3. 构建和运行
- [x] Windows 11
- [x] macOS
- [x] iOS（模拟器或真机）
- [x] Android（模拟器或真机）

## WPF 开发者的学习要点

1. **熟悉的 XAML**：MAUI 使用 XAML，WPF 开发者可以轻松过渡。
2. **跨平台考虑**：学习如何设计在不同平台上运行的 UI。
3. **移动优先方法**：理解从桌面中心到移动优先设计的转变。
4. **性能优化**：探索移动设备上的应用性能优化技术。
5. **平台特定功能**：学习如何在保持共享代码库的同时实现平台特定功能。

## 项目结构
- **Views**：包含 XAML 页面和用户控件
- **ViewModels**：实现表示逻辑
- **Models**：定义数据模型和业务逻辑
- **Services**：包含数据访问和其他服务
- **Resources**：存储共享资源，如样式和图像

## 贡献

如果您想为项目改进做出贡献，请发送 Pull Request。我们欢迎任何形式的贡献！

## 许可证

本项目基于 MIT 许可证发布。详情请参阅 [LICENSE](https://github.com/jamesnet214/maui-premierleague/blob/main/LICENSE) 文件。

## 联系方式
- 网站：https://jamesnet.dev
- 电子邮件：james@jamesnet.dev, vickyqu115@hotmail.com

通过这个英超联赛应用探索 MAUI 的跨平台开发世界！

## 额外资源
[.NET Conf 2022.09 by .NET Dev](https://www.youtube.com/watch?v=Z6Z3qgHYaOg&t=16427s)
