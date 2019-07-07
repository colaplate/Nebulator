﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nebulator.Common;


namespace Nebulator.Device
{
    /// <summary>A collection of Steps.</summary>
    public class StepCollection
    {
        #region Fields
        ///<summary>The main collection of Steps. The key is the time to send the list.</summary>
        Dictionary<Time, List<Step>> _steps = new Dictionary<Time, List<Step>>();
        #endregion

        #region Properties
        ///<summary>Gets a collection of the list.</summary>
        public IEnumerable<Time> Times { get { return (_steps.Keys); } }

        ///<summary>The duration of the whole thing.</summary>
        public int MaxTick { get; private set; } = 0;
        #endregion

        #region Methods
        /// <summary>
        /// Add a step at the given time.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="step"></param>
        public void AddStep(Time time, Step step)
        {
            if (!_steps.ContainsKey(time))
            {
                _steps.Add(time, new List<Step>());
            }
            _steps[time].Add(step);

            MaxTick = Math.Max(MaxTick, time.Tick);
        }

        /// <summary>
        /// Concatenate another collection to this.
        /// </summary>
        /// <param name="stepsToAdd"></param>
        public void Add(StepCollection stepsToAdd)
        {
            foreach(KeyValuePair<Time, List<Step>> kv in stepsToAdd._steps)
            {
                kv.Value.ForEach(s => AddStep(kv.Key, s));
            }
        }

        /// <summary>
        /// Get the steps for the given time.
        /// </summary>
        public IEnumerable<Step> GetSteps(Time time)
        {
            return _steps.ContainsKey(time) ? _steps[time] : new List<Step>();
        }

        /// <summary>
        /// Delete the steps at the given time.
        /// </summary>
        public void DeleteSteps(Time time)
        {
            _steps.Remove(time);
        }

        /// <summary>
        /// Cleanse me.
        /// </summary>
        public void Clear()
        {
            _steps.Clear();
        }

        /// <summary>
        /// Utility dump 
        /// </summary>
        /// <returns></returns>
        public string Dump()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<Time, List<Step>> kv in _steps)
            {
                kv.Value.ForEach(s => sb.Append($"{kv.Key.ToString()} {s.ToString()}{Environment.NewLine}"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Display the content steps.
        /// </summary>
        public override string ToString()
        {
            return $"Times:{_steps.Keys.Count} TotalSteps:{_steps.Values.Sum(v => v.Count)}";
        }
        #endregion
    }
}
