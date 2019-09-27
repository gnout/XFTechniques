# XFTechniques
Techniques for Xamarin.Forms

## Articles
[Easy full screen Splash for Android](https://xamarininsider.com/2019/04/03/easy-full-screen-splash-for-android/?utm_campaign=Weekly%2BXamarin&utm_medium=email&utm_source=Weekly_Xamarin_201)

## NuGet Packages

* [Acr.UserDialogs 7.0.4](https://github.com/aritchie/userdialogs) - All Projects
* [Newtonsoft.Json 12.0.2](https://www.newtonsoft.com/json) - All Projects

## API Lists

* [Any API](https://any-api.com/)
* [Public APIs](https://github.com/public-apis/public-apis)
* [Browse APIs](https://apis.guru/browse-apis/)
* [Recipe Puppy](http://www.recipepuppy.com/about/api/)

## Custom Controls (Set 01)

### Custom Control Behaviors (Example 01)

Attache a behavior to a custom control. The behavior just checks if the entry contains a valid decimal number. If not, the it turns the font of the entry in red color.  
The idea is based on the `stackoverflow` question that can be found [here](https://stackoverflow.com/questions/56986754/xamarin-forms-how-to-add-behaviors-to-custom-control)

## Various NuGet Packages (Set 02)

### ACR User Dialogs (Example 02)

Very easy way to create dialogs and especially __loading__ screens. One thing to remember is that dialogs cannot be inside loading screens.

## List Views (Set 03)

### Expand / Collapse Tapped Cell (Example 03)

This example is a normal list view (not grouped) with the ability to expand or to show more info when the user presses (or taps) the specific cell.

### Expand / Collapse Grouped List (Example 04)

This example show how to have expand/collapse behavior on a ListView. The example is based on this [article](http://www.compliancestudio.io/blog/xamarin-forms-expandable-listview).  
The example uses MVVM. There is also an alternative that I didn't follow which is in this [article](https://github.com/my-jabin/ExpandableListView-Xamarin)

* It seems that the initialization and the update of the `ObservableCollection` need to be inside a `MainThread.BeginInvokeOnMainThread(() => { });`. I noticed that if it's not then an exception occures when the app is running on a physical device. It doesn't have the same behavior when it is running on a emulator.
* The grouped list has a different behavior from the Android and the iOS. On an iOS device, when a group is expanded then the items that belongs to that group behaves as an independant list as if they don't belong in the entire list. When scrolling up they go below the group heafer instead of pushing the entire list up. There is one other issue with the iOS related to previous. The group header has a default color of gray. With a custom renderer this can be changed to be transparent. The side effect is that the element of that particular will be shown underneath the group header as they scroll up.  On an Android device the behavior is as expected.

### Simple Embedded Data (Example 11)

Simple `ListView` with the data defined in XAML

### Simple ListView API Data (Example 12)

This is a very simple, basic, ListView with data from an API call.  
For the API calls to work there is a Network security configuration (Starting with Android 9 (API level 28), cleartext support is disabled by default)  
In `AndroidManifest.xml` the following entries needs to be added

```xml
  <uses-permission android:name="android.permission.INTERNET" />
  <application android:label="Etude.Android"
               android:usesCleartextTraffic="true">
  </application>
```

#### List of Public API's

* [GitHub Page](https://github.com/public-apis/public-apis)
* [Any API](https://any-api.com/)

### ListView with Buttons (Example 14)

The example shows how to have usable buttons in a ListView item template connected to MVVM commands.  
The problem is that each ListView item is __NOT__ bound to the `BindingContext` of the page which is `ViewModel` where the `Command` exists, but instead is bound to the items of the `List`.
This example shows how to bound the `buttons` (`images` in this case) to the `BindingContext` of the page and call the commands defined in the MVVM and pass the current item as a parameter.

## Assorted (Set 05)

### Event To Command Behavior (Example 10)

A way to introduce events as commands in MVVM. The theory is in following [site](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/behaviors/reusable/event-to-command-behavior)

### Font Awesome (Example 12)

A tabbed page with icons from font awesome. The font needs to be installe din both platforms
