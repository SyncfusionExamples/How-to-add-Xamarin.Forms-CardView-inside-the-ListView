# How-to-add-Xamarin.Forms-CardView-inside-the-ListView

This demo explains how to add the Xamarin.Forms CardView as ListView item.

Consider the use case to show the list of social applications and each item that is considered as a card. UI was conceived as per the code snippet below.

{% highlight xaml %}

[XAML]

<ContentPage.BindingContext>
        <local:CardViewModel />
</ContentPage.BindingContext>

      <ListView   x:Name="EventListView"
                  RowHeight="100"
                  SeparatorVisibility="None"
                  ItemsSource="{Binding Items}">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <ViewCell>
                        <cards:SfCardView   Margin="10">
                            <Grid HorizontalOptions="FillAndExpand" VerticalOptions="FillAndExpand">
                                <StackLayout Orientation="Horizontal" >
                                    <Image Margin="10,0,0,0" HeightRequest="40" WidthRequest="40"
                                                  Source="{Binding Image}"/>
                                    <Label Margin="10,0,0,0"
                                           FontAttributes="Bold"
                                           FontSize="16"
                                           MaxLines="1"
                                           Text="{Binding Title}"
                                           LineBreakMode="NoWrap"
                                           TextColor="Black"
                                           HorizontalOptions="Start"
                                           VerticalOptions="Center" />
                                </StackLayout>
                            </Grid>
                        </cards:SfCardView>
                    </ViewCell>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
		
{% endhighlight %}

{% highlight c# %}

[C#]

public class CardModel
{
    public string Title {get; set;}

    public string Image {get; set;}
}

public class CardViewModel
{
   public IEnumerable<CardModel> Items { get; set; }

        public CardViewModel()
        {
            Items = new CardModel[]
            {
                new CardModel(){ Title = "Facebook" , Image = "FacebookFill.png"},
                new CardModel(){ Title = "Gmail" , Image = "GmailFill.png"},
                new CardModel(){ Title = "Instagram" , Image = "InstagramFill.png"},
                new CardModel(){ Title = "WhatsApp" , Image = "WhatsappFill.png"},
            };
        }
}

{% highlight c# %}

##Output

![Cards inside the list view](images/Card_ListView.jpg) 
