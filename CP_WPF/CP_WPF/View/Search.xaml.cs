using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using ClassLibrary;

namespace CP_WPF.View
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    /// 

    public partial class Search : UserControl
    {
        MainMenuxaml win;
        MainMenuxaml main = new MainMenuxaml();
        public Film film;
        //WrapPanel grid;
        public bool flag = false;
        public Search(MainMenuxaml win)
        {
            this.win = win;
            InitializeComponent();
        }

        public bool SearchMach(TextBox text)
        {
            return true;
        }


        //private void OnSearchBeginByTheme(object sender, TextChangedEventArgs e)
        //{
        //    SelectedHeaders.Items.Clear();
        //    SelectedTopics.Items.Clear();
        //    using (Context db = new Context())
        //    {
        //        var topics = from test in db.Tests where test.Topic.StartsWith(ByTopic.Text) select test.Topic;
        //        if (topics.Count() > 0)
        //        {
        //            testList.Clear();
        //            SelectedTopics.IsEnabled = true;
        //            foreach (string topic in topics)
        //            {
        //                SelectedTopics.Items.Add(topic);
        //            }
        //            SelectedTopics.SelectedItem = SelectedTopics.Items[0];
        //        }
        //    }
        //}

        //private void OnTopicSelected(object sender, SelectionChangedEventArgs e)
        //{
        //    var selectedTopic = SelectedTopics.SelectedItem;
        //    if (selectedTopic != null)
        //    {
        //        string topic = selectedTopic.ToString();
        //        using (Context db = new Context())
        //        {
        //            var tests = from test in db.Tests where test.Topic == topic select test;
        //            if (tests.Count() > 0)
        //            {
        //                SelectedHeaders.IsEnabled = true;
        //                foreach (Test test in tests)
        //                {
        //                    testList.Add(test);
        //                    SelectedHeaders.Items.Add(test.Header);
        //                }
        //                SelectedHeaders.SelectedItem = SelectedHeaders.Items[0];
        //            }
        //        }
        //    }
        //}

        private void Serching(object sender, RoutedEventArgs e)
        {
            try
            {
                Regex regex = new Regex(@"[А-Я][а-я\ ]+", RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(SearchQuery.Text);
                if (matches.Count < 0)
                {
                    win.GridSpaceInfo.Children.Add(new NotFound(win));
                }
                if (matches.Count > 0 && SearchQuery.Text.Length != 0)
                {
                    foreach (Match match in matches)
                    {
                        List<CardItem> list = new List<CardItem>(AsyncClient.films.Count);
                        foreach (Film t in AsyncClient.films)
                        {
                            if (t.Name.Contains(SearchQuery.Text))
                            {
                                win.GridSpaceInfo.Children.Clear();
                                CardItem cardItem = new CardItem(win, t);
                                win.GridSpaceInfo.Children.Add(new CardItem(win, t));
                                cardItem.Details.Click += new RoutedEventHandler(Handler);
                            }
                        }
                    }
                }
                else
                {
                    win.GridSpaceInfo.Children.Clear();
                    SearchQuery.Text = "Wrong symbols";
                    win.GridSpaceInfo.Children.Add(new Search(win));
                    win.GridSpaceInfo.Children.Add(new NotFound(win));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void OnSearchWords(object sender, TextChangedEventArgs e)
        {
            //List<Film> films = new List<Film>();
            /// доделать Андрею
            try
            {
                var query = from t in AsyncClient.films
                            where t.Name.StartsWith(SearchQuery.Text)
                            orderby t
                            select t;

                if (query.Count() > 0)
                {
                    if (flag)
                    {
                        win.GridSpaceInfo.Children.RemoveRange(1, win.GridSpaceInfo.Children.Count);
                    }
                    else
                    {
                        win.GridSpaceInfo.Children.RemoveRange(1, win.GridSpaceInfo.Children.Count-1);
                    }
                    foreach (var q in query)
                    {
                        List<CardItem> list = new List<CardItem>(AsyncClient.films.Count);
                        foreach (Film t in AsyncClient.films)
                        {
                            if (t.Name.Contains(SearchQuery.Text))
                            {
                                CardItem cardItem = new CardItem(win, t);
                                win.GridSpaceInfo.Children.Add(new CardItem(win, t));
                                cardItem.Details.Click += new RoutedEventHandler(Handler);
                                flag = true;
                            }
                        }
                    }
                }
                else if (query.Count() <= 0)
                {
                    win.GridSpaceInfo.Children.Clear();
                    win.GridSpaceInfo.Children.Add(new Search(win));
                    win.GridSpaceInfo.Children.Add(new NotFound(win));
                    flag = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.Source);
            }

        }

        public void Handler(object sender, RoutedEventArgs e)
        {
            main.GridSpaceInfo.Children.Clear();
            main.GridSpaceInfo.Children.Add(new CardItemMoreInfo(main, film));
        }
    }
}

