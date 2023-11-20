# LnkParse-dotnet
Simple wrapper around the Lnk library for generating readable metadata of LNK file

## Usage

```
LnkParse-dotnet 1.0.0+239c36599c85f6dc8dc8aa02e645d818ed84bfdb
Copyright (C) 2023 LnkParse-dotnet

  -i, --input     Required. The target to be parsed.

  -o, --output    Output JSON file path.

  --help          Display this help screen.

  --version       Display version information.
```

Sample output

```
{
  "TargetIDs": [
    {
      "FriendlyName": "Root folder: GUID",
      "Value": "My Computer",
      "ExtensionBlocks": []
    },
    {
      "FriendlyName": "Drive letter",
      "Value": "D:",
      "ExtensionBlocks": []
    },
    {
      "FriendlyName": "Directory",
      "Value": "mega",
      "ExtensionBlocks": [
        {
          "Size": 58,
          "Version": 9,
          "Signature": 3203334148,
          "VersionOffset": 20
        }
      ]
    }
  ],
  "ExtraBlocks": [
    {},
    {},
    {}
  ],
  "SourceCreated": "2023-11-19T09:06:21.8469355+00:00",
  "SourceModified": "2023-11-19T09:06:21.8474355+00:00",
  "SourceAccessed": "2023-11-20T03:26:06.0131878+00:00",
  "CommonPath": "",
  "LocalPath": "D:\\mega",
  "VolumeInfo": {
    "DriveType": 3,
    "Size": 24,
    "VolumeSerialNumber": "2F076E60",
    "VolumeLabelOffset": 16,
    "VolumeLabel": "General"
  },
  "NetworkShareInfo": null,
  "SourceFile": "C:\\Target.lnk",
  "RawBytes": "[truncated]",
  "Header": {
    "Signature": "00021401-0000-0000-c000-000000000046",
    "DataFlags": 16583,
    "FileAttributes": 17,
    "TargetCreationDate": "2023-11-19T09:06:15.716571+00:00",
    "TargetModificationDate": "2023-11-19T09:06:21.8449355+00:00",
    "TargetLastAccessedDate": "2023-11-19T09:06:21.8459362+00:00",
    "FileSize": 4096,
    "IconIndex": 0,
    "HotKey": "",
    "ShowWindow": 1,
    "Reserved0": 0,
    "Reserved1": 0,
    "Reserved2": 0
  },
  "Name": "Target",
  "RelativePath": null,
  "WorkingDirectory": null,
  "Arguments": null,
  "IconLocation": "C:\\target.exe",
  "LocationFlags": 1
}
```

## Download

See GitHub Actions for [latest CI build](https://github.com/Still34/LnkParse-dotnet/actions/workflows/dotnet.yml)
