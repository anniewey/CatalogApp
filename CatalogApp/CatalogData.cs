using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CatalogApp
{
    public partial class CatalogData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_modified")]
        public DateTimeOffset DateModified { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("catalog_visibility")]
        public Visibility CatalogVisibility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("regular_price")]
        public RegularPrice RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; }

        [JsonProperty("stock_quantity")]
        public long? StockQuantity { get; set; }

        [JsonProperty("in_stock")]
        public bool InStock { get; set; }

        [JsonProperty("backorders")]
        public WeatherDatumBackorders Backorders { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool Backordered { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public long ShippingClassId { get; set; }

        [JsonProperty("cross_sell_ids")]
        public object[] CrossSellIds { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("attributes")]
        public PurpleAttribute[] Attributes { get; set; }

        [JsonProperty("default_attributes")]
        public DefaultAttributeElement[] DefaultAttributes { get; set; }

        [JsonProperty("variations")]
        public Variation[] Variations { get; set; }

        [JsonProperty("menu_order")]
        public long MenuOrder { get; set; }

        [JsonProperty("composite_layout")]
        public string CompositeLayout { get; set; }

        [JsonProperty("composite_components")]
        public CompositeComponent[] CompositeComponents { get; set; }

        [JsonProperty("composite_scenarios")]
        public object[] CompositeScenarios { get; set; }

        [JsonProperty("bundle_layout")]
        public string BundleLayout { get; set; }

        [JsonProperty("bundled_by")]
        public object[] BundledBy { get; set; }

        [JsonProperty("bundled_items")]
        public BundledItem[] BundledItems { get; set; }

        [JsonProperty("custom_fields")]
        public ProductCustomFields CustomFields { get; set; }

        [JsonProperty("pricing_groups")]
        public object[] PricingGroups { get; set; }

        [JsonProperty("mixed_sku_volume_pricing_group")]
        public MixedSkuVolumePricingGroup MixedSkuVolumePricingGroup { get; set; }

        [JsonProperty("composite_product_details")]
        public CompositeProductDetails CompositeProductDetails { get; set; }

        [JsonProperty("bundle_product_details")]
        public BundleProductDetails BundleProductDetails { get; set; }

        [JsonProperty("group_of")]
        public long GroupOf { get; set; }

        [JsonProperty("minimum_quantity")]
        public object MinimumQuantity { get; set; }

        [JsonProperty("maximum_quantity")]
        public object MaximumQuantity { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("points_earned", NullValueHandling = NullValueHandling.Ignore)]
        public string PointsEarned { get; set; }

        [JsonProperty("points_required", NullValueHandling = NullValueHandling.Ignore)]
        public string PointsRequired { get; set; }

        [JsonProperty("maximum_points_discount", NullValueHandling = NullValueHandling.Ignore)]
        public string MaximumPointsDiscount { get; set; }

        [JsonProperty("inventory", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Inventory { get; set; }
    }

    public partial class PurpleAttribute
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public long Position { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("options")]
        public string[] Options { get; set; }
    }

    public partial class BundleProductDetails
    {
        [JsonProperty("per_item_pricing")]
        public bool PerItemPricing { get; set; }

        [JsonProperty("products")]
        public BundleProductDetailsProduct[] Products { get; set; }
    }

    public partial class BundleProductDetailsProduct
    {
        [JsonProperty("product")]
        public ProductProduct Product { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("minimum_quantity")]
        public long MinimumQuantity { get; set; }

        [JsonProperty("maximum_quantity")]
        public long MaximumQuantity { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("discount_percentage")]
        public long DiscountPercentage { get; set; }
    }

    public partial class ProductProduct
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_modified")]
        public DateTimeOffset DateModified { get; set; }

        [JsonProperty("type")]
        public TypeEnum Type { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("catalog_visibility")]
        public Visibility CatalogVisibility { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sku")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Sku { get; set; }

        [JsonProperty("regular_price")]
        public string RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; }

        [JsonProperty("stock_quantity")]
        public long StockQuantity { get; set; }

        [JsonProperty("in_stock")]
        public bool InStock { get; set; }

        [JsonProperty("backorders")]
        public WeatherDatumBackorders Backorders { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool Backordered { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public long ShippingClassId { get; set; }

        [JsonProperty("cross_sell_ids")]
        public object[] CrossSellIds { get; set; }

        [JsonProperty("categories")]
        public Category[] Categories { get; set; }

        [JsonProperty("tags")]
        public Category[] Tags { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("attributes")]
        public PurpleAttribute[] Attributes { get; set; }

        [JsonProperty("default_attributes")]
        public DefaultAttributeElement[] DefaultAttributes { get; set; }

        [JsonProperty("variations")]
        public Variation[] Variations { get; set; }

        [JsonProperty("menu_order")]
        public long MenuOrder { get; set; }

        [JsonProperty("composite_layout")]
        public string CompositeLayout { get; set; }

        [JsonProperty("composite_components")]
        public object[] CompositeComponents { get; set; }

        [JsonProperty("composite_scenarios")]
        public object[] CompositeScenarios { get; set; }

        [JsonProperty("bundle_layout")]
        public string BundleLayout { get; set; }

        [JsonProperty("bundled_by")]
        [JsonConverter(typeof(DecodeArrayConverter))]
        public long[] BundledBy { get; set; }

        [JsonProperty("bundled_items")]
        public object[] BundledItems { get; set; }

        [JsonProperty("custom_fields")]
        public ProductCustomFields CustomFields { get; set; }

        [JsonProperty("pricing_groups")]
        public object[] PricingGroups { get; set; }

        [JsonProperty("compound_product_parents")]
        public CompoundProductParent[] CompoundProductParents { get; set; }

        [JsonProperty("mixed_sku_volume_pricing_group")]
        public MixedSkuVolumePricingGroup MixedSkuVolumePricingGroup { get; set; }

        [JsonProperty("composite_product_details")]
        public object CompositeProductDetails { get; set; }

        [JsonProperty("bundle_product_details")]
        public object BundleProductDetails { get; set; }

        [JsonProperty("group_of")]
        public long GroupOf { get; set; }

        [JsonProperty("minimum_quantity")]
        public object MinimumQuantity { get; set; }

        [JsonProperty("maximum_quantity")]
        public object MaximumQuantity { get; set; }

        [JsonProperty("allowed_variations")]
        public long[] AllowedVariations { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }
    }

    public partial class CompoundProductParent
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("customer_tiers")]
        public object CustomerTiers { get; set; }

        [JsonProperty("price_tags")]
        public object PriceTags { get; set; }
    }

    public partial class ProductCustomFields
    {
        [JsonProperty("sales_item")]
        public string SalesItem { get; set; }

        [JsonProperty("internal_sales_item")]
        public string InternalSalesItem { get; set; }

        [JsonProperty("inventory_item")]
        public string InventoryItem { get; set; }

        [JsonProperty("to_hide_during_picking_and_packing")]
        public string ToHideDuringPickingAndPacking { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("disallow_children_backorders")]
        public string DisallowChildrenBackorders { get; set; }

        [JsonProperty("customer_tiers")]
        public string CustomerTiers { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("is_rack_barcode")]
        public string IsRackBarcode { get; set; }

        [JsonProperty("customers")]
        public string Customers { get; set; }

        [JsonProperty("price_tags")]
        public string PriceTags { get; set; }
    }

    public partial class DefaultAttributeElement
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("option")]
        public string Option { get; set; }
    }

    public partial class Dimensions
    {
        [JsonProperty("length")]
        public string Length { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("src")]
        public Uri Src { get; set; }

        [JsonProperty("alt")]
        public string Alt { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("src_small")]
        public Uri SrcSmall { get; set; }

        [JsonProperty("src_medium")]
        public Uri SrcMedium { get; set; }

        [JsonProperty("src_large")]
        public Uri SrcLarge { get; set; }

        [JsonProperty("youtube_video_id", NullValueHandling = NullValueHandling.Ignore)]
        public string YoutubeVideoId { get; set; }
    }

    public partial class MixedSkuVolumePricingGroup
    {
        [JsonProperty("product_ids")]
        public object[] ProductIds { get; set; }

        [JsonProperty("product_attributes")]
        public object[] ProductAttributes { get; set; }
    }

    public partial class Variation
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("regular_price")]
        public string RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        public string SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        public string DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_to")]
        public string DateOnSaleTo { get; set; }

        [JsonProperty("tax_class")]
        public string TaxClass { get; set; }

        [JsonProperty("manage_stock")]
        public bool ManageStock { get; set; }

        [JsonProperty("stock_quantity")]
        public long StockQuantity { get; set; }

        [JsonProperty("in_stock")]
        public bool InStock { get; set; }

        [JsonProperty("backorders")]
        public VariationBackorders Backorders { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool Backordered { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }

        [JsonProperty("dimensions")]
        public Dimensions Dimensions { get; set; }

        [JsonProperty("shipping_class")]
        public string ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public long ShippingClassId { get; set; }

        [JsonProperty("image")]
        public object[] Image { get; set; }

        [JsonProperty("attributes")]
        public DefaultAttributeElement[] Attributes { get; set; }

        [JsonProperty("custom_fields")]
        public VariationCustomFields CustomFields { get; set; }

        [JsonProperty("points_earned")]
        public string PointsEarned { get; set; }

        [JsonProperty("points_required")]
        public string PointsRequired { get; set; }

        [JsonProperty("maximum_points_discount")]
        public string MaximumPointsDiscount { get; set; }

        [JsonProperty("inventory")]
        public Inventory[] Inventory { get; set; }
    }

    public partial class VariationCustomFields
    {
        [JsonProperty("to_hide")]
        public object ToHide { get; set; }

        [JsonProperty("cost")]
        public object Cost { get; set; }

        [JsonProperty("customer_tiers_on_sale")]
        public string CustomerTiersOnSale { get; set; }

        [JsonProperty("variation_barcode")]
        public string VariationBarcode { get; set; }

        [JsonProperty("variation_shelf")]
        public string VariationShelf { get; set; }

        [JsonProperty("conversionrategroup")]
        public Conversionrategroup Conversionrategroup { get; set; }

        [JsonProperty("conversionrate")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Conversionrate { get; set; }
    }

    public partial class Inventory
    {
        [JsonProperty("branch_id")]
        public long BranchId { get; set; }

        [JsonProperty("batch_id")]
        public object BatchId { get; set; }

        [JsonProperty("stock_quantity")]
        public double StockQuantity { get; set; }

        [JsonProperty("physical_stock_quantity")]
        public double PhysicalStockQuantity { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }
    }

    public partial class BundledItem
    {
        [JsonProperty("bundled_item_id")]
        public long BundledItemId { get; set; }

        [JsonProperty("product_id")]
        public long ProductId { get; set; }

        [JsonProperty("menu_order")]
        public long MenuOrder { get; set; }

        [JsonProperty("quantity_min")]
        public long QuantityMin { get; set; }

        [JsonProperty("quantity_max")]
        public long QuantityMax { get; set; }

        [JsonProperty("priced_individually")]
        public bool PricedIndividually { get; set; }

        [JsonProperty("shipped_individually")]
        public bool ShippedIndividually { get; set; }

        [JsonProperty("override_title")]
        public bool OverrideTitle { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("override_description")]
        public bool OverrideDescription { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("hide_thumbnail")]
        public bool HideThumbnail { get; set; }

        [JsonProperty("discount")]
        public RegularPrice Discount { get; set; }

        [JsonProperty("override_variations")]
        public bool OverrideVariations { get; set; }

        [JsonProperty("allowed_variations")]
        public long[] AllowedVariations { get; set; }

        [JsonProperty("override_default_variation_attributes")]
        public bool OverrideDefaultVariationAttributes { get; set; }

        [JsonProperty("default_variation_attributes")]
        public object[] DefaultVariationAttributes { get; set; }

        [JsonProperty("single_product_visibility")]
        public Visibility SingleProductVisibility { get; set; }

        [JsonProperty("cart_visibility")]
        public Visibility CartVisibility { get; set; }

        [JsonProperty("order_visibility")]
        public Visibility OrderVisibility { get; set; }

        [JsonProperty("single_product_price_visibility")]
        public Visibility SingleProductPriceVisibility { get; set; }

        [JsonProperty("cart_price_visibility")]
        public Visibility CartPriceVisibility { get; set; }

        [JsonProperty("order_price_visibility")]
        public Visibility OrderPriceVisibility { get; set; }

        [JsonProperty("stock_status")]
        public string StockStatus { get; set; }
    }

    public partial class CompositeComponent
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("query_type")]
        public string QueryType { get; set; }

        [JsonProperty("query_ids")]
        public long[] QueryIds { get; set; }

        [JsonProperty("default_option_id")]
        public string DefaultOptionId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("quantity_min")]
        public long QuantityMin { get; set; }

        [JsonProperty("quantity_max")]
        public string QuantityMax { get; set; }

        [JsonProperty("priced_individually")]
        public bool PricedIndividually { get; set; }

        [JsonProperty("shipped_individually")]
        public bool ShippedIndividually { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("discount")]
        public long Discount { get; set; }

        [JsonProperty("options_style")]
        public string OptionsStyle { get; set; }
    }

    public partial class CompositeProductDetails
    {
        [JsonProperty("per_item_pricing")]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public bool PerItemPricing { get; set; }

        [JsonProperty("components")]
        public Component[] Components { get; set; }
    }

    public partial class Component
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("products")]
        public ProductProduct[] Products { get; set; }

        [JsonProperty("number_of_different_products_allowed")]
        public long NumberOfDifferentProductsAllowed { get; set; }

        [JsonProperty("minimum_quantity")]
        public long MinimumQuantity { get; set; }

        [JsonProperty("maximum_quantity")]
        public string MaximumQuantity { get; set; }

        [JsonProperty("is_same_sku_free_item")]
        public bool IsSameSkuFreeItem { get; set; }

        [JsonProperty("same_sku_free_quantity")]
        public long SameSkuFreeQuantity { get; set; }

        [JsonProperty("different_sku_free_quantity")]
        public long DifferentSkuFreeQuantity { get; set; }

        [JsonProperty("lowest_price_free")]
        public bool LowestPriceFree { get; set; }

        [JsonProperty("discount_percentage")]
        public long DiscountPercentage { get; set; }

        [JsonProperty("discount_on_regular_price")]
        public bool DiscountOnRegularPrice { get; set; }

        [JsonProperty("price")]
        public object Price { get; set; }

        [JsonProperty("composite_minimum_order")]
        public object CompositeMinimumOrder { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("self")]
        public Collection[] Self { get; set; }

        [JsonProperty("collection")]
        public Collection[] Collection { get; set; }
    }

    public partial class Collection
    {
        [JsonProperty("href")]
        public Uri Href { get; set; }
    }


    public enum WeatherDatumBackorders { No };

    public enum Visibility { Visible };

    public enum Status { Publish };

    public enum TypeEnum { Bundle, Composite, Variable };

    public enum VariationBackorders { Yes };

    public enum Conversionrategroup { Group0 };


    public partial struct RegularPrice
    {
        public long? Integer;
        public string String;

        public static implicit operator RegularPrice(long Integer) => new RegularPrice { Integer = Integer };
        public static implicit operator RegularPrice(string String) => new RegularPrice { String = String };
    }

    internal class WeatherDatumBackordersConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(WeatherDatumBackorders) || t == typeof(WeatherDatumBackorders?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "no")
            {
                return WeatherDatumBackorders.No;
            }
            throw new Exception("Cannot unmarshal type WeatherDatumBackorders");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (WeatherDatumBackorders)untypedValue;
            if (value == WeatherDatumBackorders.No)
            {
                serializer.Serialize(writer, "no");
                return;
            }
            throw new Exception("Cannot marshal type WeatherDatumBackorders");
        }

        public static readonly WeatherDatumBackordersConverter Singleton = new WeatherDatumBackordersConverter();
    }

   

    internal class DecodeArrayConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long[]);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = PurpleParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value.ToArray();
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (long[])untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = PurpleParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class VisibilityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Visibility) || t == typeof(Visibility?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "visible")
            {
                return Visibility.Visible;
            }
            throw new Exception("Cannot unmarshal type Visibility");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Visibility)untypedValue;
            if (value == Visibility.Visible)
            {
                serializer.Serialize(writer, "visible");
                return;
            }
            throw new Exception("Cannot marshal type Visibility");
        }

        public static readonly VisibilityConverter Singleton = new VisibilityConverter();
    }

    

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "publish")
            {
                return Status.Publish;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            if (value == Status.Publish)
            {
                serializer.Serialize(writer, "publish");
                return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bundle":
                    return TypeEnum.Bundle;
                case "composite":
                    return TypeEnum.Composite;
                case "variable":
                    return TypeEnum.Variable;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            switch (value)
            {
                case TypeEnum.Bundle:
                    serializer.Serialize(writer, "bundle");
                    return;
                case TypeEnum.Composite:
                    serializer.Serialize(writer, "composite");
                    return;
                case TypeEnum.Variable:
                    serializer.Serialize(writer, "variable");
                    return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class VariationBackordersConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VariationBackorders) || t == typeof(VariationBackorders?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "yes")
            {
                return VariationBackorders.Yes;
            }
            throw new Exception("Cannot unmarshal type VariationBackorders");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VariationBackorders)untypedValue;
            if (value == VariationBackorders.Yes)
            {
                serializer.Serialize(writer, "yes");
                return;
            }
            throw new Exception("Cannot marshal type VariationBackorders");
        }

        public static readonly VariationBackordersConverter Singleton = new VariationBackordersConverter();
    }

    internal class ConversionrategroupConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Conversionrategroup) || t == typeof(Conversionrategroup?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "group0")
            {
                return Conversionrategroup.Group0;
            }
            throw new Exception("Cannot unmarshal type Conversionrategroup");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Conversionrategroup)untypedValue;
            if (value == Conversionrategroup.Group0)
            {
                serializer.Serialize(writer, "group0");
                return;
            }
            throw new Exception("Cannot marshal type Conversionrategroup");
        }

        public static readonly ConversionrategroupConverter Singleton = new ConversionrategroupConverter();
    }



    internal class RegularPriceConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RegularPrice) || t == typeof(RegularPrice?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new RegularPrice { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new RegularPrice { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type RegularPrice");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (RegularPrice)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type RegularPrice");
        }

        public static readonly RegularPriceConverter Singleton = new RegularPriceConverter();
    }

    

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }
}