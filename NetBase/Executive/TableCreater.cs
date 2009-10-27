﻿/*
NetBase .NET database
Copyright (C) 2009  buttonpusher

This program is free software; you can redistribute it and/or
modify it under the terms of the GNU General Public License
as published by the Free Software Foundation; either version 2
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetBase.Executive;
using NetBase.Storage;

namespace NetBase.Executive
{
    // <summary>
    // Executive class to create a table. Minimal (It's mostly done
    // by the storage engine)
    // </summary>
    internal class TableCreater : IRunnable
    {
        NetBase.Sql.CreateTableQuery Query { get; set; }

        public TableCreater(NetBase.Sql.CreateTableQuery q)
        {
            this.Query = q;
        }

        public NetBase.Storage.ITable Execute(Database db)
        {
            db.Tables.Add(Query);
            return null;
        }
    }
}
