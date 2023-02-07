# Galaxy Forge

## NOTE: This is a work in progress!

Galaxy Forge is a tool to to build out the lore for your galaxy. There is a potential for 1,477,003,723 solar systems throughout this galaxy.

This tool does not come pre-populated with data, but needs to be fleshed out by the user.

## Table of Contents
1. [Galactic Map](#galactic-map)
2. [Data Structure](#data-structure)

## Galactic Map

The Galactic Map is depicted in a 2D envionment. Each section occupies the thickness of the galactic ring.

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

On each edge of the [Galactic Core](#galactic-core) is a Galactic Sector, making six galactic sectors in total. 

Each galactic sector is made up of 51 [Glactic Zones](#galactic-zones) in the shape of half of an hexagon (see [Galactic Map](#galactic-map)), made up of hexagons.

### Galactic Zones

Each galactic zone consists of 169 [Regions](#regions).

### Regions

Each region is made up of 169 [Sectors](#sectors).

### Sectors

A sector is made up of 169 [Solar Systems](#solar-systems).

### Solar Systems

Each solar system may contain:
* 0 to 3 stars
* 0 to 20 bodies. A body can be a planet, gas giant, astroid field, or gas or particle ring or sphere.
* 0 to 5 primary species

## Data Structure
