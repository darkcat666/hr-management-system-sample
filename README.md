# 人事労務管理システム

従業員や勤怠、給与支払いなどを管理するための人事労務管理システムのサンプル

# セットアップ

### バックエンド
1. `backend`ディレクトリまで飛ぶ
2. `.gradleew BootRun`と入力し、Spring Bootアプリケーションを立ち上げる。

### フロントエンド
1. `HRManagementSystem.sln`をVisual Studioで立ち上げる。
2. WPFアプリケーションでビルドして起動する。

### Docker

Dockerを使ってバックエンドとフロントエンドの両方を立ち上げる場合, `docker-compose.yml`を活用し、以下を入力する。 :

```sh
docker-compose up --build