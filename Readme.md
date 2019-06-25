# 《基于 docker-compose 实践 .NET Core 的现代化架构》系列文章源码

## 前言

本系列文章所要做出的演示架构基于 .NET Core Web Api、MSSQL、Skywalking 和 nginx ，这些都会通过`docker-compose`一键创建/启动容器，然后用 `Azure DevOps` 发布上线。

所以本系列文章重点并不是如何写好`.NET Core`，而是**围绕着 .NET Core 的容器化架构加上一部分 DevOps 的实践**。

## 系列大纲

点击即可查看文章

1. [用 `docker-compose` 启动`WebApi`和`SQL Server`](https://siegrain.wang/article/2019/06/24/launch-netcore-webapi-and-sqlserver-by-docker-compose)
2. 在容器中集成`Skywalking` APM
3. 通过`nginx-proxy`对 `ES`、`Skywalking`、`WebApi`实现自动反向代理和`HTTPS`
4. 通过`Azure DevOps`进行`CI/CD`和蓝绿发布
