# MDS Technology UWP App Template 

### How to add New Page
* Project -> Add -> Class 
* Visual C# -> XAML -> Blank Page (ex. Scenario3) 
* Add new Scenario in SampleCongifuration.cs 
  for example :  ,new Scenario() {Title = "Scenario 3", ClassType = typeof(Scenario3)}
* Change Scenario3 Class declaratives 
  for exmaple : public sealed partial class Scenario1 : Page, IDisposable 
* Add Despose() function, is neccessary to release dependent resources such as memory, Hardware. 
  public void Dispose() {}
* Declare OnNavigatedFrom(), OnNavigatedTo() function 
  protected override void OnNavigatedTo(NavigationEventArgs e) {}
  protected override void OnNavigatedFrom(NavigationEventArgs e) {}
  Better to implement Dispose() in OnNavigatedFrom 
**Note** You can refer to Scenario1.xaml.cs file for default implementation. 
   


 