using Dinocade8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Griders;
using Cellz;
using Terominoz;
using TetrominoStylz;
using GameStates;
using TetrominoOrientationz;
namespace CellCollectionz
{
	public class CellCollection
	{
		private readonly List<Cell> _cells = new List<Cell>();
		public bool HasRow(int row)
		{
			return _cells.Any(c => c.Row == row);
		}
		public bool HasColumn(int column)
		{
			return _cells.Any(c => c.Column == column);
		}
		public bool Contains(int row, int column)
		{
			return _cells.Any(c => c.Row == row && c.Column == column);
		}
		public void Add(int row, int column)
		{
			_cells.Add(new Cell(row, column));
		}
		public void AddMany(List<Cell> cells, string cssClass)
		{
			foreach (var cell in cells)
			{
				_cells.Add(new Cell(cell.Row, cell.Column, cssClass));
			}
		}
		public List<Cell> GetAll()
		{
			return _cells;
		}
		public string GetCssClass(int row, int column)
		{
			var matching = _cells.FirstOrDefault(x => x.Row == row && x.Column == column);

			if (matching != null)
				return matching.CssClass;

			return "";
		}
		public void SetCssClass(int row, string cssClass)
		{
			_cells.Where(x => x.Row == row)
		.ToList()
		.ForEach(x => x.CssClass = cssClass);
		}
		public void CollapseRows(List<int> rows)
		{
			var selectedCells = _cells.Where(x => rows.Contains(x.Row));
			List<Cell> toRemove = new List<Cell>();
			foreach (var cell in selectedCells)
			{
				toRemove.Add(cell);
			}
			_cells.RemoveAll(x => toRemove.Contains(x));
			foreach (var cell in _cells)
			{
				int numberOfLessRows = rows.Where(x => x <= cell.Row).Count();
				cell.Row -= numberOfLessRows;
			}
		}
		public List<Cell> GetRightmost()
		{
			List<Cell> cells = new List<Cell>();
			foreach (var cell in _cells)
			{
				if (!Contains(cell.Row, cell.Column + 1))
				{
					cells.Add(cell);
				}
			}
			return cells;
		}
		public List<Cell> GetLeftMost()
		{
			List<Cell> cells = new List<Cell>();
			foreach (var cell in _cells)
			{
				if (!Contains(cell.Row, cell.Column - 1))
				{
					cells.Add(cell);
				}
			}
			return cells;
		}
		public List<Cell> GetLowest()
		{
			List<Cell> cells = new List<Cell>();
			foreach (var cell in _cells)
			{
				if (!Contains(cell.Row - 1, cell.Column))
				{
					cells.Add(cell);
				}
			}
			return cells;
		}

	}
}