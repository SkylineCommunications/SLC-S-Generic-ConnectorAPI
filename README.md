# Skyline.DataMiner.ConnectorAPI.Generic

## About

This repository contains a minimal ConnectorAPI solution for DataMiner Inter-App communication.

The package exposes a single message type:

- `RawDataMessage`

`RawDataMessage` inherits from `Message` and contains one property:

- `string MessageValue`

## Projects

- `ConnectorAPI`: class library containing `RawDataMessage` and `InterApp.KnownTypes`.