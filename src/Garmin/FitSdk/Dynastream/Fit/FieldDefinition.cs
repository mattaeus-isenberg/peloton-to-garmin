#region Copyright
/////////////////////////////////////////////////////////////////////////////////////////////
// Copyright 2022 Garmin International, Inc.
// Licensed under the Flexible and Interoperable Data Transfer (FIT) Protocol License; you
// may not use this file except in compliance with the Flexible and Interoperable Data
// Transfer (FIT) Protocol License.
/////////////////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 21.94Release
// Tag = production/akw/21.94.00-0-g0f668193
/////////////////////////////////////////////////////////////////////////////////////////////

#endregion

namespace Dynastream.Fit
{
    /// <summary>
    ///
    /// </summary>
    public class FieldDefinition
    {
        #region Fields

        #endregion

        #region Properties
        // Opt for the simpler form until we need a backing field
        public byte Num { get; private set; }
        public byte Size { get; private set; }
        public byte Type { get; private set; }
        #endregion

        #region Constructors
        public FieldDefinition()
        {

        }

        public FieldDefinition(Field field)
        {
            Num = field.Num;
            Size = field.GetSize();
            Type = field.Type;
        }

        public FieldDefinition(byte newNum, byte newSize, byte newType)
        {
            Num = newNum;
            Size = newSize;
            Type = newType;
        }

        public FieldDefinition(FieldDefinition fieldDef)
        {
            Num = fieldDef.Num;
            Size = fieldDef.Size;
            Type = fieldDef.Type;
        }
        #endregion

        #region Methods

        #endregion
    }
} // namespace
