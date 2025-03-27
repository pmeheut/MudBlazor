// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;

namespace MudBlazor;

public record ColumnState(int index, bool Hidden, SortDirection SortDirection, double? Width);

public record DataGridState(List<ColumnState> ColumnsState);

public record DataGridStateEvent<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicProperties)] T>(
    MudDataGrid<T> DataGrid, bool Reset)
{
    public DataGridState State { get => DataGrid.GetState(); }
}
