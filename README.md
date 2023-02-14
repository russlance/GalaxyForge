# Galaxy Forge

## NOTE: This is a work in progress!

Galaxy Forge is a tool to store the lore for your galaxy. With this tool there is a possibility of creating up to 34,002,726,912 [Solar Systems](#solar-systems). The larger the galaxy, the larger the database.

Compared to the Milky Way Galaxy, the largest size possible is still very small. There are estimated to be between 100-400 billion stars in our galaxy (https://asd.gsfc.nasa.gov/blueshift/index.php/2015/07/22/how-many-stars-in-the-milky-way/). Due to the limitations of this developer's skills, this tool can only create a galaxy a fraction of the size of our home. Again, this tool is designed to simply be a place to store lore for your fictional galaxy.

This tool utilizes a database capable of retaining all of the information for the entire galaxy. However, if you were to fully populate the entire galaxy it would create a very large database. 

This tool does not come pre-populated with data, but needs to be fleshed out by the user. It does, however, come with seed data that establishes all of the addresses for all of the [Solar Systems](#solar-systems) for all of the 7 [Galactic Sectors](#galactic-sectors). This is done the first time the tool is initialized. 

The user will choose how large their galaxy will be at this time. Since it is based on a hegigon system, the total number of solar systems will be one of the following options:

   * 912,247
   * 13,119,127
   * 96,920,887
   * 480,024,727
   * 1,821,012,487
   * 4,821,232,752
   * 13,613,670,000
   * 34,002,726,912

This takes time to generate, so be patient as it will appear to freeze from time to time. The larger the galaxy, the longer it will take. Remember, it is creating all of those Solar Systems! Only God can make that happen in an instant!

## Table of Contents
1. [Galactic Map](#galactic-map)
2. [Time](#time)
3. [Data](#data)
4. [Adding Data](#adding-data)

## Galactic Map
Back to [Table of Contents](#table-of-contents)

The Galactic Map is depicted as a 2D map. Each section occupies the thickness of the galactic ring. If the user wishes, they may include the positive/negative position from the galactic plane (optional) to explain duration of travel between [Solar Systems](#solar-systems). However, this tool is not set up to account for Solar Systems being located above or below each other on the Galactic Plane.

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

The galactic core is an area depicted as a hexagon. This area consists of a number of [Galactic Zones](#galactic-zones).

### Galactic Sectors

The Galactic Sectors include the [Galactic Core](#galactic-core) (in the shape of a hexagon), plus each edge of the Galactic Core (each in the shape of a hexagon, and made up of hexagons). See the [Galactic Map](#galactic-map) above for illustration. This makes a total of 7 Galactic Sectors. 

Galactic Sectors are numbered from 1-7 starting with the sector above the Galactic Core (with the core being Sector 1), then incrementing from the top of the above map and continuing clockwise. Each of these sectors contains a number of [Galactic Zones](#galactic-zones).

### Galactic Zones

Each galactic zone consists of a number of [Regions](#regions).

### Regions

Each region is made up of a number of [Sectors](#sectors).

### Sectors

A sector is made up of a number of [Solar Systems](#solar-systems).

### Solar Systems

Each solar system may contain as many of the following as the user wishes:
* Celestial Bodies: A body can be a planet, gas giant, astroid field, a gas or particle ring or sphere, a star, etc.
* Structures: A structure can be stations, mining bases, military bases, etc. The user describes what the structure is by using the "Description" field when adding this item.
* Species:
* Cities:

## Time
Back to [Table of Contents](#table-of-contents)

Time is tracked by Galactic Year (the exact duration of this year is up to the user of this tool), followed by a decimal representing a tenth of a year (e.g. 1234.5). This time is not automatically generated, but must be entered, tracked, maintained by the user.

## Data
Back to [Table of Contents](#table-of-contents)

This tool tracks:
 * [Galactic Sectors](#galactic-sectors)
 * [Galactic Zones](#galactic-zones)
 * [Regions](#regions)
 * [Sectors](#sectors)
 * [Solar Systems](#solar-systems)
 * [Time](#time) (as an entered date, not as a live event)
 * Events
 * Governments
 * Organizations
 * Species
 * Celestial Bodies
 * Structures
 * Cities
 * Ships
 * Equipment

 Each of the following has a unique ID set at the time the item is created that adheres to the following template. This will require the user to know the location within the galaxy of a Solar System as they are entering it into the database.

 SectorNumber-GalacticZoneAddress-RegionAddress-SectorAddress-SolarSystemAddress

 All other items use an unique ID created by SQL Server as it is added to the database.

 ## Adding Data
 Back to [Table of Contents](#table-of-contents)

 Instructions Table of Contents:
 1. [Adding Solar Systems](#adding-solar-systems)

 As you enter data, some fields will be required, others will be optional. Each will be labled accordingly and you will not be able to finalize the entry if any of the required fields are left blank.

 ### Adding Solar Systems

  * To add a Solar System you must first select a Galactic Sector.
  * Next, select a Galactic Zone. Galaxy Forge adds the Galactic Sector number to the beginning of the address, and also adds the address of the Galactic Zone to the Unique ID.
  * Select the Region.
  * Select the Sector.
  * Finally, select the specific hex you would like to use for your new Solar System.
  * If you wish to add more Solar Systems into this Sector, simply select a new hex and add the desired information. Galaxy Forge will use the address within the galaxy, plus the address for the new Solar System, as the unique ID for this additional Solar System.