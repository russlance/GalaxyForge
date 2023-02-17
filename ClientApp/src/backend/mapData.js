import { HexGrid, Layout, Hexagon, GridGenerator, Hex } from 'react-hexgrid';
import { Tile } from "./Tile";

/**
 * This class should only be called the first time Galaxy Forge is initialized.
 * It will populate each section with addresses. Starting with a Galaxy Sector
 * this class will create coordinate for each Galactic Zone within the Galactic Sector,
 * then it will create the coordinates for each Region inside that Galactic Zone,
 * then it will create the coordinates for each Sector within that Galactic Zone,
 * then it will create the coordinates for each Solar System within that Sector.
 * This process will continue until all Solar Systems throughout the Galaxy has an
 * address. This will take some time to populate all the way.
 * within that
 * */
export const generateGrid = (size) => {
    const temp = GridGenerator.hexagon(size);

    const grid = [];
    temp.map((hex) => {
        const tile = new Tile();
        tile.hex = hex;
        grid.push(tile);
    });

    return grid;
}