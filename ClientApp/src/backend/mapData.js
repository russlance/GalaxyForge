import { HexGrid, Layout, Hexagon, GridGenerator, Hex } from 'react-hexgrid';
import { Tile } from "./Tile";

export const generateGrid = () => {
    const temp = GridGenerator.hexagon(5);

    const grid = [];
    temp.map((hex) => {
        const tile = new Tile();
        tile.hex = hex;
        grid.push(tile);
    });

    return grid;
}