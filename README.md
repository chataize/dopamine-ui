![hero](https://github.com/chataize/dopamine-ui/assets/124832798/302f8f3b-73e0-40b3-82ce-d9997bfb0a88)

# Dopamine UI
An aesthetic C# .NET Blazor component library that makes the UI seamless and entertaining to use.

## Installation
### NuGet Package
#### .NET CLI
```bash
dotnet add package ChatAIze.DopamineUI
```
#### Package Manager Console
```powershell
Install-Package ChatAIze.DopamineUI
```
### CSS
#### App.razor File
```html
<head>
  <!-- ... -->
  <link rel="stylesheet" href="_content/ChatAIze.DopamineUI/css/tailwind.css">
  <!-- ... -->
</head>
```
> [!NOTE]
> Dopamine UI is built with [Tailwind CSS](https://tailwindcss.com), however, you don't have to install, set up, or use Tailwind CSS by yourself. All styles are already pre-generated and included in the NuGet package.

## Usage
For detailed examples, see our [preview](https://github.com/chataize/dopamine-ui/blob/main/preview/Components/Pages/Home.razor) app.
### Table of Contents
- [Button](#button)
- [Text Field](#text-field)
- [Text Area](#text-area)
- [Toggle Switch](#toggle-switch)
- [Checkbox](#checkbox)
- [Radio Button](#radio-button)
- [Divider](#divider)
### Button
#### Standard
```cs
<DPButton Text="Sign In" />
```
#### Full Width
```cs
<DPButton Text="Sign In" IsFullWidth="true" />
```
#### Accent
```cs
<DPButton Text="Create Account" Style="ButtonStyle.Accent" />
```
#### Destructive
```cs
<DPButton Text="Delete Account" Style="ButtonStyle.Destructive" />
```
#### Loading
```cs
<DPButton Text="Download" IsLoading="true" />
```
#### Disabled
```cs
<DPButton Text="Upgrade" IsDisabled="true" />
```
### Text Field
#### Unlabeled
```cs
<DPTextField @bind-Value="Text" />
```
#### Standard
```cs
 <DPTextField Label="Username" @bind-Value="Text" />
```
#### Email
```cs
 <DPTextField Label="Email" Type="TextFieldType.Email" @bind-Value="PropertyABC123" />
```
#### Password
```cs
 <DPTextField Label="Password" Type="TextFieldType.Password" @bind-Value="PropertyABC123" />
```
#### Full Width
```cs
 <DPTextField Label="Title" IsFullWidth="true" @bind-Value="PropertyABC123" />
```
#### Loading
```cs
 <DPTextField Label="Display Name" IsLoading="true" @bind-Value="PropertyABC123" />
```
#### Disabled
```cs
 <DPTextField Label="User ID" IsDisabled="true" @bind-Value="PropertyABC123" />
```
### Text Area
#### Unlabeled
```cs
<DPTextArea @bind-Value="Text" />
```
#### Standard
```cs
 <DPTextArea Label="Description" @bind-Value="Text" />
```
#### Full Width
```cs
 <DPTextArea Label="Description" IsFullWidth="true" @bind-Value="PropertyABC123" />
```
#### Loading
```cs
 <DPTextArea Label="Description" IsLoading="true" @bind-Value="PropertyABC123" />
```
#### Disabled
```cs
 <DPTextArea Label="Description" IsDisabled="true" @bind-Value="PropertyABC123" />
```
### Toggle Switch
#### Unlabeled
```cs
<DPToggleSwitch @bind-value="PropertyABC123" />
```
#### Standard
```cs
<DPToggleSwitch Label="Airplane Mode" @bind-value="PropertyABC123" />
```
#### Full Width
```cs
<DPToggleSwitch Label="Airplane Mode" IsFullWidth="true" @bind-value="PropertyABC123" />
```
#### Framed
```cs
<DPToggleSwitch Label="Airplane Mode" IsFrameVisible="true" @bind-value="PropertyABC123" />
```
#### Disabled
```cs
<DPToggleSwitch Label="Airplane Mode" IsDisabled="true" @bind-value="PropertyABC123" />
```
### Checkbox
#### Unlabeled
```cs
<DPCheckBox @bind-value="PropertyABC123" />
```
#### Standard
```cs
<DPCheckBox Label="Remember Me" @bind-value="PropertyABC123" />
```
#### Full Width
```cs
<DPCheckBox Label="Remember Me" IsFullWidth="true" @bind-value="PropertyABC123" />
```
#### Framed
```cs
<DPCheckBox Label="Remember Me" IsFrameVisible="true" @bind-value="PropertyABC123" />
```
#### Disabled
```cs
<DPCheckBox Label="Remember Me" IsDisabled="true" @bind-value="PropertyABC123" />
```
### Radio Button
#### Unlabeled
```cs
<DPRadioButton @bind-value="PropertyABC123" />
```
#### Standard
```cs
<DPRadioButton Label="Option A" @bind-value="PropertyABC123" />
```
#### Full Width
```cs
<DPRadioButton Label="Option B" IsFullWidth="true" @bind-value="PropertyABC123" />
```
#### Framed
```cs
<DPRadioButton Label="Option C" IsFrameVisible="true" @bind-value="PropertyABC123" />
```
#### Disabled
```cs
<DPRadioButton Label="Option D" IsDisabled="true" @bind-value="PropertyABC123" />
```
### Divider
```cs
<DPDivider />
```
