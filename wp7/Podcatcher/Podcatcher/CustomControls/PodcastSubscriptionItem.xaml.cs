﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Diagnostics;
using Microsoft.Phone.Controls;

namespace Podcatcher
{
	public partial class PodcastSubscriptionItem : UserControl
	{
		public PodcastSubscriptionItem()
		{
			// Required to initialize variables
			InitializeComponent();
		}

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            PodcastSubscriptionModel subscriptionToDelete = (sender as MenuItem).DataContext as PodcastSubscriptionModel;
            Debug.WriteLine("Delete index.");
        }
	}
}