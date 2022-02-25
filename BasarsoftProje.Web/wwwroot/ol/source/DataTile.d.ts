export default DataTileSource;
/**
 * Data tile loading function.  The function is called with z, x, and y tile coordinates and
 * returns {@link import("../DataTile.js").Data data} for a tile or a promise for the same.
 */
export type Loader = (arg0: number, arg1: number, arg2: number) => Uint8ClampedArray | Uint8Array | Float32Array | DataView | Promise<Uint8ClampedArray | Uint8Array | Float32Array | DataView>;
export type Options = {
    /**
     * Data loader.  Called with z, x, and y tile coordinates.
     * Returns {@link import("../DataTile.js").Data data} for a tile or a promise for the same.
     */
    loader?: (arg0: number, arg1: number, arg2: number) => Uint8ClampedArray | Uint8Array | Float32Array | DataView | Promise<Uint8ClampedArray | Uint8Array | Float32Array | DataView>;
    /**
     * Attributions.
     */
    attributions?: string | string[] | ((arg0: import("../PluggableMap.js").FrameState) => string | string[]);
    /**
     * Attributions are collapsible.
     */
    attributionsCollapsible?: boolean;
    /**
     * Optional max zoom level. Not used if `tileGrid` is provided.
     */
    maxZoom?: number;
    /**
     * Optional min zoom level. Not used if `tileGrid` is provided.
     */
    minZoom?: number;
    /**
     * The pixel width and height of the tiles.
     */
    tileSize?: number | number[];
    /**
     * Optional tile grid resolution at level zero. Not used if `tileGrid` is provided.
     */
    maxResolution?: number;
    /**
     * Tile projection.
     */
    projection?: string | import("../proj/Projection.js").default | undefined;
    /**
     * Tile grid.
     */
    tileGrid?: import("../tilegrid/TileGrid.js").default;
    /**
     * Whether the layer is opaque.
     */
    opaque?: boolean;
    /**
     * The source state.
     */
    state?: any;
    /**
     * Tile pixel ratio.
     */
    tilePixelRatio?: number;
    /**
     * Render tiles beyond the antimeridian.
     */
    wrapX?: boolean;
    /**
     * Transition time when fading in new tiles (in miliseconds).
     */
    transition?: number;
    /**
     * Number of bands represented in the data.
     */
    bandCount?: number;
    /**
     * Use interpolated values when resampling.  By default,
     * the nearest neighbor is used when resampling.
     */
    interpolate?: boolean;
};
/**
 * Data tile loading function.  The function is called with z, x, and y tile coordinates and
 * returns {@link import("../DataTile.js").Data data} for a tile or a promise for the same.
 * @typedef {function(number, number, number) : (import("../DataTile.js").Data|Promise<import("../DataTile.js").Data>)} Loader
 */
/**
 * @typedef {Object} Options
 * @property {Loader} [loader] Data loader.  Called with z, x, and y tile coordinates.
 * Returns {@link import("../DataTile.js").Data data} for a tile or a promise for the same.
 * @property {import("./Source.js").AttributionLike} [attributions] Attributions.
 * @property {boolean} [attributionsCollapsible=true] Attributions are collapsible.
 * @property {number} [maxZoom=42] Optional max zoom level. Not used if `tileGrid` is provided.
 * @property {number} [minZoom=0] Optional min zoom level. Not used if `tileGrid` is provided.
 * @property {number|import("../size.js").Size} [tileSize=[256, 256]] The pixel width and height of the tiles.
 * @property {number} [maxResolution] Optional tile grid resolution at level zero. Not used if `tileGrid` is provided.
 * @property {import("../proj.js").ProjectionLike} [projection='EPSG:3857'] Tile projection.
 * @property {import("../tilegrid/TileGrid.js").default} [tileGrid] Tile grid.
 * @property {boolean} [opaque=false] Whether the layer is opaque.
 * @property {import("./State.js").default} [state] The source state.
 * @property {number} [tilePixelRatio] Tile pixel ratio.
 * @property {boolean} [wrapX=false] Render tiles beyond the antimeridian.
 * @property {number} [transition] Transition time when fading in new tiles (in miliseconds).
 * @property {number} [bandCount=4] Number of bands represented in the data.
 * @property {boolean} [interpolate=false] Use interpolated values when resampling.  By default,
 * the nearest neighbor is used when resampling.
 */
/**
 * @classdesc
 * A source for typed array data tiles.
 *
 * @fires import("./Tile.js").TileSourceEvent
 * @api
 */
declare class DataTileSource extends TileSource {
    /**
     * @param {Options} options Image tile options.
     */
    constructor(options: Options);
    /**
     * @private
     * @type {!Object<string, boolean>}
     */
    private tileLoadingKeys_;
    /**
     * @private
     */
    private loader_;
    /**
     * Handle tile change events.
     * @param {import("../events/Event.js").default} event Event.
     */
    handleTileChange_(event: import("../events/Event.js").default): void;
    /**
     * @type {number}
     */
    bandCount: number;
    /**
     * @param {Loader} loader The data loader.
     * @protected
     */
    protected setLoader(loader: (arg0: number, arg1: number, arg2: number) => Uint8ClampedArray | Uint8Array | Float32Array | DataView | Promise<Uint8ClampedArray | Uint8Array | Float32Array | DataView>): void;
    /**
     * @abstract
     * @param {number} z Tile coordinate z.
     * @param {number} x Tile coordinate x.
     * @param {number} y Tile coordinate y.
     * @param {number} pixelRatio Pixel ratio.
     * @param {import("../proj/Projection.js").default} projection Projection.
     * @return {!DataTile} Tile.
     */
    getTile(z: number, x: number, y: number, pixelRatio: number, projection: import("../proj/Projection.js").default): DataTile;
}
import TileSource from "./Tile.js";
import DataTile from "../DataTile.js";
//# sourceMappingURL=DataTile.d.ts.map