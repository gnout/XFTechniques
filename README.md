# XFTechniques
Techniques for Xamarin.Forms

## Articles
[Easy full screen Splash for Android](https://xamarininsider.com/2019/04/03/easy-full-screen-splash-for-android/?utm_campaign=Weekly%2BXamarin&utm_medium=email&utm_source=Weekly_Xamarin_201)

## NuGet Packages

* [Acr.UserDialogs 7.0.4](https://github.com/aritchie/userdialogs) - All Projects

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
