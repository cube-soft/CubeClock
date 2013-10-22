﻿/* ------------------------------------------------------------------------- */
///
/// MainForm.cs
/// 
/// Copyright (c) 2013 CubeSoft, Inc. All rights reserved.
///
/// MIT License
///
/// Permission is hereby granted, free of charge, to any person obtaining a
/// copy of this software and associated documentation files (the "Software"),
/// to deal in the Software without restriction, including without limitation
/// the rights to use, copy, modify, merge, publish, distribute, sublicense,
/// and/or sell copies of the Software, and to permit persons to whom the
/// Software is furnished to do so, subject to the following conditions:
///
/// The above copyright notice and this permission notice shall be included
/// in all copies or substantial portions of the Software.
/// 
/// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
/// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
/// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
/// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
/// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
/// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
/// DEALINGS IN THE SOFTWARE.
///
/* ------------------------------------------------------------------------- */
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CubeClock.Ntp
{
    /* --------------------------------------------------------------------- */
    ///
    /// MainForm
    /// 
    /// <summary>
    /// メイン画面を表示するためのクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public partial class MainForm : Form
    {
        #region Initialization and Termination

        /* ----------------------------------------------------------------- */
        ///
        /// MainForm (constructor)
        /// 
        /// <summary>
        /// 既定の値でオブジェクトを初期化します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public MainForm()
        {
            InitializeComponent();
            ClockTimer.Start();
        }

        #endregion

        #region Event handlers

        /* ----------------------------------------------------------------- */
        ///
        /// ClockTimer_Tick
        /// 
        /// <summary>
        /// 一定時間ごとに実行されるイベントハンドラです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var local  = DateTime.Now;
                var server = local + _observer.LocalClockOffset;
                LocalClockLabel.Text  = local.ToString();
                ServerClockLabel.Text = server.ToString();
                UpdateNotifyIcon();
            }
            catch (Exception err) { Trace.WriteLine(err.ToString()); }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// SyncButton_Click
        /// 
        /// <summary>
        /// 時刻を同期する際に実行されるイベントハンドラです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void SyncButton_Click(object sender, EventArgs e)
        {
            try
            {
                _observer.Refresh();
                var sync = new CubeClock.Ntp.TimeSync();
                sync.Run(_observer.LastResult);
                _observer.Refresh();
            }
            catch (Exception err) { Trace.WriteLine(err.ToString()); }
        }

        #endregion

        #region Other methods

        /* ----------------------------------------------------------------- */
        ///
        /// UpdateNotifyIcon
        /// 
        /// <summary>
        /// タスクトレイ上のアイコンの表示状態を更新します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        private void UpdateNotifyIcon()
        {
            var offset = (int)Math.Abs(_observer.LocalClockOffset.TotalSeconds);
            if (offset > _threshold)
            {
                if (SyncNotifyIcon.Visible) return;
                SyncNotifyIcon.Visible = true;
                var format = (_observer.LocalClockOffset.TotalMilliseconds <= 0) ?
                    Properties.Resources.TimeFastWarning : Properties.Resources.TimeBehindWarning;
                var message = string.Format(format, offset);
                SyncNotifyIcon.Text = message;
                SyncNotifyIcon.BalloonTipText = message;
                SyncNotifyIcon.ShowBalloonTip(30000);
            }
            else SyncNotifyIcon.Visible = false;
        }

        #endregion

        #region Variables
        private Ntp.Observer _observer = new Ntp.Observer();
        private int _threshold = 5;
        #endregion
    }
}
