using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HtmlParser_AppVestoTestTask_
{
    class VM : INotifyPropertyChanged
    {
        decimal progress;
        HtmlParser parser;
        string sortingType;
        bool isButtonAvailable;
        HttpWebRequest request;
        ObservableCollection<Video> videos;

        public decimal Progress
        {
            get => progress;
            set
            {
                progress = value;
                OnPropertyChanged();
            }
        }
        public string SortingType 
        {
            get => sortingType;
            set
            {
                sortingType = value;
                Reorder();
            }
        }
        public bool IsButtonAvaible
        {
            get => isButtonAvailable;
            set
            {
                isButtonAvailable = value;
                OnPropertyChanged();
            }
        }
        public ICommand Parse { get; set; }
        public ObservableCollection<Video> Videos
        {
            get => videos;
            set
            {
                videos = value;
                OnPropertyChanged();
            }
        }
        public VM()
        {
            Parse = new Command(none => Task.Run(() => Videos = new ObservableCollection<Video>(ParseMethod())));
            parser = new HtmlParser();
            isButtonAvailable = true;
            request = WebRequest.Create("https://www.udemy.com/course/learn-flutter-dart-to-build-ios-android-apps/") as HttpWebRequest;
        }
        
        private void Reorder()
        {
            if (Videos is null)
                return;

            switch (sortingType)
            {
                case "Name ascending":
                    Videos = new ObservableCollection<Video>(Videos.OrderBy(v => v.Name));
                    break;
                case "Name descending":
                    Videos = new ObservableCollection<Video>(Videos.OrderByDescending(v => v.Name));
                    break;
                case "Duration ascending":
                    Videos = new ObservableCollection<Video>(Videos.OrderBy(v => v.Duration));
                    break;
                case "Duration descending":
                    Videos = new ObservableCollection<Video>(Videos.OrderByDescending(v => v.Duration));
                    break;
                default:
                    break;
            }            
        }
        private IEnumerable<Video> ParseMethod()
        {
            IsButtonAvaible = false;
            IHtmlDocument doc;
            Task.Run(()=>
            {
                while (Progress < 100)
                {
                    Progress++;
                    Thread.Sleep(15);
                }
            });

            using (var stream = request.GetResponse().GetResponseStream())
                doc = parser.ParseDocument(stream);

            var div = doc.QuerySelectorAll(".section--first-panel--2fbBU").Single();
            var lis = div.QuerySelectorAll("li");

            var durations = new List<string>();
            var names = new List<string>();

            foreach (var li in lis)
            {
                durations.Add(li.QuerySelector(".section--item-content-summary--126oS").Text());
                names.Add(li.QuerySelector(".section--item-title--2k1DQ").Text());
            }

            Progress = 100;
            return names.Zip(durations, (name, duration) => new Video { Name = name, Duration = duration }).OrderBy(v => v.Name);
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
