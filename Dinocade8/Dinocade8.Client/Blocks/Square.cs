using CellCollectionz;
using Griders;
using Terominoz;
using TetrominoStylz;

public class Block : Tetromino
{
	public Block(Grid grid) : base(grid) { }

	public TetrominoStyle Style => TetrominoStyle.Block;
	public override string CssClass => "tetris-yellow-cell";
	public override CellCollection CoveredCells
	{
		get
		{
			CellCollection cells = new CellCollection();
			cells.Add(CenterPieceRow, CenterPieceColumn);
			cells.Add(CenterPieceRow - 1, CenterPieceColumn);
			cells.Add(CenterPieceRow, CenterPieceColumn + 1);
			cells.Add(CenterPieceRow - 1, CenterPieceColumn + 1);
			return cells;
		}
	}
}