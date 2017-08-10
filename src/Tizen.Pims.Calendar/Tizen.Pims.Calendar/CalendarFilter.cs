/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;

namespace Tizen.Pims.Calendar
{
    /// <summary>
    /// A filter includes the conditions for the search.
    /// </summary>
    public class CalendarFilter:IDisposable
    {
        internal IntPtr _filterHandle;

        /// <summary>
        /// Creates a filter with a condition for a string type.
        /// </summary>
        /// <param name="viewUri">The view URI of a filter</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match value</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        /// <exception cref="OutOfMemoryException">Thrown when failed due to out of memory</exception>
        public CalendarFilter(string viewUri, uint propertyId, StringMatchType matchType, string matchValue)
        {
            int error = 0;
            error = Interop.Calendar.Filter.Create(viewUri, out _filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddString(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Creates a filter with a condition for an integer type.
        /// </summary>
        /// <param name="viewUri">The view URI of a filter</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match value</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        /// <exception cref="OutOfMemoryException">Thrown when failed due to out of memory</exception>
        public CalendarFilter(string viewUri, uint propertyId, IntegerMatchType matchType, int matchValue)
        {
            int error = 0;
            error = Interop.Calendar.Filter.Create(viewUri, out _filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddInteger(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Creates a filter with a condition for long type.
        /// </summary>
        /// <param name="viewUri">The view URI of a filter</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match value</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        /// <exception cref="OutOfMemoryException">Thrown when failed due to out of memory</exception>
        public CalendarFilter(string viewUri, uint propertyId, IntegerMatchType matchType, long matchValue)
        {
            int error = 0;
            error = Interop.Calendar.Filter.Create(viewUri, out _filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddLong(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Creates a filter with a condition for double type.
        /// </summary>
        /// <param name="viewUri">The view URI of a filter</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match value</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        /// <exception cref="OutOfMemoryException">Thrown when failed due to out of memory</exception>
        public CalendarFilter(string viewUri, uint propertyId, IntegerMatchType matchType, double matchValue)
        {
            int error = 0;
            error = Interop.Calendar.Filter.Create(viewUri, out _filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddDouble(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Creates a filter with a condition for CalendarTime type.
        /// </summary>
        /// <param name="viewUri">The view URI of a filter</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match value</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        /// <exception cref="OutOfMemoryException">Thrown when failed due to out of memory</exception>
        public CalendarFilter(string viewUri, uint propertyId, IntegerMatchType matchType, CalendarTime matchValue)
        {
            int error = 0;
            error = Interop.Calendar.Filter.Create(viewUri, out _filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            Interop.Calendar.Record.DateTime time = CalendarRecord.ConvertCalendarTimeToStruct(matchValue);
            error = Interop.Calendar.Filter.AddCalendarTime(_filterHandle, propertyId, matchType, time);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "CalendarFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        ~CalendarFilter()
        {
            Dispose(false);
        }

        /// <summary>
        /// Enumeration for the filter match type of a string.
        /// </summary>
        public enum StringMatchType
        {
            /// <summary>
            /// Full string, case-sensitive
            /// </summary>
            Exactly,
            /// <summary>
            /// Full string, case-insensitive
            /// </summary>
            Fullstring,
            /// <summary>
            /// Sub string, case-insensitive
            /// </summary>
            Contains,
            /// <summary>
            /// Start with, case-insensitive
            /// </summary>
            Startswith,
            /// <summary>
            /// End with, case-insensitive
            /// </summary>
            Endswith,
            /// <summary>
            /// IS NOT NUL
            /// </summary>
            Exists,
        }

        /// <summary>
        /// Enumeration for the filter match type of an integer.
        /// </summary>
        public enum IntegerMatchType
        {
            /// <summary>
            /// '='
            /// </summary>
            Equal,
            /// <summary>
            /// '>'
            /// </summary>
            GreaterThan,
            /// <summary>
            /// '>='
            /// </summary>
            GreaterThanOrEqual,
            /// <summary>
            /// &lt;
            /// </summary>
            LessThan,
            /// <summary>
            /// &lt;=
            /// </summary>
            LessThanOrEqual,
            /// <summary>
            /// &lt;>, this flag can yield poor performance
            /// </summary>
            NotEqual,
            /// <summary>
            /// IS NULL
            /// </summary>
            None,
        }

        /// <summary>
        /// Enumeration for a filter operator.
        /// </summary>
        public enum LogicalOperator
        {
            /// <summary>
            /// AND
            /// </summary>
            And,
            /// <summary>
            /// OR
            /// </summary>
            Or,
        }

#region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                Log.Debug(Globals.LogTag, "Dispose :" + disposing);

                int error = Interop.Calendar.Filter.Destroy(_filterHandle);
                if (CalendarError.None != (CalendarError)error)
                {
                    Log.Error(Globals.LogTag, "Destroy Failed with error " + error);
                    throw CalendarErrorFactory.GetException(error);
                }
                disposedValue = true;
            }
        }

        /// <summary>
        /// Releases all resources used by the CalendarFilter.
        /// It should be called after finished using of the object.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }
#endregion

        /// <summary>
        /// Adds a condition for the string type.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match valu</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddCondition(LogicalOperator logicalOperator, uint propertyId, StringMatchType matchType, string matchValue)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddString(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Adds a condition for the integer type.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match valu</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddCondition(LogicalOperator logicalOperator, uint propertyId, IntegerMatchType matchType, int matchValue)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddInteger(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Adds a condition for the long type.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match valu</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddCondition(LogicalOperator logicalOperator, uint propertyId, IntegerMatchType matchType, long matchValue)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddLong(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Adds a condition for the double type.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match valu</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddCondition(LogicalOperator logicalOperator, uint propertyId, IntegerMatchType matchType, double matchValue)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddDouble(_filterHandle, propertyId, matchType, matchValue);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Adds a condition for the CalendarTime type.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="propertyId">The property ID to add a condition</param>
        /// <param name="matchType">The match flag</param>
        /// <param name="matchValue">The match valu</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddCondition(LogicalOperator logicalOperator, uint propertyId, IntegerMatchType matchType, CalendarTime matchValue)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            Interop.Calendar.Record.DateTime time = CalendarRecord.ConvertCalendarTimeToStruct(matchValue);
            error = Interop.Calendar.Filter.AddCalendarTime(_filterHandle, propertyId, matchType, time);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }

        /// <summary>
        /// Adds a child filter to a parent filter.
        /// </summary>
        /// <param name="logicalOperator">The operator type</param>
        /// <param name="filter">The child filter</param>
        /// <exception cref="NotSupportedException">Thrown when an invoked method is not supported</exception>
        /// <exception cref="ArgumentException">Thrown when one of the arguments provided to a method is not valid</exception>
        public void AddFilter(LogicalOperator logicalOperator, CalendarFilter filter)
        {
            int error = Interop.Calendar.Filter.AddOperator(_filterHandle, logicalOperator);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddCondition Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }

            error = Interop.Calendar.Filter.AddFilter(_filterHandle, filter._filterHandle);
            if (CalendarError.None != (CalendarError)error)
            {
                Log.Error(Globals.LogTag, "AddFilter Failed with error " + error);
                throw CalendarErrorFactory.GetException(error);
            }
        }
    }
}