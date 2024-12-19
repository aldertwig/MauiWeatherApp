using System.Text.Json.Serialization;

namespace WeatherApp.Models
{
    public class GeoLocation
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("local_names")]
        public LocalNames? LocalNames { get; set; }

        [JsonPropertyName("lat")]
        public double? Lat { get; set; }

        [JsonPropertyName("lon")]
        public double? Lon { get; set; }

        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }
    }

    public class LocalNames
    {
        [JsonPropertyName("ms")]
        public string Ms { get; set; }

        [JsonPropertyName("gu")]
        public string Gu { get; set; }

        [JsonPropertyName("is")]
        public string Is { get; set; }

        [JsonPropertyName("wa")]
        public string Wa { get; set; }

        [JsonPropertyName("mg")]
        public string Mg { get; set; }

        [JsonPropertyName("gl")]
        public string Gl { get; set; }

        [JsonPropertyName("om")]
        public string Om { get; set; }

        [JsonPropertyName("ku")]
        public string Ku { get; set; }

        [JsonPropertyName("tw")]
        public string Tw { get; set; }

        [JsonPropertyName("mk")]
        public string Mk { get; set; }

        [JsonPropertyName("ee")]
        public string Ee { get; set; }

        [JsonPropertyName("fj")]
        public string Fj { get; set; }

        [JsonPropertyName("gd")]
        public string Gd { get; set; }

        [JsonPropertyName("ky")]
        public string Ky { get; set; }

        [JsonPropertyName("yo")]
        public string Yo { get; set; }

        [JsonPropertyName("zu")]
        public string Zu { get; set; }

        [JsonPropertyName("bg")]
        public string Bg { get; set; }

        [JsonPropertyName("tk")]
        public string Tk { get; set; }

        [JsonPropertyName("co")]
        public string Co { get; set; }

        [JsonPropertyName("sh")]
        public string Sh { get; set; }

        [JsonPropertyName("de")]
        public string De { get; set; }

        [JsonPropertyName("kl")]
        public string Kl { get; set; }

        [JsonPropertyName("bi")]
        public string Bi { get; set; }

        [JsonPropertyName("km")]
        public string Km { get; set; }

        [JsonPropertyName("lt")]
        public string Lt { get; set; }

        [JsonPropertyName("fi")]
        public string Fi { get; set; }

        [JsonPropertyName("fy")]
        public string Fy { get; set; }

        [JsonPropertyName("ba")]
        public string Ba { get; set; }

        [JsonPropertyName("sc")]
        public string Sc { get; set; }

        [JsonPropertyName("feature_name")]
        public string FeatureName { get; set; }

        [JsonPropertyName("ja")]
        public string Ja { get; set; }

        [JsonPropertyName("am")]
        public string Am { get; set; }

        [JsonPropertyName("sk")]
        public string Sk { get; set; }

        [JsonPropertyName("mr")]
        public string Mr { get; set; }

        [JsonPropertyName("es")]
        public string Es { get; set; }

        [JsonPropertyName("sq")]
        public string Sq { get; set; }

        [JsonPropertyName("te")]
        public string Te { get; set; }

        [JsonPropertyName("br")]
        public string Br { get; set; }

        [JsonPropertyName("uz")]
        public string Uz { get; set; }

        [JsonPropertyName("da")]
        public string Da { get; set; }

        [JsonPropertyName("sw")]
        public string Sw { get; set; }

        [JsonPropertyName("fa")]
        public string Fa { get; set; }

        [JsonPropertyName("sr")]
        public string Sr { get; set; }

        [JsonPropertyName("cu")]
        public string Cu { get; set; }

        [JsonPropertyName("ln")]
        public string Ln { get; set; }

        [JsonPropertyName("na")]
        public string Na { get; set; }

        [JsonPropertyName("wo")]
        public string Wo { get; set; }

        [JsonPropertyName("ig")]
        public string Ig { get; set; }

        [JsonPropertyName("to")]
        public string To { get; set; }

        [JsonPropertyName("ta")]
        public string Ta { get; set; }

        [JsonPropertyName("mt")]
        public string Mt { get; set; }

        [JsonPropertyName("ar")]
        public string Ar { get; set; }

        [JsonPropertyName("su")]
        public string Su { get; set; }

        [JsonPropertyName("ab")]
        public string Ab { get; set; }

        [JsonPropertyName("ps")]
        public string Ps { get; set; }

        [JsonPropertyName("bm")]
        public string Bm { get; set; }

        [JsonPropertyName("mi")]
        public string Mi { get; set; }

        [JsonPropertyName("kn")]
        public string Kn { get; set; }

        [JsonPropertyName("kv")]
        public string Kv { get; set; }

        [JsonPropertyName("os")]
        public string Os { get; set; }

        [JsonPropertyName("bn")]
        public string Bn { get; set; }

        [JsonPropertyName("li")]
        public string Li { get; set; }

        [JsonPropertyName("vi")]
        public string Vi { get; set; }

        [JsonPropertyName("zh")]
        public string Zh { get; set; }

        [JsonPropertyName("eo")]
        public string Eo { get; set; }

        [JsonPropertyName("ha")]
        public string Ha { get; set; }

        [JsonPropertyName("tt")]
        public string Tt { get; set; }

        [JsonPropertyName("lb")]
        public string Lb { get; set; }

        [JsonPropertyName("ce")]
        public string Ce { get; set; }

        [JsonPropertyName("hu")]
        public string Hu { get; set; }

        [JsonPropertyName("it")]
        public string It { get; set; }

        [JsonPropertyName("tl")]
        public string Tl { get; set; }

        [JsonPropertyName("pl")]
        public string Pl { get; set; }

        [JsonPropertyName("sm")]
        public string Sm { get; set; }

        [JsonPropertyName("en")]
        public string En { get; set; }

        [JsonPropertyName("vo")]
        public string Vo { get; set; }

        [JsonPropertyName("el")]
        public string El { get; set; }

        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        [JsonPropertyName("fr")]
        public string Fr { get; set; }

        [JsonPropertyName("cs")]
        public string Cs { get; set; }

        [JsonPropertyName("io")]
        public string Io { get; set; }

        [JsonPropertyName("hi")]
        public string Hi { get; set; }

        [JsonPropertyName("et")]
        public string Et { get; set; }

        [JsonPropertyName("pa")]
        public string Pa { get; set; }

        [JsonPropertyName("av")]
        public string Av { get; set; }

        [JsonPropertyName("ko")]
        public string Ko { get; set; }

        [JsonPropertyName("bh")]
        public string Bh { get; set; }

        [JsonPropertyName("yi")]
        public string Yi { get; set; }

        [JsonPropertyName("sa")]
        public string Sa { get; set; }

        [JsonPropertyName("sl")]
        public string Sl { get; set; }

        [JsonPropertyName("hr")]
        public string Hr { get; set; }

        [JsonPropertyName("si")]
        public string Si { get; set; }

        [JsonPropertyName("so")]
        public string So { get; set; }

        [JsonPropertyName("gn")]
        public string Gn { get; set; }

        [JsonPropertyName("ay")]
        public string Ay { get; set; }

        [JsonPropertyName("se")]
        public string Se { get; set; }

        [JsonPropertyName("sd")]
        public string Sd { get; set; }

        [JsonPropertyName("af")]
        public string Af { get; set; }

        [JsonPropertyName("ga")]
        public string Ga { get; set; }

        [JsonPropertyName("or")]
        public string Or { get; set; }

        [JsonPropertyName("ia")]
        public string Ia { get; set; }

        [JsonPropertyName("ie")]
        public string Ie { get; set; }

        [JsonPropertyName("ug")]
        public string Ug { get; set; }

        [JsonPropertyName("nl")]
        public string Nl { get; set; }

        [JsonPropertyName("gv")]
        public string Gv { get; set; }

        [JsonPropertyName("qu")]
        public string Qu { get; set; }

        [JsonPropertyName("be")]
        public string Be { get; set; }

        [JsonPropertyName("an")]
        public string An { get; set; }

        [JsonPropertyName("fo")]
        public string Fo { get; set; }

        [JsonPropertyName("hy")]
        public string Hy { get; set; }

        [JsonPropertyName("nv")]
        public string Nv { get; set; }

        [JsonPropertyName("bo")]
        public string Bo { get; set; }

        [JsonPropertyName("ascii")]
        public string Ascii { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("lv")]
        public string Lv { get; set; }

        [JsonPropertyName("ca")]
        public string Ca { get; set; }

        [JsonPropertyName("no")]
        public string No { get; set; }

        [JsonPropertyName("nn")]
        public string Nn { get; set; }

        [JsonPropertyName("ml")]
        public string Ml { get; set; }

        [JsonPropertyName("my")]
        public string My { get; set; }

        [JsonPropertyName("ne")]
        public string Ne { get; set; }

        [JsonPropertyName("he")]
        public string He { get; set; }

        [JsonPropertyName("cy")]
        public string Cy { get; set; }

        [JsonPropertyName("lo")]
        public string Lo { get; set; }

        [JsonPropertyName("jv")]
        public string Jv { get; set; }

        [JsonPropertyName("sv")]
        public string Sv { get; set; }

        [JsonPropertyName("mn")]
        public string Mn { get; set; }

        [JsonPropertyName("tg")]
        public string Tg { get; set; }

        [JsonPropertyName("kw")]
        public string Kw { get; set; }

        [JsonPropertyName("cv")]
        public string Cv { get; set; }

        [JsonPropertyName("az")]
        public string Az { get; set; }

        [JsonPropertyName("oc")]
        public string Oc { get; set; }

        [JsonPropertyName("th")]
        public string Th { get; set; }

        [JsonPropertyName("ru")]
        public string Ru { get; set; }

        [JsonPropertyName("ny")]
        public string Ny { get; set; }

        [JsonPropertyName("bs")]
        public string Bs { get; set; }

        [JsonPropertyName("st")]
        public string St { get; set; }

        [JsonPropertyName("ro")]
        public string Ro { get; set; }

        [JsonPropertyName("rm")]
        public string Rm { get; set; }

        [JsonPropertyName("ff")]
        public string Ff { get; set; }

        [JsonPropertyName("kk")]
        public string Kk { get; set; }

        [JsonPropertyName("uk")]
        public string Uk { get; set; }

        [JsonPropertyName("pt")]
        public string Pt { get; set; }

        [JsonPropertyName("tr")]
        public string Tr { get; set; }

        [JsonPropertyName("eu")]
        public string Eu { get; set; }

        [JsonPropertyName("ht")]
        public string Ht { get; set; }

        [JsonPropertyName("ka")]
        public string Ka { get; set; }

        [JsonPropertyName("ur")]
        public string Ur { get; set; }

        [JsonPropertyName("oj")]
        public string Oj { get; set; }

        [JsonPropertyName("cr")]
        public string Cr { get; set; }

        [JsonPropertyName("iu")]
        public string Iu { get; set; }
    }
}
