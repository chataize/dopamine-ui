![hero](https://github.com/chataize/dopamine-ui/assets/124832798/302f8f3b-73e0-40b3-82ce-d9997bfb0a88)

# Dopamine UI
Aesthetic C# .NET Blazor component library that makes UI seamless and entertaining to use.

## Requirements
- .NET 10 (net10.0).
- Blazor Server or Blazor Web App (Interactive Server).

## Installation
### NuGet
```bash
dotnet add package ChatAIze.DopamineUI
```

```powershell
Install-Package ChatAIze.DopamineUI
```

## Setup
### Add CSS
Include the Dopamine UI stylesheet in your app head.

Blazor Server / Web App (App.razor):
```html
<head>
  <!-- ... -->
  <link rel="stylesheet" href="_content/ChatAIze.DopamineUI/css/tailwind.css">
  <!-- ... -->
</head>
```

### Serve static assets
Loading indicators and some visuals are delivered as static web assets. Ensure static assets are mapped:
```csharp
app.MapStaticAssets();
```

### Add imports
Add these to your app `_Imports.razor`:
```razor
@using ChatAIze.Abstractions.UI
@using ChatAIze.DopamineUI
@using ChatAIze.DopamineUI.Components
@using ChatAIze.DopamineUI.Enums
@using ChatAIze.DopamineUI.Interfaces
@using Microsoft.AspNetCore.Components.Web
```

## Quick start
```razor
@page "/"

<DPPage Title="Welcome">
    <DPCard Label="Sign in" IsFullWidth="true">
        <DPTextField Label="Email" Type="TextFieldType.Email" @bind-Value="email" />
        <DPTextField Label="Password" Type="TextFieldType.Password" @bind-Value="password" />
        <DPButton Style="ButtonStyle.Primary" IsLoading="isSaving" Clicked="SaveAsync">
            Sign in
        </DPButton>
    </DPCard>
</DPPage>

@code {
    private string email = string.Empty;
    private string password = string.Empty;
    private bool isSaving;

    private async Task SaveAsync()
    {
        isSaving = true;
        try
        {
            await Task.Delay(500);
        }
        finally
        {
            isSaving = false;
        }
    }
}
```

## Best practices
- Prefer `@bind-Value` over manual `Value` and `ValueChanged` wiring for inputs.
- Use `IsLoading` on interactive components to block multiple submissions and show feedback.
- Use `DPGroup` or `DPPage` to cascade `IsDisabled` through a subtree.
- Use stable equality for generic components (`DPDropDown<T>`, `DPSegmentedControl<T>`, `DPRadioGroup<T>`).
- Provide `From`/`To` ranges for `DPDatePicker` to avoid invalid selections.
- Use `Tag` to attach view models or IDs without rendering them.

## Supporting types
- `LoadingIndicatorSize` controls `DPLoadingIndicator` size.
- `ScreenSize` provides Tailwind-aligned breakpoints for `DPAdaptiveView` and `DPBreakpoint`.
- `TailwindColor` is used by `DPColorPicker`.
- `I1ColumnRepresentable` through `I5ColumnRepresentable` are used by `DPTable<T>`.
- `ITaggable` provides a `Tag` property on most components for user metadata.

## Component reference

### Layout and structure

#### DPPage
Page wrapper that sets the document title and renders a loading overlay.

Parameters:
- `Title`: Title text. When set, it updates `<PageTitle>` and `DPNavigationTitle`.
- `BackUrl`: Back navigation path for `DPNavigationTitle`.
- `ChildContent`: Page content.
- `IsLoading`: Shows `DPLoadingScreen` and disables content.
- `IsDisabled`: Disables the page content.
- `Tag`: User data.

Remarks:
- Tip: Use `Title` for consistent page titles across navigation and browser tabs.
- Warning: Loading uses static assets under `/_content/ChatAIze.DopamineUI/img`.

Example:
```razor
<DPPage Title="Dashboard" IsLoading="isLoading">
    <DPHeader>Overview</DPHeader>
</DPPage>
```

#### DPCard
Card container with optional label and loading overlay.

Parameters:
- `Label`: Optional header label.
- `ChildContent`: Card body content.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsTopPaddingExtended`: Adds extra top padding.
- `IsBottomPaddingExtended`: Adds extra bottom padding.
- `IsLoading`: Shows a loading overlay and disables content.
- `IsDisabled`: Disables the card content.
- `Tag`: User data.

Remarks:
- Tip: Combine with `DPGroup` to disable nested content consistently.

Example:
```razor
<DPCard Label="Profile" IsFullWidth="true">
    <DPTextField Label="Display name" @bind-Value="name" />
</DPCard>
```

#### DPGroup
Cascades `IsDisabled` to its children without adding markup.

Parameters:
- `ChildContent`: Group content.
- `IsDisabled`: Disables the group content.
- `Tag`: User data.

Remarks:
- Limitation: No DOM wrapper is rendered.

Example:
```razor
<DPGroup IsDisabled="isBusy">
    <DPButton Clicked="SaveAsync">Save</DPButton>
</DPGroup>
```

#### DPAdaptiveView
Switches between stacked and horizontal layouts based on screen size.

Parameters:
- `ChildContent`: Content to arrange.
- `RequiredSize`: Minimum screen size for horizontal layout.
- `IsDisabled`: Disables child interactions.
- `Tag`: User data.

Remarks:
- Limitation: Uses CSS visibility only; content is always rendered.

Example:
```razor
<DPAdaptiveView RequiredSize="ScreenSize.Large">
    <DPCard>Left</DPCard>
    <DPCard>Right</DPCard>
</DPAdaptiveView>
```

#### DPBreakpoint
Shows or hides content within a breakpoint range.

Parameters:
- `FromSize`: Minimum breakpoint where content becomes visible.
- `ToSize`: Breakpoint where content becomes hidden.
- `ChildContent`: Content to show or hide.
- `IsDisabled`: Disables child interactions.
- `Tag`: User data.

Remarks:
- Limitation: Uses CSS visibility only; content stays in the DOM.

Example:
```razor
<DPBreakpoint FromSize="ScreenSize.Medium" ToSize="ScreenSize.ExtraLarge">
    <DPParagraph>Visible on md to xl.</DPParagraph>
</DPBreakpoint>
```

#### DPOverlay
Overlay container that can show or hide its content.

Parameters:
- `ChildContent`: Overlay content.
- `IsVisible`: Shows the overlay.
- `IsDisabled`: Disables the overlay content.
- `Tag`: User data.

Remarks:
- Warning: No focus trap or body scroll lock is provided.

Example:
```razor
<DPOverlay IsVisible="isOpen">
    <DPCard>Overlay content</DPCard>
</DPOverlay>
```

### Typography and separators

#### DPHeader
Primary heading (h1).

Parameters:
- `ChildContent`: Header text or content.
- `IsDisabled`: Disables the header styling.
- `Tag`: User data.

Remarks:
- Tip: Use semantic headings to improve accessibility and SEO.
- Limitation: This component is purely visual and adds no behavior.

Example:
```razor
<DPHeader>Settings</DPHeader>
```

#### DPSubheader
Secondary heading (h2).

Parameters:
- `ChildContent`: Subheader text or content.
- `IsDisabled`: Disables the subheader styling.
- `Tag`: User data.

Remarks:
- Tip: Use for section titles that follow `DPHeader`.
- Limitation: This component is purely visual and adds no behavior.

Example:
```razor
<DPSubheader>Profile</DPSubheader>
```

#### DPParagraph
Paragraph text.

Parameters:
- `ChildContent`: Paragraph text or content.
- `IsDisabled`: Disables the paragraph styling.
- `Tag`: User data.

Remarks:
- Tip: Use for body text and helper copy.
- Limitation: This component is purely visual and adds no behavior.

Example:
```razor
<DPParagraph>Short helper text.</DPParagraph>
```

#### DPDivider
Horizontal divider.

Parameters:
- `Tag`: User data.

Remarks:
- Limitation: Decorative only, no label or content support.

Example:
```razor
<DPDivider />
```

### Buttons and toggles

#### DPButton
Styled button with optional loading state and caption.

Parameters:
- `ChildContent`: Button content.
- `Caption`: Helper text below the button.
- `Style`: `ButtonStyle` enum value.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsLoading`: Shows a loading indicator and disables click.
- `IsDisabled`: Disables click and styling.
- `Clicked`: Click callback.
- `Tag`: User data.

Remarks:
- Warning: Loading indicator uses static assets under `/_content/ChatAIze.DopamineUI/img`.

Example:
```razor
<DPButton Style="ButtonStyle.Accent" IsLoading="isSaving" Clicked="SaveAsync">
    Save
</DPButton>
```

#### DPToggleButton
Toggleable button for boolean values.

Parameters:
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `ChildContent`: Button content.
- `Caption`: Helper text below the button.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsLoading`: Shows a loading indicator and disables click.
- `IsDisabled`: Disables click and styling.
- `Tag`: User data.

Remarks:
- Tip: Use `@bind-Value` for two-way binding.
- Limitation: Not an `InputBase` component.

Example:
```razor
<DPToggleButton @bind-Value="isOn">
    Toggle
</DPToggleButton>
```

#### DPToggleSwitch
Switch-style toggle for boolean values.

Parameters:
- `Label`: Label next to the switch.
- `Caption`: Helper text below the switch.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `IsBorderless`: Removes the border styling when `true`.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsDisabled`: Disables input and styling.
- `Tag`: User data.

Remarks:
- Limitation: Not an `InputBase` component.

Example:
```razor
<DPToggleSwitch Label="Airplane mode" @bind-Value="isAirplane" />
```

### Text inputs

#### DPTextField
Single-line input with optional Enter callback.

Parameters:
- `Type`: `TextFieldType` enum value.
- `Label`: Label text.
- `Caption`: Helper text below the field.
- `Placeholder`: Placeholder text.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `Size`: Input size attribute.
- `MaxLength`: Maximum length.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsLowercase`: Normalizes input to lowercase.
- `IsReadOnly`: Prevents editing but keeps focus.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables input and styling.
- `Tag`: User data.
- `EnterPressed`: Callback when Enter is pressed.

Remarks:
- Limitation: Not an `InputBase` component, so it does not integrate with `EditForm` validation automatically.

Example:
```razor
<DPTextField Label="Email" Type="TextFieldType.Email" @bind-Value="email" EnterPressed="SearchAsync" />
```

#### DPTextArea
Multi-line text input.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the field.
- `Placeholder`: Placeholder text.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `Size`: Column size.
- `Lines`: Number of visible rows.
- `MaxLength`: Maximum length.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsLowercase`: Normalizes input to lowercase.
- `IsReadOnly`: Prevents editing but keeps focus.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables input and styling.
- `Tag`: User data.

Remarks:
- Limitation: Not an `InputBase` component, so it does not integrate with `EditForm` validation automatically.

Example:
```razor
<DPTextArea Label="Description" Lines="4" @bind-Value="description" />
```

### Selection controls

#### DPCheckBox
Checkbox input.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the checkbox.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `IsBorderless`: Removes the border styling when `true`.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsDisabled`: Disables input and styling.
- `Tag`: User data.

Remarks:
- Limitation: Not an `InputBase` component.

Example:
```razor
<DPCheckBox Label="Remember me" @bind-Value="rememberMe" />
```

#### DPRadioGroup<T> and DPRadioButton<T>
Radio group and radio button options.

Parameters for `DPRadioGroup<T>`:
- `Label`: Group label.
- `Caption`: Helper text below the group.
- `Value`: Current selected value.
- `ValueChanged`: Selection change callback.
- `ChildContent`: Radio button items.
- `IsBorderless`: Removes borders when `true`.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsDisabled`: Disables the group.
- `Tag`: User data.

Parameters for `DPRadioButton<T>`:
- `Label`: Label text.
- `Caption`: Helper text below the radio button.
- `Value`: Value for this option.
- `IsBorderless`: Overrides border styling.
- `IsFullWidth`: Overrides width behavior.
- `IsDisabled`: Disables the option.
- `Tag`: User data.

Remarks:
- Tip: Use simple value types or implement stable equality.

Example:
```razor
<DPRadioGroup T="string" Label="Plan" @bind-Value="plan">
    <DPRadioButton Value="Basic" Label="Basic" />
    <DPRadioButton Value="Pro" Label="Pro" />
</DPRadioGroup>
```

#### DPSegmentedControl<T> and DPSegment<T>
Segmented selector for discrete values.

Parameters for `DPSegmentedControl<T>`:
- `Label`: Group label.
- `Caption`: Helper text below the control.
- `Value`: Current selected value.
- `ValueChanged`: Selection change callback.
- `ChildContent`: Segment items.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsDisabled`: Disables the control.
- `Tag`: User data.

Parameters for `DPSegment<T>`:
- `Value`: Value for this segment.
- `ChildContent`: Segment content.
- `IsDisabled`: Disables the segment.
- `Tag`: User data.

Remarks:
- Tip: Use simple value types or implement stable equality.
- Limitation: No keyboard navigation is provided.

Example:
```razor
<DPSegmentedControl T="string" Label="View" @bind-Value="view">
    <DPSegment Value="List">List</DPSegment>
    <DPSegment Value="Grid">Grid</DPSegment>
</DPSegmentedControl>
```

#### DPDropDown<T> and DPDropDownItem<T>
Dropdown selector for discrete values.

Parameters for `DPDropDown<T>`:
- `Label`: Label text.
- `Caption`: Helper text below the dropdown.
- `Value`: Current selected value.
- `ValueChanged`: Selection change callback.
- `ChildContent`: Dropdown items.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsScrollable`: Enables scrolling for the options list.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables the dropdown.
- `Tag`: User data.

Parameters for `DPDropDownItem<T>`:
- `Value`: Value for this option.
- `ChildContent`: Option content.
- `IsDisabled`: Disables the option.
- `Tag`: User data.

Remarks:
- Tip: Ensure `Equals` is stable for custom value types so selection and labels resolve correctly.
- Limitation: No outside click close or keyboard navigation is provided.

Example:
```razor
<DPDropDown T="string" Label="Theme" @bind-Value="theme">
    <DPDropDownItem Value="Light">Light</DPDropDownItem>
    <DPDropDownItem Value="Dark">Dark</DPDropDownItem>
</DPDropDown>
```

#### DPColorPicker
Palette picker for Tailwind color families.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the picker.
- `Value`: Current selected color.
- `ValueChanged`: Selection change callback.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Limitation: The UI exposes a curated subset of `TailwindColor` values.

Example:
```razor
<DPColorPicker Label="Accent" @bind-Value="accent" />
```

#### DPSpoiler
Expandable section that reveals content when opened.

Parameters:
- `Label`: Header text.
- `ChildContent`: Content revealed when open.
- `IsBottomPaddingExtended`: Adds extra bottom padding when open.
- `IsLoading`: Shows loading styling and disables toggle.
- `IsDisabled`: Disables toggle.
- `Tag`: User data.

Remarks:
- Limitation: The open state is internal and cannot be controlled externally.

Example:
```razor
<DPSpoiler Label="Advanced">
    <DPTextField Label="Secret" />
</DPSpoiler>
```

### Sliders and numeric inputs

#### DPSlider
Range slider for integer values.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the slider.
- `Unit`: Unit suffix.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `Step`: Step size.
- `MinValue`: Minimum value.
- `MinValueLabel`: Custom label for minimum.
- `MaxValue`: Maximum value.
- `MaxValueLabel`: Custom label for maximum.
- `IsShowingValue`: Displays value next to label.
- `IsShowingMaxValue`: Displays maximum next to label.
- `IsShowingPercentage`: Displays percentage next to label.
- `IsFullWidth`: `true` for full width, `false` for fixed, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Limitation: Values outside the range are ignored.

Example:
```razor
<DPSlider Label="Volume" MinValue="0" MaxValue="100" @bind-Value="volume" IsShowingPercentage="true" />
```

#### DPDecimalSlider
Range slider for double values.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the slider.
- `Unit`: Unit suffix.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `Step`: Step size.
- `MinValue`: Minimum value.
- `MinValueLabel`: Custom label for minimum.
- `MaxValue`: Maximum value.
- `MaxValueLabel`: Custom label for maximum.
- `IsShowingValue`: Displays value next to label.
- `IsShowingMaxValue`: Displays maximum next to label.
- `IsShowingPercentage`: Displays percentage next to label.
- `IsFullWidth`: `true` for full width, `false` for fixed, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Limitation: Values outside the range are ignored.

Example:
```razor
<DPDecimalSlider Label="Opacity" MinValue="0" MaxValue="1" Step="0.05" @bind-Value="opacity" />
```

#### DPStepper
Numeric input with increment and decrement buttons.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the stepper.
- `Value`: Current value.
- `ValueChanged`: Value change callback.
- `MinValue`: Minimum value.
- `MaxValue`: Maximum value.
- `Step`: Step size.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Warning: Invalid text input is ignored and may require external validation.

Example:
```razor
<DPStepper Label="Quantity" MinValue="1" MaxValue="10" @bind-Value="quantity" />
```

### Date and time

#### DPDatePicker
Dropdown calendar date picker.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the picker.
- `Value`: Current date value.
- `ValueChanged`: Value change callback.
- `From`: Earliest selectable date (inclusive).
- `To`: Latest selectable date (inclusive).
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Warning: Selected dates are normalized to UTC (TimeSpan.Zero).
- Limitation: There is no text input or keyboard navigation.

Example:
```razor
<DPDatePicker Label="Start" From="minDate" To="maxDate" @bind-Value="startDate" />
```

#### DPTimePicker
Time picker with optional seconds selection.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the picker.
- `Value`: Current time value.
- `ValueChanged`: Value change callback.
- `IsShowingSeconds`: Shows seconds when `true`.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsEdited`: Shows the edit indicator.
- `IsLoading`: Shows a loading indicator and disables input.
- `IsDisabled`: Disables input.
- `Tag`: User data.

Remarks:
- Warning: Uses 24-hour formatting.
- Limitation: Value changes are raised only while the picker is open.

Example:
```razor
<DPTimePicker Label="Time" IsShowingSeconds="true" @bind-Value="time" />
```

### Data display and feedback

#### DPTable<T>
Simple table that renders items implementing column interfaces.

Parameters:
- `Column1` to `Column5`: Column headers.
- `Data`: Data items to render.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsDisabled`: Disables styling.
- `Tag`: User data.

Remarks:
- Tip: Implement `I1ColumnRepresentable` through `I5ColumnRepresentable` for row data.
- Limitation: Column values are strings, and no templating, sorting, paging, or virtualization is provided.

Example:
```razor
<DPTable T="StoreItem" Column1="Item" Column2="Price" Column3="Qty" Data="items" />
```

#### DPProgressBar
Progress bar with optional labels.

Parameters:
- `Label`: Label text.
- `Caption`: Helper text below the bar.
- `Unit`: Unit suffix.
- `Value`: Current value.
- `ZeroLabel`: Label shown at zero.
- `MaxValue`: Maximum value.
- `MaxValueLabel`: Label shown at maximum.
- `IsShowingValue`: Shows numeric value.
- `IsShowingMaxValue`: Shows maximum value.
- `IsShowingPercentage`: Shows percentage.
- `IsFullWidth`: `true` for full width, `false` for fixed, `null` for responsive.
- `IsDisabled`: Disables styling.
- `Tag`: User data.

Remarks:
- Limitation: Values are not clamped, so ensure `Value` is within range.

Example:
```razor
<DPProgressBar Label="Upload" Value="75" MaxValue="100" IsShowingPercentage="true" />
```

#### DPLoadingIndicator
Animated loading indicator.

Parameters:
- `Size`: `LoadingIndicatorSize` enum value.
- `IsLoading`: When `false`, renders nothing.
- `Tag`: User data.

Remarks:
- Warning: Uses static assets under `/_content/ChatAIze.DopamineUI/img`.

Example:
```razor
<DPLoadingIndicator Size="LoadingIndicatorSize.Medium" />
```

#### DPLoadingScreen
Full-screen loading overlay.

Parameters:
- `IsVisible`: Shows the loading overlay.
- `Tag`: User data.

Remarks:
- Warning: Uses static assets under `/_content/ChatAIze.DopamineUI/img`.

Example:
```razor
<DPLoadingScreen IsVisible="isLoading" />
```

#### DPDialog
Modal dialog surface built on `DPOverlay`.

Parameters:
- `ChildContent`: Dialog content.
- `IsOpen`: Shows the dialog when `true`.
- `IsDisabled`: Disables dialog content.
- `Tag`: User data.

Remarks:
- Warning: No focus trap or ESC handling is provided.

Example:
```razor
<DPDialog IsOpen="isOpen">
    <DPCard>Dialog content</DPCard>
</DPDialog>
```

#### DPSavePrompt
Save/discard prompt for unsaved changes.

Parameters:
- `IsVisible`: Shows the prompt.
- `IsSavePending`: Disables actions and shows loading.
- `IsDisabled`: Disables the prompt.
- `SaveClicked`: Save callback.
- `DiscardClicked`: Discard callback.
- `Tag`: User data.

Remarks:
- Warning: Callbacks should handle concurrency and errors explicitly.

Example:
```razor
<DPSavePrompt IsVisible="hasChanges" IsSavePending="isSaving" SaveClicked="SaveAsync" DiscardClicked="DiscardAsync" />
```

### Menus, navigation, and tabs

#### DPMenu and DPMenuItem
Simple menu container and items.

Parameters for `DPMenu`:
- `ChildContent`: Menu items.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsOpen`: Whether the menu is open.
- `IsOpenChanged`: Open state change callback.
- `IsDisabled`: Disables the menu.
- `Tag`: User data.

Parameters for `DPMenuItem`:
- `ChildContent`: Item content.
- `IsDisabled`: Disables the item.
- `Clicked`: Click callback.
- `Tag`: User data.

Remarks:
- Tip: Use `@bind-IsOpen` for two-way binding, or `DPThreeDots` for a built-in trigger.
- Limitation: No outside click close or keyboard navigation is provided.

Example:
```razor
<DPMenu @bind-IsOpen="isOpen">
    <DPMenuItem Clicked="EditAsync">Edit</DPMenuItem>
    <DPMenuItem Clicked="DeleteAsync">Delete</DPMenuItem>
</DPMenu>
```

#### DPThreeDots
Three-dots icon button that toggles a `DPMenu` internally.

Parameters:
- `ChildContent`: Menu items.
- `IsDisabled`: Disables the trigger.
- `Tag`: User data.

Remarks:
- Limitation: Open state is internal and not externally controlled.

Example:
```razor
<DPThreeDots>
    <DPMenuItem Clicked="EditAsync">Edit</DPMenuItem>
    <DPMenuItem Clicked="DeleteAsync">Delete</DPMenuItem>
</DPThreeDots>
```

#### DPTabView and DPTab
Segmented tab view and tab definition.

Parameters for `DPTabView`:
- `ChildContent`: `DPTab` items.
- `IsFullWidth`: `true` for full width, `false` for fit, `null` for responsive.
- `IsDisabled`: Disables the tab view.
- `Tag`: User data.

Parameters for `DPTab`:
- `Label`: Tab label.
- `ChildContent`: Tab content.
- `IsDisabled`: Disables the tab.
- `Tag`: User data.

Remarks:
- Limitation: Selection state is internal; the first registered tab is selected by default.

Example:
```razor
<DPTabView>
    <DPTab Label="General">
        <DPParagraph>General settings</DPParagraph>
    </DPTab>
    <DPTab Label="Advanced">
        <DPParagraph>Advanced settings</DPParagraph>
    </DPTab>
</DPTabView>
```

#### DPNavigationView
Responsive navigation layout with side menu and mobile toolbar.

Parameters:
- `Logo`: Logo content.
- `Links`: Navigation links.
- `Footer`: Footer content.
- `Content`: Main page content.
- `Title`: Mobile title content.
- `BackUrl`: Back navigation path for mobile.
- `IsDisabled`: Disables the navigation view.
- `Tag`: User data.

Remarks:
- Warning: Mobile menu open state is internal.

Example:
```razor
<DPNavigationView>
    <Logo>
        <DPHeader>Dopamine</DPHeader>
    </Logo>
    <Links>
        <DPNavigationMenuLink Path="/">Home</DPNavigationMenuLink>
        <DPNavigationMenuLink Path="/settings">Settings</DPNavigationMenuLink>
    </Links>
    <Content>
        <DPNavigationTitle BackUrl="/">Settings</DPNavigationTitle>
        <DPPage Title="Settings">
            <DPParagraph>...</DPParagraph>
        </DPPage>
    </Content>
</DPNavigationView>
```

#### DPNavigationTitle
Registers a title and back link for the active navigation view.

Parameters:
- `ChildContent`: Title content.
- `BackUrl`: Back navigation path.
- `Tag`: User data.

Remarks:
- Limitation: Does not render any HTML.

Example:
```razor
<DPNavigationTitle BackUrl="/">Account</DPNavigationTitle>
```

#### DPNavigationLink
Navigation button that uses `NavigationManager` to navigate.

Parameters:
- `Path`: Target URL or route.
- `ChildContent`: Link content.
- `IsFullWidth`: Makes the link full width when `true`.
- `IsDisabled`: Disables navigation.
- `Tag`: User data.

Remarks:
- Tip: Use inside `DPNavigationView` to close the mobile menu on navigation.
- Limitation: No active state styling is provided.

Example:
```razor
<DPNavigationLink Path="/profile" IsFullWidth="true">Profile</DPNavigationLink>
```

#### DPNavigationMenuLink
Navigation menu link with selected state based on the current route.

Parameters:
- `Path`: Target URL or route.
- `ChildContent`: Link content.
- `IsDisabled`: Disables navigation.
- `Tag`: User data.

Remarks:
- Warning: Overlapping path prefixes can mark multiple links as selected.

Example:
```razor
<DPNavigationMenuLink Path="/settings">Settings</DPNavigationMenuLink>
```

### Lists and editors

#### DPListEditor
Editable list of strings with add and remove controls.

Parameters:
- `Items`: List of values.
- `ItemsChanged`: List change callback.
- `ItemPlaceholder`: Placeholder for new items.
- `TextFieldType`: Input type for each item.
- `ShowItemBorders`: Shows card borders around items.
- `MaxItems`: Maximum number of items allowed.
- `MaxItemLength`: Maximum length per item.
- `AllowDuplicates`: Allows duplicate entries when `true`.
- `AddButtonText`: Text for the add button.
- `IsLowercase`: Normalizes item text to lowercase.
- `IsDisabled`: Disables editing.
- `Tag`: User data.

Remarks:
- Warning: External changes to `Items` after initial render are not reflected unless the component is re-created.

Example:
```razor
<DPListEditor Items="tags" ItemsChanged="OnTagsChanged" ItemPlaceholder="Add tag" MaxItems="5" />
```

## License
GPL-3.0-or-later
