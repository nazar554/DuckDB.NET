﻿using System;
using System.Runtime.InteropServices;

namespace DuckDB.NET;

public partial class NativeMethods
{
    public static class LogicalType
    {
        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_get_type_id")]
        public static extern DuckDBType DuckDBGetTypeId(DuckDBLogicalType type);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_decimal_width")]
        public static extern byte DuckDBDecimalWidth(DuckDBLogicalType type);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_decimal_scale")]
        public static extern byte DuckDBDecimalScale(DuckDBLogicalType type);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_decimal_internal_type")]
        public static extern DuckDBType DuckDBDecimalInternalType(DuckDBLogicalType type);

        [DllImport(DuckDbLibrary, CallingConvention = CallingConvention.Cdecl, EntryPoint = "duckdb_destroy_logical_type")]
        public static extern void DuckDBDestroyLogicalType(out IntPtr type);
    }
}