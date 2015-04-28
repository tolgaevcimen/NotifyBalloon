using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace NotifyBalloon
{
    public partial class NotifyBalloon : Form
    {
        public int StallDuration { get; set; }

        MouseHookListener MouseHooker = new MouseHookListener(new GlobalHooker());
        /// <summary>
        /// Parameterless NotifyBalloon constructor.
        /// REMARK: Parameterless overload of the show method should not be called without setting the stallDuration, caption and text.
        /// </summary>
        public NotifyBalloon ()
        {
            InitializeComponent();

            MouseHooker.MouseMove += MouseHooker_MouseMove;
            MouseHooker.Enabled = true;

            Click += NotifyBalloon_Clicked;
            FormClosed += NotifyBalloon_FormClosed;
        }

        /// <summary>
        /// NotifyBalloon constructor with the given parameters to preset balloon values.
        /// REMARK: Calling both overloads of 'Show' method would work.
        /// </summary>
        /// <param name="stallDuration">how long should balloon display</param>
        /// <param name="caption">title of the baloon</param>
        /// <param name="text">message to be shown in the balloon</param>
        public NotifyBalloon ( int stallDuration, string caption, string text )
        {
            InitializeComponent();

            MouseHooker.MouseMove += MouseHooker_MouseMove;
            MouseHooker.Enabled = true;

            Click += NotifyBalloon_Clicked;
            FormClosed += NotifyBalloon_FormClosed;

            StallDuration = stallDuration;
            lblCaption.Text = caption;
            lblText.Text = text;

            SetLocationAndSize();
        }

        void SetLocationAndSize ()
        {
            this.TopMost = true;
            var trayRect = WinAPI.GetTrayRectangle();

            var sizeOfText = TextRenderer.MeasureText(lblText.Text, lblText.Font);
            var rate = (float)sizeOfText.Width / ( this.Width - 4 );

            var rowCount = (int)Math.Ceiling(rate) + ( rate - Math.Floor(rate) > 0.2 ? 1 : 0 );

            this.Height = ( 21 * rowCount ) + 25;
            this.Location = new Point(trayRect.X - ( this.Width - trayRect.Width ) - 15, trayRect.Y - this.Height - 5);
        }

        public new void Show ()
        {
            base.Show();
            FadeIn(this);
        }

        /// <summary>
        /// shows the notifyBalloon with given parameters
        /// </summary>
        /// <param name="stallDuration">how long should balloon display</param>
        /// <param name="caption">title of the baloon</param>
        /// <param name="text">message to be shown in the balloon</param>
        public void Show ( int stallDuration, string caption, string text )
        {
            StallDuration = stallDuration;
            lblCaption.Text = caption;
            lblText.Text = text;

            SetLocationAndSize();

            base.Show();
            FadeIn(this);
        }

        #region Custom Events

        public event EventHandler NotifyBalloonClicked;
        public event EventHandler NotifyBalloonClosed;

        void NotifyBalloon_Clicked ( object sender, EventArgs e )
        {
            EventHandler handler = this.NotifyBalloonClicked;
            if ( handler != null )
            {
                handler(this, e);
            }
        }

        bool IsClosed { get; set; }
        void NotifyBalloon_FormClosed ( object sender, FormClosedEventArgs e )
        {
            if ( IsClosed ) return;

            IsClosed = true;

            EventHandler handler = this.NotifyBalloonClosed;
            if ( handler != null )
            {
                handler(this, e);
            }
        }

        #endregion

        #region Events and Properties for closing the notificationBaloon properly

        public bool MouseOver { get; set; }
        private async void MouseHooker_MouseMove ( object sender, MouseEventArgs e )
        {
            MouseHooker.MouseMove -= MouseHooker_MouseMove;
            MouseHooker.Dispose();

            await Task.Delay(StallDuration);
            if ( !MouseOver )
                FadeOut(this);
        }
        void NotifyBalloon_MouseEnter ( object sender, EventArgs e )
        {
            MouseOver = true;
        }
        async void NotifyBalloon_MouseLeave ( object sender, EventArgs e )
        {
            MouseOver = false;

            await Task.Delay(StallDuration);
            if ( !MouseOver )
                FadeOut(this);
        }

        private void closeButton_Click ( object sender, EventArgs e )
        {
            lblCaption.MouseEnter -= NotifyBalloon_MouseEnter;
            lblCaption.MouseLeave -= NotifyBalloon_MouseLeave;
            lblText.MouseEnter -= NotifyBalloon_MouseEnter;
            lblText.MouseLeave -= NotifyBalloon_MouseEnter;
            label1.MouseEnter -= NotifyBalloon_MouseEnter;
            label1.MouseLeave -= NotifyBalloon_MouseEnter;
            this.MouseEnter -= NotifyBalloon_MouseEnter;
            this.MouseLeave -= NotifyBalloon_MouseEnter;

            Close();
        }

        #endregion

        #region Opening and Closing form by fading them in and out

        private async void FadeIn ( Form o, int interval = 40 )
        {
            //Object is not fully invisible. Fade it in
            while ( o.Opacity < 1.0 )
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = 1; //make fully visible       
        }
        private async void FadeOut ( Form o, int interval = 40 )
        {
            //Object is fully visible. Fade it out
            while ( o.Opacity > 0.0 )
            {
                if ( MouseOver )
                {
                    o.Opacity = 1.0;
                    return;
                }

                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0; //make fully invisible    

            o.Close();
        }

        #endregion
        #region Changing CloseButton's font

        private void closeButton_MouseEnter ( object sender, EventArgs e )
        {
            var font = ( (Button)sender ).Font;

            ( (Button)sender ).Font = new Font(font, FontStyle.Bold);

            font.Dispose();
        }
        private void closeButton_MouseLeave ( object sender, EventArgs e )
        {
            var font = ( (Button)sender ).Font;

            ( (Button)sender ).Font = new Font(font, FontStyle.Regular);

            font.Dispose();
        }

        #endregion
    }
}
