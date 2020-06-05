## TestingBot - SpecFlow Mobile App Testing

TestingBot provides a grid of browsers and mobile devices to run Automated tests.
This example demonstrates how to use SpecFlow and C# to run an Automated Tests with Appium on Mobile Devices, located in the TestingBot Cloud.

### Environment Setup

1. Setup
	* Clone this repository

2. TestingBot Credentials
    * Add your TestingBot Key and Secret as environmental variables. You can find these in the [TestingBot Dashboard](https://testingbot.com/members/).
    ```
    $ export TB_KEY=<your TestingBot Key>
    $ export TB_SECRET=<your TestingBot Secret>
    ```

## Running Tests
* Open the project in Visual Studio and run the test.
  Or use `dotnet test` to run the test from your console.

You will see the test result in the [TestingBot Dashboard](https://testingbot.com/members/)

### Uploading your app for testing
	This example code will use an example `.apk` file. To test your own `.apk` or `.ipa`, please make sure to read our [Mobile App Documentation](https://testingbot.com/support/mobile/help.html).

### Resources
##### [TestingBot Documentation](https://testingbot.com/support/mobile/specflow.html)
##### [Appium Documentation](http://appium.io/)