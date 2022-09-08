
- You may choose to target Android or iOS as primary platform - bonus if it works well on both ;)
- Feel free to add / remove / upgrade / downgrade nuget packages to help you with your task
- Recommendation is not to spend more than 4 - 5 hours on this task. If incomplete, just add some notes as to your intent for what you did do.

# Dojo Challenge #1

**Paged Collection View**

## Instructions

Implement a collection view for a collection of cars (see some of the Experiments pages). The layout should preferably look like the FlexLayoutPage example, but swiping behavior similar to a Carousel Page where you swipe 2 columns at a time, or like the CollectionView GridLayout example where it snaps into place.

*Hint*: Download the ChartBuilder app on iOS and see how a chart scrolls between pages.
=======

- Use the /Challenges/PagedCollectionPage.xaml for your implementation
- Implement carousel paging for a 2-column page, but where each element stacks like in the FlexLayoutPage example
- Use the CarView as the item template
- All items in a column should be visible (no vertical scrolling necessary)
- If you collapse a column, the items should shift as in the FlexLayoutPage example.
- No rules for how you achieve this (there is no single right answer):

For Example, you can choose to use a Carousel View that contains flex layouts by splitting the collection,	or by implementing a snap behavior for a flex layout that scrolls to the next 2 columns on swipe.

#### Stretch Goals

- The implementation should cater for template resizing (tap the circle to collapse the template)
- Implement in iOS as well

# Dojo Challenge #2

**Update the Xaml**

## Instructions

- Using the ListView Page:
- add an expand / collapse animation when tapping the circle
- When the car type is a Mercedes, it should load a different view (not the CarView) that contains a description in OpenSans font, and a gradient background
- Add a swipe action to delete a row
- When the device orientation changes to landscape layout, the list should scroll horizontally, not vertically (long-press to present the user with a "do you want to delete? dialog")

#### Stretch Goals

- When the ListView Page loads, the device status bar should not be visible


=======
- No rules for how you achieve this (there is no one correct way to do this)

For Example, you can choose to use a Carousel View that contains flex layouts by splitting the collection,	or by implementing a snap behavior for a flex layout that scrolls to the next 2 columns on swipe.

- Target iOS or Android as a primary platform
- Feel free to add / remove / upgrade / downgrade nuget packages to help you with your task
- Recommendation is not to spend more than 4 - 5 hours on this task. If incomplete, just add some notes as to your intent for what you did do.

#### Stretch Goals

- The implementation should cater for template resizing (tap the circle to collapse the template)
- Implement in Android or iOS as well