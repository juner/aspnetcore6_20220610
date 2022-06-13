# aspnetcore6_20220610

自動的に [launchSettings.json](./Web/Properties/launchSettings.json) の1つ目の設定が利用されてしまうため、 [tasks.json](./.vscode/tasks.json) で [launchSettings.json](./Web/Properties/launchSettings.json) で利用されている環境変数の上書きを行う場合、 `--no-launch-profile` パラメータを追加する必要があるというサンプル。

If you want to overwrite the environment variables used in [launchSettings.json](./Web/Properties/launchSettings.json) in [tasks.json](./.vscode/tasks.json), add the `--no-launch-profile` parameter because the first setting in [launchSettings.json](./Web/Properties/launchSettings.json) will be used automatically. A sample that you need.
