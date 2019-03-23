﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
//using SkiaSharp;
using NLog;
using Nebulator.Common;
using Nebulator.Device;


namespace Nebulator.Script
{
    public partial class ScriptCore : IDisposable
    {
        #region Fields - internal
        /// <summary>My logger.</summary>
        Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>Resource clean up.</summary>
        bool _disposed = false;

        /// <summary>Script randomizer.</summary>
        Random _rand = new Random();
        #endregion

        #region Properties - dynamic things shared between host and script at runtime
        /// <summary>Main -> Script</summary>
        public Time StepTime { get; set; } = new Time();

        /// <summary>Main -> Script</summary>
        public bool Playing { get; set; } = false;

        /// <summary>Main -> Script</summary>
        public double RealTime { get; set; } = 0.0;

        /// <summary>Main -> Script -> Main</summary>
        public double Speed { get; set; } = 0.0;

        /// <summary>Main -> Script -> Main</summary>
        public double Volume { get; set; } = 0;

        /// <summary>Steps added by script functions at runtime e.g. sendSequence(). Script -> Main</summary>
        public StepCollection RuntimeSteps { get; private set; } = new StepCollection();
        #endregion

        #region Properties - things defined in the script that MainForm needs
        /// <summary>All vars.</summary>
        public List<NVariable> Variables { get; set; } = new List<NVariable>();

        /// <summary>Control inputs.</summary>
        public List<NController> Controllers { get; set; } = new List<NController>();

        /// <summary>Levers.</summary>
        public List<NController> Levers { get; set; } = new List<NController>();

        /// <summary>All displays.</summary>
        public List<NDisplay> Displays { get; set; } = new List<NDisplay>();

        /// <summary>All sequences.</summary>
        public List<NSequence> Sequences { get; set; } = new List<NSequence>();

        /// <summary>All sections.</summary>
        public List<NSection> Sections { get; set; } = new List<NSection>();

        /// <summary>All channels.</summary>
        public List<NChannel> Channels { get; set; } = new List<NChannel>();
        #endregion

        #region Lifecycle
        /// <summary>
        /// Resource clean up.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Resource clean up.
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _disposed = true;
            }
        }
        #endregion
    }
}
