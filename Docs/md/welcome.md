---
title: "Welcome"
date: "2024-01-01"
category: "none"
toc: "none"
---

## About DocuPacker

DocuPackerはmarkdown形式で書いた文章を公開、共有するためのツールです。以下のようなシナリオを想定して作成しました

- ローカルマシン上でデバッグ実行し、静的なサイトを生成
- ローカルマシン上でIIS siteを構築し、markdownをチームで共同編集、情報を社内webサイトとして公開

### DucuPacker.Server

DucuPacker.ServerはASP.NET Coreで構成されています。

デバッグ実行中は複数のmarkdown文章を一つのファイル(index.json)にまとめて、client 側のassetフォルダに配置するサービスが稼働しています。markdownの変更を常時監視し、変更を検知するとindex.jsonが即時再生成されます。

IIS siteを構築し、markdownの変更監視をIISのサービスとして稼働させる事も出来ます。

### DucuPacker.Client

DucuPacker.ClientはAngularで実装されています。

DocuPacker.Serverが生成したmarkdownデータ(json形式)を利用して、markdown文章のリスト表示、文章検索、内容閲覧ができます。

## Get Started

TODO

## markdown シンタックスについて

TODO

## DocuPacker 独自の markdown シンタックス

TODO

<small>&copy; Copyright 2022-2024 takumura</small>
