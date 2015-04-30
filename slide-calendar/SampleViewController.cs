
using System;

using Foundation;
using UIKit;
using SlideCalendarLib;

namespace slidecalendar
{
	public partial class SampleViewController : UIViewController
	{
		public SampleViewController () : base ("SampleViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			var calendar = new SlideCalendar (new CoreGraphics.CGPoint (0, 20),DateTime.Now,new DateTime(1984,8,15),new DateTime(2020,8,15));
			calendar.OnDaySelected += (DateTime selectedDate) => {
				Console.WriteLine("Day has been selected: " + selectedDate.ToString("D"));
			};
			this.Add (calendar);
		}
	}
}

