# AM VIN Decoder

AM VIN Decoder is a .NET Core 3.1 library, with supporting applications, for decoding the VINs of Aston Martin vehicles. It currently only supports Gaydon era vehicles, but I'm looking to expand on that.

[![Build Status](https://github.com/LiquidPT/am-vin-decoder/workflows/.NET%20Core/badge.svg)](https://github.com/LiquidPT/am-vin-decoder/actions?query=workflow%3A%22.NET+Core%22)

## Thanks

Thanks goes to Grant Neal and his "[Definitive Guide to New Gaydon Era Aston Martin](http://www.astonmartinreview.co.uk/)". It's a great resource and I used it as a starting point for this data. If you're even thinking about buying an Aston Martin, go buy this book.

## Get up and running with the source code

The main solution is maintained using Visual Studio 2019.

Unit-tests are written using the Visual Studio Unit Test framework and there are no integration tests. Unit tests are, however, used to check the data files. You should just be able to:

-   `Pull`
-   `Compile`
-   `Run the tests`

Easiest done using:

```
git clone ...
```

and

```
dotnet test src/AmVinDecoder.sln
```

## Running a VIN

Currently there is only a Windows command line utility included in the repo. If you run it, you will be prompted to enter a VIN and it will return summary data.

## Contributing

If you have any data that you would like to contribute, please make the appropriate changes to the data files and submit a pull request. In particular I'm looking for information on the:

-   DBX
-   Vulcan
-   Valkerie
-   more details for the Cygnet
-   pre-Gaydon Aston Martins

If you find any problems, please file an issue. If you can, include the VIN that the issue was found with. This would include things like:

-   An error being thrown
-   Data missing
-   Incorrect data
