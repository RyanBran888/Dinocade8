using Dinocade8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Griders;
using CellCollectionz;
using Terominoz;
using TetrominoStylz;
using GameStates;
using TetrominoOrientationz;
namespace Cellz
{
	public class Cell
	{
		public int Row { get; set; }
		public int Column { get; set; }
		public string CssClass { get; set; }

		public Cell(int row, int column)
		{
			Row = row;
			Column = column;
		}
		public Cell(int row, int column, string css)
		{
			Row = row;
			Column = column;
			CssClass = css;
		}
	}
}