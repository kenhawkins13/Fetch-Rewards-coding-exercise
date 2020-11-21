"# Fetch-Rewards-coding-exercise"

Given Fetch Rewards native application for Android device (APK link)
Create an initial test automation framework design to test FetchRewards app. And add a fully
functioning automated test case that following scenario:
Scenario:
1. Open app.
2. Click on Sign up with email button
3. Fill out the form with random valid values and submit
~~4. Verify you landed on second step of registration~~
4. Verify that when you enter an already existing email, you get a warning
   - While creating this test, I did not want to constantly create new accounts with random GUIDs on your server so I changed the test to assert that the dialog appears instead, "Oops! An acount with this email address alread exists."

NOTE: Please, use Google Pixel 2 API 28 with PlayStore emulator or real Android device to
successfully create test cases and run the application.

To run the test:
1. Open the solution in Visual Studio
2. Build the solution in Visual Studio
3. Have an Android emulator running for Google Pixel 2 API 28 (I used Android Studio to emulate)
4. Have the Appium server running on the default port (http://127.0.0.1:4723)
3. Run the automated test in Visual Studio

