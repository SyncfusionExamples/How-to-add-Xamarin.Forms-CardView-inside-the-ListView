# How-to-add-Xamarin.Forms-CardView-inside-the-ListView

This demo sample explains about How to add Xamarin.Forms SfCardView inside the ListView. For more reference, please refer the below KB

[How to add cards to the ListView in Xamarin.Forms](https://www.syncfusion.com/kb/11650/?utm_medium=listing&utm_source=github-examples)

It is a common use case to show the cards in a Xamarin.Forms.ListView. So that UI will be clean, and we need not worry about the memory usage, as the ListView by default handles the UI virtualization.  This section describes how to bind a SfCardView instance for each row in the list.
 
**[XAML]**

```

xmlns:cards="clr-namespace:Syncfusion.XForms.Cards;assembly=Syncfusion.Cards.XForms"
 
..
 
<!--  Binding the View Model  -->
 
    <ContentPage.BindingContext>
        <viewmodel:SocialMediaAppViewModel />
    </ContentPage.BindingContext>
 
<!--  ListView  as parent layout  -->
        <ListView
            x:Name="EventListView"
            ItemsSource="{Binding Items}"
            RowHeight="100"
            SeparatorVisibility="None">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
 
                        <!--  CardView as its DataTemplate  -->
                        <cards:SfCardView Margin="10">
                            <Grid HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
                                <StackLayout Orientation="Horizontal">
                                    <Image
                                        Margin="10,0,0,0"
                                        HeightRequest="40"
                                        Source="{Binding Image}"
                                        WidthRequest="40" />
                                    <Label
                                        Margin="10,0,0,0"
                                        FontAttributes="Bold"
                                        FontSize="16"
                                        HorizontalOptions="Start"
                                        LineBreakMode="NoWrap"
                                        MaxLines="1"
                                        Text="{Binding Title}"
                                        TextColor="Black"
                                        VerticalOptions="Center" />
                                </StackLayout>
                            </Grid>
                        </cards:SfCardView>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
```
 
 **[C#]**
 
 ```

public class SocialMediaAppModel
{
    public string Title {get; set;}
 
    public string Image {get; set;}
}
```

**[C#]**
```

public class SocialMediaAppViewModel
{
   public IEnumerable< SocialMediaAppModel > Items { get; set; }
 
        public SocialMediaAppViewModel ()
        {
            Items = new SocialMediaAppModel []
            {
                new SocialMediaAppModel (){ Title = "Facebook" , Image = "FacebookFill.png"},
                new SocialMediaAppModel (){ Title = "Gmail" , Image = "GmailFill.png"},
                new SocialMediaAppModel (){ Title = "Instagram" , Image = "InstagramFill.png"},
                new SocialMediaAppModel (){ Title = "WhatsApp" , Image = "WhatsappFill.png"},
            };
        }
}

```
 
**See Also**

[How to notify the tapped action on cards](https://help.syncfusion.com/xamarin/cards/events?_ga=2.181702823.1232783100.1593359517-1450022673.1574142796#cardtapped)

[How to dismiss the card programmatically](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.181702823.1232783100.1593359517-1450022673.1574142796#dismiss-the-card-programmatically)

[How to dismiss the card while swiping](https://help.syncfusion.com/xamarin/cards/getting-started?_ga=2.181702823.1232783100.1593359517-1450022673.1574142796#swipetodismiss)

[How to find the visible card index changed](https://help.syncfusion.com/xamarin/cards/events?_ga=2.181702823.1232783100.1593359517-1450022673.1574142796#visiblecardindexchanged)


Also refer our [feature tour page](https://www.syncfusion.com/xamarin-ui-controls/xamarin-cards) to know more features available in our button.

#Troubleshooting
##Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
