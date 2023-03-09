const graphql = require('graphql');
const _ = require('lodash');    //  tool for searching arrays
const GalacticSector = require('../models/galacticSector');
const GalacticZone = require('../models/galacticZone');

// grab functions from graphql
const {
    GraphQLObjectType,
    GraphQLID,
    GraphQLString,
    GraphQLInt,
    GraphQLSchema,
    GraphQLList,
} = graphql;

//  dummy data
/**
 * var galacticSectors = [
    { name: 'Sector 1', q: '0', r: '0', s: '0', id: '1' },
    { name: 'Sector 2', q: '0', r: '1', s: '0', id: '2' },
    { name: 'Sector 3', q: '0', r: '2', s: '0', id: '3' },
    { name: 'Sector 4', q: '0', r: '3', s: '0', id: '4' },
    { name: 'Sector 5', q: '0', r: '4', s: '0', id: '5' },
    { name: 'Sector 6', q: '0', r: '5', s: '0', id: '6' },
];
var galacticZones = [
    { name: 'Region 1', q: '0', r: '0', s: '0', id: '1', galacticSectorId: '1' },
    { name: 'Region 2', q: '0', r: '1', s: '0', id: '2', galacticSectorId: '2' },
    { name: 'Region 3', q: '0', r: '2', s: '0', id: '3', galacticSectorId: '2' },
    { name: 'Region 4', q: '0', r: '3', s: '0', id: '4', galacticSectorId: '5' },
    { name: 'Region 5', q: '0', r: '4', s: '0', id: '5', galacticSectorId: '5' },
    { name: 'Region 6', q: '0', r: '5', s: '0', id: '6', galacticSectorId: '4' },
];
 * */

//  define types
const GalacticSectorType = new GraphQLObjectType({
    name: 'GalacticSector',
    fields: () => ({
        id: { type: GraphQLID },
        q: { type: GraphQLString },
        r: { type: GraphQLString },
        s: { type: GraphQLString },
        name: { type: GraphQLString },
        galacticZones: {
            type: new GraphQLList(GalacticZoneType),
            resolve(parent, args) {
                //return _.filter(galacticZones, { galacticSectorId: parent.id });
            }
        }
    })
});

const GalacticZoneType = new GraphQLObjectType({
    name: 'GalacticRegion',
    fields: () => ({
        id: { type: GraphQLID },
        q: { type: GraphQLInt },
        r: { type: GraphQLInt },
        s: { type: GraphQLInt },
        name: { type: GraphQLString },
        galacticSector: {
            type: GalacticSectorType,
            resolve(parent, args) {
                //return _.find(galacticSectors, { id: parent.galacticSectorId })
            }
        },
    })
})

const RootQuery = new GraphQLObjectType({
    name: 'RootQueryType',
    fields: {
        galacticSector: {
            type: GalacticSectorType,
            args: { id: { type: GraphQLID } },
            resolve(parent, args) {
                //  code to get data from db / other source
                //return _.find(galacticSectors, { id: args.id });
            }
        },
        galacticZone: {
            type: GalacticZoneType,
            args: { id: { type: GraphQLID } },
            resolve(parent, args) {
                //return _.find(galacticZones, { id: args.id });
            }
        },
        galacticZones: {
            type: new GraphQLList(GalacticZoneType),
            resolve(parent, args) {
                //return galacticZones;
            }
        },
        galacticSectors: {
            type: new GraphQLList(GalacticSectorType),
            resolve(parent, args) {
                //return galacticSectors;
            }
        }
    }
});

const Mutation = new GraphQLObjectType({
    name: 'Mutation',
    fields: {
        addGalacticSector: {
            type: GalacticSectorType,
            args: {
                q: { type: GraphQLString },
                r: { type: GraphQLString },
                s: { type: GraphQLString },
                name: { type: GraphQLString },
            },
            resolve(parent, args) {
                let galacticSector = new GalacticSector({
                    q: args.q,
                    r: args.r,
                    s: args.s,
                    name: args.name,
                });
                return galacticSector.save();
            }
        },
        addGalacticZone: {
            type: GalacticZoneType,
            args: {
                q: { type: GraphQLString },
                r: { type: GraphQLString },
                s: { type: GraphQLString },
                name: { type: GraphQLString },
            },
            resolve(parent, args) {
                let galacticZone = new GalacticZone({
                    q: args.q,
                    r: args.r,
                    s: args.s,
                    name: args.name,
                });
                return galacticZone.save();
            }
        },
    }
})

module.exports = new GraphQLSchema({
    query: RootQuery,
    mutation: Mutation
});