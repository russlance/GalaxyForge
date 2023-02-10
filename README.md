# Galaxy Forge

## NOTE: This is a work in progress!

Galaxy Forge is a tool to build out the lore for your galaxy. With this tool there are 2,471,326,208 solar systems available within this galaxy. 

This tool utilizes a database capable of retaining all of the information for the entire galaxy. However, if you were to fully populate the entire galaxy it would create a very large database. 

This tool does not come pre-populated with data, but needs to be fleshed out by the user. It does, however, come with seed data that establishes the 7 [Galactic Sectors](#galoactic-sectors). The names of each can be edited.

## Table of Contents
1. [Galactic Map](#galactic-map)
2. [Time](#time)
3. [Data](#data)

## Galactic Map

The Galactic Map is depicted in a 2D envionment. Each section occupies the thickness of the galactic ring. If the user wishes, they may include the positive/negative position from the galactic plane to explain duration of travel between [Solar Systems](#solar-systems). This is an optional attribute that can be left blank.

The map below is only a diagram to show the layout of the sections and does not represent comparative scale.

![Image map](/galaxyMap.png)

### The Galactic Map is made up of the following:
1. [Galactic Core](#galactic-core)
2. [Galactic Sectors](#galactic-sectors)
3. [Galactic Zones](#galactic-zones)
4. [Regions](#regions)
5. [Sectors](#sectors)
6. [Solar Systems](#solar-systems)

### Galactic Core

The galactic core is an area depicted as a hexagon. This area consists of 169 [Galactic Zones](#galactic-zones).

### Galactic Sectors

The Galactic Sectors include the [Galactic Core](#galactic-core) (in the shape of a hexagon), plus each edge of the Galactic Core (each in the shape of half of a hexagon, and made up of hexagons). See the [Galactic Map](#galactic-map) above for illustration. This makes a total of 7 Galactic Sectors. 

Galactic Sectors are numbered from 1-6 starting with the sector above the Galactic Core, then continuing numbering from the top of the above map and incrementing clockwise. Each of these sectors contains 85 Galactic Zones.

### Galactic Zones

Each galactic zone consists of 169 [Regions](#regions).

### Regions

Each region is made up of 169 [Sectors](#sectors).

### Sectors

A sector is made up of 169 [Solar Systems](#solar-systems).

### Solar Systems

Each solar system may contain:
* Celestial Bodies. A body can be a planet, gas giant, astroid field, a gas or particle ring or sphere, a star, etc.
* Structures. A structure can be stations, mining bases, military bases, etc.
* Species.

## Time

Time is tracked by Galactic Year (the exact duration of this year is up to the user of this tool), followed by a decimal representing a tenth of a year (e.g. 1234.5).

## Data

In addition to the above mentioned galactic components, this tool also tracks:
 * Events
 * Governments
 * Organizations
 * Species
 * Celestial Bodies
 * Structures
